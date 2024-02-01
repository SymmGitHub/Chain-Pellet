using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ChainPellet
{
    public partial class DolEditor : Form
    {
        public byte[] dolData;
        public bool loading = false;
        public Dictionary<int, string> dolStrings = new Dictionary<int, String>();
        public DolEditor(byte[] data)
        {
            InitializeComponent();
            dolData = data;
        }
        private void DolEditor_Load(object sender, EventArgs e)
        {
            loading = true;
            int start = 0;
            int end = dolData.Length;
            try
            {
                startPos.Text = "001E8F98";
                start = int.Parse(startPos.Text, System.Globalization.NumberStyles.HexNumber);
                endPos.Text = "001EB355";
                end = int.Parse(endPos.Text, System.Globalization.NumberStyles.HexNumber);
                if (start < 0) start = 0;
                if (end > dolData.Length) end = dolData.Length;
            }
            catch { return; }
            StringSearch(start, end);
            loading = false;
            RefreshList();
        }
        private void StringSearch(int start, int end)
        {
            dolStrings = new Dictionary<int, string>();
            string newString = "";
            int address = 0;
            bool typing = false;
            for (int i = start; i < end; i++)
            {
                if (dolData[i] != 0x00)
                {
                    if (!typing) address = i;
                    typing = true;
                    int value = Convert.ToInt32(dolData[i].ToString("X2"), 16);
                    newString += Char.ConvertFromUtf32(value);
                }
                else
                {
                    if (typing)
                    {
                        // Finish String
                        typing = false;
                        if (!String.IsNullOrEmpty(newString.Replace(" ", "")))
                        {
                            dolStrings.Add(address, newString);
                        }
                        newString = "";
                    }
                }
            }
            if (typing)
            {
                // Finish String
                typing = false;
                if (!String.IsNullOrEmpty(newString.Replace(" ", "")))
                {
                    dolStrings.Add(address, newString);
                }
                newString = "";
            }

            stringBox.Text = "";
        }
        private int maxStringLength(int i)
        {
            int length = 0;
            while (dolData[i] != 0x00)
            {
                // Check String Length
                length++;
                i++;
            }
            while (dolData[i] == 0x00)
            {
                // Check amount of trailing zeroes
                length++;
                i++;
            }
            return length - 1;
        }
        private void RefreshList()
        {
            loading = true;
            stringList.Items.Clear();
            if (string.IsNullOrEmpty(filter.Text.Replace(" ", "")))
            {
                // No Filter, show all
                foreach (int a in dolStrings.Keys)
                {
                    string compositeString = a.ToString("X8") + " - " + dolStrings[a];
                    stringList.Items.Add(compositeString);
                }
            }
            else
            {
                // Filter By filter string
                string[] filters = filter.Text.Split("|");
                foreach (string filter in filters)
                {
                    foreach (int a in dolStrings.Keys)
                    {
                        string compositeString = a.ToString("X8") + " - " + dolStrings[a];
                        // Skip checking if it's already part of the Node List
                        if (!stringList.Items.Contains(compositeString))
                        {
                            if (dolStrings[a].ToUpper().Contains(filter.ToUpper()))
                            {
                                stringList.Items.Add(compositeString);
                            }
                        }
                    }
                }
            }
            loading = false;
        }
        private void OverwriteString(int address, string newString)
        {
            int oldLength = dolStrings[address].Length;
            byte[] stringBytes = Encoding.ASCII.GetBytes(newString);
            for (int i = 0; i < oldLength; i++)
            {
                if (i >= stringBytes.Length)
                {
                    dolData[i + address] = 0;
                }
                else dolData[i + address] = stringBytes[i];
            }
            dolStrings[address] = newString;
        }

        private void save_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void filter_TextChanged(object sender, EventArgs e)
        {
            if (loading) return;
            RefreshList();
        }

        private void addressRangeChanged(object sender, EventArgs e)
        {
            if (loading) return;
            loading = true;
            int start = 0;
            int end = dolData.Length;
            stringBox.Text = "";
            try
            {
                start = int.Parse(startPos.Text, System.Globalization.NumberStyles.HexNumber);
                end = int.Parse(endPos.Text, System.Globalization.NumberStyles.HexNumber);
            }
            catch { return; }
            StringSearch(start, end);
            loading = false;
            RefreshList();
        }

        private void stringBox_TextChanged(object sender, EventArgs e)
        {
            if (loading) return;
            loading = true;
            try
            {
                string s = stringList.Items[stringList.SelectedIndex].ToString();
                int address = int.Parse(s.Substring(0, 8), System.Globalization.NumberStyles.HexNumber);
                OverwriteString(address, stringBox.Text);
                string compositeString = address.ToString("X8") + " - " + stringBox.Text;
                stringList.Items[stringList.SelectedIndex] = compositeString;
                CharLimit.Text = (stringBox.MaxLength - stringBox.Text.Length).ToString();
            }
            catch { }
            loading = false;
        }

        private void stringList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            loading = true;
            if (stringList.SelectedIndex == -1)
            {
                stringBox.MaxLength = 0;
                stringBox.Text = "";
                CharLimit.Text = "";
            }
            else
            {
                int a = int.Parse(stringList.SelectedItem.ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber);
                stringBox.MaxLength = maxStringLength(a);
                stringBox.Text = dolStrings[a];
                CharLimit.Text = (stringBox.MaxLength - stringBox.Text.Length).ToString();
            }
            loading = false;
        }
    }
}

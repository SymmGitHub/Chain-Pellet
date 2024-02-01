using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainPellet
{
    public partial class ModelEditor : UserControl
    {
        public string filePath;
        private byte[] loadedBytes = new byte[0];
        private int curAddress;
        Dictionary<string, Dictionary<string, List<string>>> modelPalettes = new Dictionary<string, Dictionary<string, List<string>>>();
        public ModelEditor()
        {
            InitializeComponent();
        }
        private void ModelEditor_Load(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                loadedBytes = File.ReadAllBytes(filePath);

            }
            palette.Items.Clear();
            modelPalettes.Clear();
            int offset = (int)addressOffset.Value;
            SearchColors(offset);
            GetPalettes();
            palette.SelectedIndex = 0;
        }
        private void SearchColors(int offset)
        {
            if (loadedBytes.Length > 0)
            {
                byte[] nxfLabel = new byte[4] { 0x4E, 0x58, 0x46, 0x00 };
                Dictionary<string, List<string>> searchedPalette = new Dictionary<string, List<string>>();
                List<int> colorAddresses = new List<int>();

                for (int i = 0; i < loadedBytes.Length - 4; i++)
                {
                    if (loadedBytes[i] == nxfLabel[0] &&
                        loadedBytes[i + 1] == nxfLabel[1] &&
                        loadedBytes[i + 2] == nxfLabel[2] &&
                        loadedBytes[i + 3] == nxfLabel[3])
                    {
                        // Found NFX
                        try
                        {
                            string floatPointer = loadedBytes[i + 36].ToString("X2") +
                                loadedBytes[i + 37].ToString("X2") +
                                loadedBytes[i + 38].ToString("X2") +
                                loadedBytes[i + 39].ToString("X2");
                            int f = int.Parse(floatPointer, System.Globalization.NumberStyles.HexNumber) + 80;
                            string colorPointer = loadedBytes[i + f].ToString("X2") +
                                loadedBytes[i + f + 1].ToString("X2") +
                                loadedBytes[i + f + 2].ToString("X2") +
                                loadedBytes[i + f + 3].ToString("X2");
                            int c = i + int.Parse(colorPointer, System.Globalization.NumberStyles.HexNumber);
                            colorAddresses.Add(c + offset);
                        }
                        catch { }
                    }
                }


                foreach (int a in colorAddresses)
                {
                    try
                    {
                        string color = loadedBytes[a].ToString("X2") + loadedBytes[a + 1].ToString("X2") + loadedBytes[a + 2].ToString("X2");
                        if (searchedPalette.ContainsKey(color))
                        {
                            searchedPalette[color].Add(a.ToString("X8"));
                        }
                        else
                        {
                            List<string> addressList = new List<string>();
                            addressList.Add(a.ToString("X8"));
                            searchedPalette.Add(color, addressList);
                        }
                    }
                    catch { }
                }

                if (modelPalettes.ContainsKey("Autodetected Colors"))
                {
                    modelPalettes["Autodetected Colors"] = searchedPalette;
                }
                else modelPalettes.Add("Autodetected Colors", searchedPalette);
            }
        }
        private void GetPalettes()
        {
            string KCLPath = Directory.GetCurrentDirectory() + "\\Palettes.txt";

            if (File.Exists(KCLPath))
            {
                StreamReader read = new StreamReader(KCLPath);
                string line = "";
                line = read.ReadLine();

                while (line != null)
                {
                    if (line.StartsWith("### "))
                    {
                        // Make New Model Palette
                        string paletteName = line.Substring(4);
                        paletteName = paletteName.Split(";", 2)[0];
                        Dictionary<string, List<string>> knownLocations = new Dictionary<string, List<string>>();

                        line = read.ReadLine();
                        while (line != null)
                        {
                            if (line.StartsWith("-- "))
                            {
                                // Add Section
                                string sectionName = line.Substring(3);
                                sectionName = sectionName.Split(";", 2)[0];
                                List<string> locations = new List<string>();
                                line = read.ReadLine();
                                while (!line.StartsWith("-- ") && !line.StartsWith("### ") && !String.IsNullOrEmpty(line.Replace(" ", "")))
                                {
                                    line = line.Split(";", 2)[0];
                                    locations.Add(line);
                                    line = read.ReadLine();
                                    if (line == null) break;
                                }
                                knownLocations.Add(sectionName, locations);
                            }
                            else line = read.ReadLine();

                            if (line == null) break;
                            if (String.IsNullOrEmpty(line.Replace(" ", ""))) break;
                        }
                        modelPalettes.Add(paletteName, knownLocations);
                    }
                    else line = read.ReadLine();
                }

                read.Close();
                read.Dispose();
            }
            palette.Items.AddRange(modelPalettes.Keys.ToArray());
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveModel();
        }
        private void SaveModel()
        {
            if (loadedBytes == null || loadedBytes.Length == 0 || !File.Exists(filePath)) return;

            BinaryWriter writer = new BinaryWriter(File.OpenWrite(filePath));
            writer.Write(loadedBytes);
            writer.Flush();
            writer.Close();
            writer.Dispose();
        }

        private void OverwriteColor(string colorHex, int[] locations)
        {
            if (loadedBytes == null || loadedBytes.Length == 0)
            {
                MessageBox.Show("No model is currently loaded!");
                return;
            }

            byte R = byte.Parse(colorHex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            byte G = byte.Parse(colorHex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            byte B = byte.Parse(colorHex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            foreach (int location in locations)
            {
                try
                {
                    loadedBytes[location] = R;
                    loadedBytes[location + 1] = G;
                    loadedBytes[location + 2] = B;

                    Console.WriteLine($"Wrote {colorHex} to Address: {location.ToString("X8")}");
                }
                catch
                {
                    Console.WriteLine($"Failed to write at Address: {location.ToString("X8")}");
                }
            }

            oldHex.Text = colorHex;
        }
        private void saveColor_Click(object sender, EventArgs e)
        {
            if (addressList.SelectedIndex == -1) return;
            int address = int.Parse(addressList.SelectedItem.ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber);
            int[] single = new int[1] { address };
            OverwriteColor(newHex.Text, single);
        }
        private void savePalette_Click(object sender, EventArgs e)
        {
            if (addressList.SelectedIndex == -1) return;
            List<int> addresses = new List<int>();
            foreach (string address in addressList.Items)
            {
                int newLocation = int.Parse(address.Substring(0, 8), System.Globalization.NumberStyles.HexNumber);
                addresses.Add(newLocation);
            }
            OverwriteColor(newHex.Text, addresses.ToArray());
        }
        private void palette_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change Loaded Palette
            if (palette.SelectedIndex == -1) return;
            colorSectionList.Items.Clear();
            addressList.Items.Clear();
            oldHex.Text = "";
            colorSectionList.Items.AddRange(modelPalettes[palette.SelectedItem.ToString()].Keys.ToArray());
            if (colorSectionList.Items.Count > 0) colorSectionList.SelectedIndex = 0;
        }
        private void colorSectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load Addresses
            if (palette.SelectedIndex == -1 || colorSectionList.SelectedIndex == -1) return;
            addressList.Items.Clear();
            addressList.Items.AddRange(modelPalettes[palette.SelectedItem.ToString()][colorSectionList.SelectedItem.ToString()].ToArray());
            if (addressList.Items.Count > 0) addressList.SelectedIndex = 0;
        }
        private void addressList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load Color At Address into OldHex
            oldHex.Text = "";
            string location = addressList.SelectedItem.ToString().Substring(0, 8);
            if (loadedBytes == null || loadedBytes.Length == 0 || addressList.SelectedIndex == -1) return;
            try
            {
                curAddress = int.Parse(location, System.Globalization.NumberStyles.HexNumber);
                byte R = loadedBytes[curAddress];
                byte G = loadedBytes[curAddress + 1];
                byte B = loadedBytes[curAddress + 2];
                oldHex.Text = $"{R.ToString("X2")}{G.ToString("X2")}{B.ToString("X2")}";
            }
            catch
            {
                MessageBox.Show($"Failed to find or parse location: '{location}' in the current model");
            }
        }
        private void newHex_TextChanged(object sender, EventArgs e)
        {
            // Load Color from NewHex Text
            try
            {
                newColBtn.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + newHex.Text);
            }
            catch
            {
                newColBtn.BackColor = Color.White;
            }
        }
        private void oldHex_TextChanged(object sender, EventArgs e)
        {
            // Load Color from OldHex Text
            try
            {
                oldColBtn.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + oldHex.Text);
            }
            catch
            {
                oldColBtn.BackColor = Color.White;
            }
        }

        private void newColBtn_Click(object sender, EventArgs e)
        {
            // Open Color Dialogue
            ColorDialog col = new ColorDialog();
            if (col.ShowDialog() == DialogResult.OK)
            {
                string R = col.Color.R.ToString("X2");
                string G = col.Color.G.ToString("X2");
                string B = col.Color.B.ToString("X2");
                newHex.Text = R + G + B;
            }
        }

        private void searchColor_Click(object sender, EventArgs e)
        {
            if (loadedBytes == null || loadedBytes.Length == 0 || !File.Exists(filePath)) return;

            if (String.IsNullOrEmpty(newHex.Text))
            {
                MessageBox.Show("Please enter a color into the New Color" +
                    Environment.NewLine + "box to search for addresses");
                return;
            }

            byte R = 0;
            byte G = 0;
            byte B = 0;
            try
            {
                R = byte.Parse(newHex.Text.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                G = byte.Parse(newHex.Text.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                B = byte.Parse(newHex.Text.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
            }
            catch
            {
                MessageBox.Show($"'{newHex.Text}' failed to parse as a color");
                return;
            }

            for (int i = 0; i < loadedBytes.Length - 2; i++)
            {
                byte aR = loadedBytes[i];
                byte aG = loadedBytes[i + 1];
                byte aB = loadedBytes[i + 2];

                if (aR == R && aG == G && aB == B)
                {
                    // Color Found
                    string address = i.ToString("X8");
                    bool alreadyExists = false;
                    foreach (string item in addressList.Items)
                    {
                        if (item.Substring(0, 8) == address)
                            alreadyExists = true;
                    }
                    if (alreadyExists) continue;

                    addressList.Items.Add(address + " - Searched Color");

                }
            }

            List<int> newAddresses = new List<int>();
        }

        private void addressOffset_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int offset = (int)addressOffset.Value;
                SearchColors(offset);
                palette.SelectedIndex = 0;
                palette_SelectedIndexChanged(sender, e);
            }
            catch { }
        }
    }
}

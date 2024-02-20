using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
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
        Palette loadedPallete;
        Dictionary<string, Palette> modelPalettes = new Dictionary<string, Palette>();
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
            paletteList.Items.Clear();
            modelPalettes.Clear();
            SearchColors();
            GetPalettes();
            paletteList.Items.AddRange(modelPalettes.Keys.ToArray());
            if (paletteList.Items.Count > 0) paletteList.SelectedIndex = 0;
        }
        private void SearchColors()
        {
            if (loadedBytes.Length > 0)
            {
                byte[] nxfLabel = new byte[4] { 0x4E, 0x58, 0x46, 0x00 };
                Palette searchedPalette = new Palette();
                List<ColorSet> section = new List<ColorSet>();
                int hitCount = 0;

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
                            hitCount++;
                            string floatPointer = loadedBytes[i + 36].ToString("X2") +
                                loadedBytes[i + 37].ToString("X2") +
                                loadedBytes[i + 38].ToString("X2") +
                                loadedBytes[i + 39].ToString("X2");
                            int f = int.Parse(floatPointer, System.Globalization.NumberStyles.HexNumber);
                            string colorLength = loadedBytes[i + f + 52].ToString("X2") +
                                loadedBytes[i + f + 53].ToString("X2") +
                                loadedBytes[i + f + 54].ToString("X2") +
                                loadedBytes[i + f + 55].ToString("X2");
                            int count = int.Parse(colorLength, System.Globalization.NumberStyles.HexNumber);
                            string colorPointer = loadedBytes[i + f + 80].ToString("X2") +
                                loadedBytes[i + f + 81].ToString("X2") +
                                loadedBytes[i + f + 82].ToString("X2") +
                                loadedBytes[i + f + 83].ToString("X2");
                            int c = i + int.Parse(colorPointer, System.Globalization.NumberStyles.HexNumber);

                            ColorSet newSet = new ColorSet();
                            newSet.source = c.ToString("X8");
                            newSet.count = count;
                            section.Add(newSet);
                            Console.WriteLine($"Found NFX Colors at {(c).ToString("X2")}, {count}");
                        }
                        catch { }
                    }
                }
                searchedPalette.sections.Add("Searched Colors", section);

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
                        Palette newPalette = new Palette();
                        newPalette.sections = new Dictionary<string, List<ColorSet>>();
                        line = read.ReadLine();
                        while (line != null)
                        {
                            if (line.StartsWith("-- "))
                            {
                                // Add Section
                                string sectionName = line.Substring(3);
                                sectionName = sectionName.Split(";", 2)[0];
                                List<ColorSet> locations = new List<ColorSet>();
                                line = read.ReadLine();
                                while (!line.StartsWith("-- ") && !line.StartsWith("### ") && !String.IsNullOrEmpty(line.Replace(" ", "")))
                                {
                                    ColorSet newSet = new ColorSet();
                                    line = line.Split(";", 2)[0];

                                    newSet.count = int.Parse(line.Substring(0, 4), System.Globalization.NumberStyles.HexNumber);
                                    newSet.source = line.Substring(5);
                                    locations.Add(newSet);
                                    line = read.ReadLine();
                                    if (line == null) break;
                                }
                                newPalette.sections.Add(sectionName, locations);
                            }
                            else line = read.ReadLine();

                            if (line == null) break;
                            if (String.IsNullOrEmpty(line.Replace(" ", ""))) break;
                        }
                        modelPalettes.Add(paletteName, newPalette);
                    }
                    else line = read.ReadLine();
                }

                read.Close();
                read.Dispose();
            }
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
            byte A = (byte)alphaValue.Value;

            foreach (int location in locations)
            {
                try
                {
                    loadedBytes[location] = R;
                    loadedBytes[location + 1] = G;
                    loadedBytes[location + 2] = B;
                    if (!alphaIgnore.Checked) loadedBytes[location + 3] = A;

                    Console.WriteLine($"Wrote {colorHex} to Address: {location.ToString("X8")}");
                }
                catch
                {
                    MessageBox.Show($"Failed to write at Address: {location.ToString("X8")}");
                }
            }
        }
        private void ReplaceColor_Click(object sender, EventArgs e)
        {
            // Try getting current set of colors
            if (!IsTextAColor(newHex.Text, true)) return;
            if (addressList.SelectedIndex == -1) return;
            ColorSet curSet = new ColorSet();
            int[] single = new int[0];
            try
            {
                curSet = loadedPallete.sections[colorSectionList.SelectedItem.ToString()][addressList.SelectedIndex];
            }
            catch { return; }

            // If you have a certain color selected, replace that, otherwise replace the first one.
            if (colorList.SelectedItems.Count > 0)
                single = new int[1] { curAddress + (colorList.SelectedIndices[0] * 4) };
            else
                single = new int[1] { curAddress };

            OverwriteColor(newHex.Text, single);
            RefreshColorList(curSet, curAddress);
        }
        private void ReplaceAll_Click(object sender, EventArgs e)
        {
            if (!IsTextAColor(newHex.Text, true)) return;
            if (addressList.SelectedIndex == -1) return;
            ColorSet curSet = loadedPallete.sections[colorSectionList.SelectedItem.ToString()][addressList.SelectedIndex];
            List<int> addresses = new List<int>();
            for (int i = 0; i < curSet.count; i++)
            {
                addresses.Add(curAddress + (i * 4));
            }
            OverwriteColor(newHex.Text, addresses.ToArray());
            RefreshColorList(curSet, addresses[0]);
        }
        private void palette_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change Loaded Palette
            if (paletteList.SelectedIndex == -1) return;
            colorSectionList.Items.Clear();
            addressList.Items.Clear();
            colorList.Items.Clear();
            loadedPallete = modelPalettes[paletteList.SelectedItem.ToString()];
            colorSectionList.Items.AddRange(loadedPallete.sections.Keys.ToArray());
            if (colorSectionList.Items.Count > 0) colorSectionList.SelectedIndex = 0;
        }
        private void colorSectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load Addresses
            if (paletteList.SelectedIndex == -1 || colorSectionList.SelectedIndex == -1) return;
            addressList.Items.Clear();
            colorList.Items.Clear();
            foreach (ColorSet set in loadedPallete.sections[colorSectionList.SelectedItem.ToString()])
            {
                addressList.Items.Add(set.source.ToString());
            }
            if (addressList.Items.Count > 0) addressList.SelectedIndex = 0;
        }
        private void addressList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load Color At Address into ColorList
            ColorSet curSet = new ColorSet();
            curAddress = AddressFromSource(addressList.SelectedItem.ToString());
            try
            {
                curSet = loadedPallete.sections[colorSectionList.SelectedItem.ToString()][addressList.SelectedIndex];
                RefreshColorList(curSet, curAddress);
            }
            catch
            {
                MessageBox.Show("Failed to load Color Set");
                return;
            }
        }
        private void colorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (paletteList.SelectedIndex == -1) return;
            //if (colorList.Items.Count == 0) return;
            //if (colorList.SelectedIndices.Count > 0)
            {
                //string location = addressList.SelectedItem.ToString().Substring(0, 8);
                //int address = int.Parse(location, System.Globalization.NumberStyles.HexNumber);
                //curAddress = address;
            }
        }
        private void newHex_TextChanged(object sender, EventArgs e)
        {
            // Load Color from NewHex Text
            Color parsedCol = Color.White;
            if (IsTextAColor(newHex.Text, false))
            {
                newColBtn.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + newHex.Text);
            }
            else newColBtn.BackColor = Color.White;
        }
        private bool IsTextAColor(string hex, bool returnMessage)
        {
            try
            {
                Color testCol = System.Drawing.ColorTranslator.FromHtml("#" + hex);
                return true;
            }
            catch
            {
                if (returnMessage)
                {
                    if (String.IsNullOrEmpty(hex))
                        MessageBox.Show("Please enter a color into the 'New Color' box.");
                    else
                        MessageBox.Show($"Failed to parse '{hex}' as a color.");
                }
                return false;
            }
        }

        private void newColBtn_Click(object sender, EventArgs e)
        {
            // Open Color Dialogue
            ColorDialog col = new ColorDialog();
            if (!String.IsNullOrEmpty(Properties.Settings.Default.CustomColorList))
            {
                col.CustomColors = LoadCustomColors();
            }
            if (col.ShowDialog() == DialogResult.OK)
            {
                SaveCustomColors(col.CustomColors);
                string R = col.Color.R.ToString("X2");
                string G = col.Color.G.ToString("X2");
                string B = col.Color.B.ToString("X2");
                newHex.Text = R + G + B;
            }
        }
        private void RefreshColorList(ColorSet set, int address)
        {
            colorList.Items.Clear();
            if (loadedBytes == null || loadedBytes.Length == 0 || addressList.SelectedIndex == -1) return;
            try
            {
                for (int i = 0; i < set.count; i++)
                {
                    int location = address + (i * 4);
                    colorList.Items.Add(ReadColor(location));
                }
            }
            catch
            {
                MessageBox.Show($"Failed to refresh colors at: '{address}' in the current model");
            }
        }
        class Palette
        {
            public Dictionary<string, List<ColorSet>> sections = new Dictionary<string, List<ColorSet>>();
        }
        struct ColorSet
        {
            public string source;
            public int count;
        }
        private int AddressFromSource(string source)
        {
            try
            {
                string location = source.Substring(0, 8);
                int address = int.Parse(location, System.Globalization.NumberStyles.HexNumber);
                return address;

            }
            catch
            {
                MessageBox.Show("Failed to read source: (" + source + ")");
                return 0;
            }
        }
        private int[] LoadCustomColors()
        {
            List<int> colorList = new List<int>();
            string[] colors = Properties.Settings.Default.CustomColorList.Split(":", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < colors.Length; i++)
            {
                colorList.Add(int.Parse(colors[i]));
            }
            return colorList.ToArray();
        }
        private void SaveCustomColors(int[] colors)
        {
            string colString = "";
            for (int i = 0; i < colors.Length; i++)
            {
                colString += colors[i].ToString() + ":";
            }
            Properties.Settings.Default.CustomColorList = colString;
            Properties.Settings.Default.Save();
        }
        private ListViewItem ReadColor(int address)
        {
            if (loadedBytes.Length == 0 || loadedBytes == null) return null;
            else
            {
                byte R = loadedBytes[address];
                byte G = loadedBytes[address + 1];
                byte B = loadedBytes[address + 2];
                byte A = loadedBytes[address + 3];
                string hex = $"{R.ToString("X2")}{G.ToString("X2")}{B.ToString("X2")}:{A.ToString("X2")}";
                Color col = Color.FromArgb(R, G, B);
                ListViewItem newSwatch = new ListViewItem();
                newSwatch.UseItemStyleForSubItems = false;
                newSwatch.Text = hex;
                newSwatch.SubItems.Add("    ");
                newSwatch.BackColor = colorList.BackColor;
                newSwatch.SubItems[1].BackColor = col;

                //float bright = col.GetBrightness();
                //if (bright > 0.5)
                //{
                //    newSwatch.ForeColor = Color.Black;
                //}
                //else newSwatch.ForeColor = Color.White;

                return newSwatch;
            }
        }

        private void alphaIgnore_CheckedChanged(object sender, EventArgs e)
        {
            alphaValue.Enabled = !alphaIgnore.Checked;
        }
    }
}

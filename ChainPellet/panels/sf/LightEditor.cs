using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ChainPellet.sf;

namespace ChainPellet.panels.sf
{
    public partial class LightEditor : UserControl
    {
        public MainForm main;
        public SceneNode loadedNode;
        public bool loading;
        public LightEditor(MainForm mainForm, SceneNode node)
        {
            InitializeComponent();
            loadedNode = node;
            main = mainForm;
        }
        private void LightEditor_Load(object sender, EventArgs e)
        {
            if (loading) return;
            loading = true;
            Light l = loadedNode.data.light;
            rBox.Text = l.r.ToString();
            gBox.Text = l.g.ToString();
            bBox.Text = l.b.ToString();
            colorBox.BackColor = ColorFromNodeRGB(l.r, l.g, l.b);
            loading = false;
        }
        public Color ColorFromNodeRGB(float r, float g, float b)
        {
            Color col = Color.White;
            try
            {
                if (r > 1) r = 1;
                else if (r < 0) r = 0;

                if (g > 1) g = 1;
                else if (g < 0) g = 0;

                if (b > 1) b = 1;
                else if (b < 0) b = 0;

                int ir = (int)(r * 255f);
                int ig = (int)(g * 255f);
                int ib = (int)(b * 255f);
                col = Color.FromArgb(ir, ig, ib);
            }
            catch { }
            return col;
        }

        private void colorBox_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog();
            if (!String.IsNullOrEmpty(Properties.Settings.Default.CustomColorList))
            {
                col.CustomColors = LoadCustomColors();
            }
            if (col.ShowDialog() == DialogResult.OK)
            {
                SaveCustomColors(col.CustomColors);
                loading = true;
                float R = (col.Color.R / 255f);
                float G = (col.Color.G / 255f);
                float B = (col.Color.B / 255f);
                rBox.Text = R.ToString();
                gBox.Text = G.ToString();
                bBox.Text = B.ToString();
                loading = false;
                colorBoxesChanged(sender, e);
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

        private void colorBoxesChanged(object sender, EventArgs e)
        {
            if (loading) return;
            loading = true;
            try
            {
                Light l = loadedNode.data.light;
                l.r = float.Parse(rBox.Text);
                l.g = float.Parse(gBox.Text);
                l.b = float.Parse(bBox.Text);
                loadedNode.data.light = l;
                main.OverwriteNode(loadedNode);
                colorBox.BackColor = ColorFromNodeRGB(l.r, l.g, l.b);
            }
            catch
            {
                colorBox.BackColor = ColorFromNodeRGB(1, 1, 1);
            }

            loading = false;
        }
    }
}

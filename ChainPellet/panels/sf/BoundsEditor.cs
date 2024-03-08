using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static ChainPellet.sf;

namespace ChainPellet.panels.sf
{
    public partial class BoundsEditor : UserControl
    {
        public MainForm main;
        public SceneNode loadedNode;
        public bool loading;

        public BoundsEditor(MainForm mainForm, SceneNode node)
        {
            InitializeComponent();
            loadedNode = node;
            main = mainForm;
        }

        private void BoundsEditor_Load(object sender, EventArgs e)
        {
            if (loading) return;
            loading = true;
            Bounds b = loadedNode.data.bounds;
            xMin.Text = b.min.X.ToString();
            yMin.Text = b.min.Y.ToString();
            zMin.Text = b.min.Z.ToString();
            wMin.Text = b.min.W.ToString();
            xMax.Text = b.max.X.ToString();
            yMax.Text = b.max.Y.ToString();
            zMax.Text = b.max.Z.ToString();
            wMax.Text = b.max.W.ToString();
            loading = false;
        }
        private void BoundDataEdited(object sender, EventArgs e)
        {
            if (loading) return;
            loading = true;
            try
            {
                Bounds b = new Bounds();
                b.min.X = float.Parse(xMin.Text);
                b.min.Y = float.Parse(yMin.Text);
                b.min.Z = float.Parse(zMin.Text);
                b.min.W = float.Parse(wMin.Text);
                b.max.X = float.Parse(xMax.Text);
                b.max.Y = float.Parse(yMax.Text);
                b.max.Z = float.Parse(zMax.Text);
                b.max.W = float.Parse(wMax.Text);
                loadedNode.data.bounds = b;
                main.OverwriteNode(loadedNode);
            }
            catch { }
            loading = false;
        }
    }
}

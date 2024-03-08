using System;
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
    public partial class CameraEditor : UserControl
    {
        public MainForm main;
        public SceneNode loadedNode;
        public bool loading;
        public CameraEditor(MainForm mainForm, SceneNode node)
        {
            InitializeComponent();
            loadedNode = node;
            main = mainForm;
        }

        private void CameraEditor_Load(object sender, EventArgs e)
        {
            loading = true;
            Camera cam = loadedNode.data.camera;
            try
            {
                xIn.Text = cam.interest.X.ToString();
                yIn.Text = cam.interest.Y.ToString();
                zIn.Text = cam.interest.Z.ToString();
                fovBox.Text = cam.field_of_view.ToString();
            }
            catch { }
            loading = false;
        }

        private void CameraDataChanged(object sender, EventArgs e)
        {
            if (loading) return;
            loading = true;
            try
            {
                Camera cam = loadedNode.data.camera;
                float X = float.Parse(xIn.Text);
                float Y = float.Parse(yIn.Text);
                float Z = float.Parse(zIn.Text);
                cam.interest = new Vector3(X, Z, Y);
                cam.field_of_view = float.Parse(fovBox.Text);
                loadedNode.data.camera = cam;
                main.OverwriteNode(loadedNode);
            }
            catch { }
            loading = false;
        }
    }
}

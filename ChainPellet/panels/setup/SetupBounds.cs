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
using static ChainPellet.MainForm;
using static ChainPellet.SFHandler;

namespace ChainPellet.panels.setup
{
    public partial class SetupBounds : UserControl
    {
        public MainForm parent;
        public SetupNode loadedNode;
        public bool loading = true;
        public SetupBounds(MainForm form, SetupNode node)
        {
            InitializeComponent();
            parent = form;
            loadedNode = node;
        }
        private void SetupBounds_Load(object sender, EventArgs e)
        {
            loading = true;
            xPos.Text = loadedNode.pos.X.ToString();
            yPos.Text = loadedNode.pos.Y.ToString();
            zPos.Text = loadedNode.pos.Z.ToString();
            xRot.Text = loadedNode.rot.X.ToString();
            yRot.Text = loadedNode.rot.Y.ToString();
            zRot.Text = loadedNode.rot.Z.ToString();
            xScale.Text = loadedNode.scale.X.ToString();
            yScale.Text = loadedNode.scale.Y.ToString();
            zScale.Text = loadedNode.scale.Z.ToString();

            string secondaryPointName = "Secondary Point";
            if (loadedNode.type == "Bounds") secondaryPointName = "Boundary Corner";
            if (loadedNode.secondaryPoints == null)
            {
                MessageBox.Show("ah bruh fr? Null-ass secondary points?");
                loading = false;
                return;
            }
            for (int i = 0; i < loadedNode.secondaryPoints.Length; i++)
            {
                secondaryPoints.Items.Add($"{secondaryPointName} {i + 1}");
            }

            if (secondaryPoints.Items.Count > 0) secondaryPoints.SelectedIndex = 0;
            loading = false;
        }
        private void OnSecondaryDataChanged(object sender, EventArgs e)
        {
            if (loading) return;
            try
            {
                float X = float.Parse(xPos2.Text);
                float Y = float.Parse(yPos2.Text);
                float Z = float.Parse(zPos2.Text);
                float W = float.Parse(weight.Text);
                loadedNode.secondaryPoints[secondaryPoints.SelectedIndex] = new Vector4(X, Y, Z, W);
                parent.OverwriteNode(loadedNode);
            }
            catch { }
        }
        private void OnNodeDataChanged(object sender, EventArgs e)
        {
            if (loading) return;
            try
            {
                float posX = float.Parse(xPos.Text);
                float posY = float.Parse(yPos.Text);
                float posZ = float.Parse(zPos.Text);
                loadedNode.pos = new Vector3(posX, posY, posZ);
                float rotX = float.Parse(xRot.Text);
                float rotY = float.Parse(yRot.Text);
                float rotZ = float.Parse(zRot.Text);
                loadedNode.rot = new Vector3(rotX, rotY, rotZ);
                float scaleX = float.Parse(xScale.Text);
                float scaleY = float.Parse(yScale.Text);
                float scaleZ = float.Parse(zScale.Text);
                loadedNode.scale = new Vector3(scaleX, scaleY, scaleZ);
                parent.OverwriteNode(loadedNode);
            }
            catch { }
        }

        private void secondaryPoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (secondaryPoints.SelectedIndex != -1)
            {
                try
                {
                    loading = true;
                    Vector4 point = loadedNode.secondaryPoints[secondaryPoints.SelectedIndex];
                    xPos2.Text = point.X.ToString();
                    yPos2.Text = point.Y.ToString();
                    zPos2.Text = point.Z.ToString();
                    weight.Text = point.W.ToString();
                    loading = false;
                }
                catch { }

            }
        }
    }
}

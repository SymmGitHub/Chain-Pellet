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
using static ChainPellet.MainForm;
using static ChainPellet.SFHandler;

namespace ChainPellet.panels.setup
{
    public partial class SetupNurbs : UserControl
    {
        public MainForm parent;
        public SetupNode loadedNode;
        public bool loading = true;
        public SetupNurbs(MainForm form, SetupNode node)
        {
            InitializeComponent();
            parent = form;
            loadedNode = node;
        }

        private void SetupNurbs_Load(object sender, EventArgs e)
        {
            xPos.Text = loadedNode.pos.X.ToString();
            yPos.Text = loadedNode.pos.Y.ToString();
            zPos.Text = loadedNode.pos.Z.ToString();
            xRot.Text = loadedNode.rot.X.ToString();
            yRot.Text = loadedNode.rot.Y.ToString();
            zRot.Text = loadedNode.rot.Z.ToString();
            xScale.Text = loadedNode.scale.X.ToString();
            yScale.Text = loadedNode.scale.Y.ToString();
            zScale.Text = loadedNode.scale.Z.ToString();

            Nurbs nurbs = loadedNode.nurbs;
            Unk1.Text = nurbs.unk1.ToString();
            Unk2.Text = nurbs.unk2.ToString();
            Unk3.Text = nurbs.unk3.ToString();
            Unk4.Text = nurbs.unk4.ToString();
            Unk5.Text = nurbs.unk5.ToString();

            // Add Nurbs
            for (int i = 0; i < loadedNode.nurbs.controlPoints.Count; i++)
            {
                secondaryPoints.Items.Add($"Control Point {i + 1}");
            }

            if (secondaryPoints.Items.Count > 0) secondaryPoints.SelectedIndex = 0;
            loading = false;
        }
        private void secondaryPoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (secondaryPoints.SelectedIndex != -1)
            {
                loading = true;
                try
                {
                    Nurbs n = loadedNode.nurbs;
                    Vector4 point = n.controlPoints[secondaryPoints.SelectedIndex];
                    xPos2.Text = point.X.ToString();
                    yPos2.Text = point.Y.ToString();
                    zPos2.Text = point.Z.ToString();
                    weight.Text = point.W.ToString();
                    knot.Text = n.knotVector[secondaryPoints.SelectedIndex].ToString();
                }
                catch { }
                loading = false;
            }
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
                float K = float.Parse(knot.Text);
                Vector4 point = new Vector4(X, Y, Z, W);
                Nurbs n = loadedNode.nurbs;
                n.controlPoints[secondaryPoints.SelectedIndex] = point;
                n.knotVector[secondaryPoints.SelectedIndex] = K;
                loadedNode.nurbs = n;
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
                Nurbs n = loadedNode.nurbs;
                n.unk1 = float.Parse(Unk1.Text);
                n.unk2 = int.Parse(Unk2.Text);
                n.unk3 = int.Parse(Unk3.Text);
                n.unk4 = int.Parse(Unk4.Text);
                n.unk5 = int.Parse(Unk5.Text);
                loadedNode.nurbs = n;
                parent.OverwriteNode(loadedNode);
            }
            catch { }
        }
    }
}

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
using ChainPellet;
using static ChainPellet.MainForm;
using static ChainPellet.SFHandler;

namespace ChainPellet.panels.setup
{
    public partial class SetupGeneric : UserControl
    {
        public MainForm parent;
        SetupNode loadedNode;
        public bool loading = true;
        public SetupGeneric(MainForm form, SetupNode node)
        {
            InitializeComponent();
            parent = form;
            loadedNode = node;
        }

        private void SetupGeneric_Load(object sender, EventArgs e)
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

            loading = false;
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
    }
}

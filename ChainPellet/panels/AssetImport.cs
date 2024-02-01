using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainPellet
{
    public partial class AssetImport : UserControl
    {
        public MainForm parent;
        public AssetImport(MainForm form)
        {
            InitializeComponent();
            parent = form;
        }

        private void AssetImport_Load(object sender, EventArgs e)
        {
            AssetHierarchy.Nodes.Clear();
            AssetHierarchy.Nodes.AddRange(parent.CreateDirectoryNodes(parent.objectsPath, false));

        }
        private void ImportBtn_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in AssetHierarchy.Nodes)
            {
                if (node.Checked) ImportNode(node);
            }
            parent.RefreshAssetTreeview();
        }
        private void ImportNode(TreeNode node)
        {
            node.Text = node.Text.Replace(" |X|", "");
            node.Checked = false;
            UpdateNodeColor(node);

            string nodePath = parent.objectsPath + "\\" + node.FullPath;
            nodePath = nodePath.Replace(" |X|", "");
            string destPath = parent.folderPath + "\\" + node.FullPath;

            if (Directory.Exists(nodePath))
            {
                if (!Directory.Exists(destPath)) Directory.CreateDirectory(destPath);
            }
            else if (File.Exists(nodePath))
            {
                File.Copy(nodePath, destPath, true);
            }
            else
            {
                MessageBox.Show("Failed to find a file/directory at: " + Environment.NewLine + nodePath);
            }

            foreach (TreeNode child in node.Nodes)
            {
                if (child.Checked) ImportNode(child);
            }
        }

        private void AssetHierarchy_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (ModifierKeys == Keys.Shift)
            {
                TreeNode node = e.Node;
                bool selected = !node.Checked;
                SelectNodeToggle(node, selected, true);
            }
            if (ModifierKeys == Keys.Control)
            {
                TreeNode node = e.Node;
                MessageBox.Show(parent.objectsPath + "\\" + node.FullPath);
            }
        }
        private void SelectNodeToggle(TreeNode node, bool selected, bool changeChildren)
        {
            // Remove Cross if one exists
            string nodePath = parent.objectsPath + "\\" + node.FullPath;
            nodePath = nodePath.Replace(" |X|", "");
            node.Text = node.Text.Replace(" |X|", "");

            // Check or Uncheck a node
            node.Checked = selected;
            if (selected) node.Text += " |X|";
            UpdateNodeColor(node);

            // Do the same for every child node recursively
            if (changeChildren)
            {
                foreach (TreeNode n in node.Nodes)
                {
                    SelectNodeToggle(n, selected, true);
                }
            }

            // Also do the same for parents recursively
            if (node.Parent != null) 
            {
                int checkedChildrenCount = 0;
                foreach (TreeNode n in node.Parent.Nodes)
                {
                    if (n.Checked) checkedChildrenCount++;
                }

                if (checkedChildrenCount == 0)
                    SelectNodeToggle(node.Parent, false, false);
                else
                    SelectNodeToggle(node.Parent, true, false);

            }
        }
        private void UpdateNodeColor(TreeNode node)
        {
            string nodePath = parent.objectsPath + "\\" + node.FullPath;
            nodePath = nodePath.Replace(" |X|", "");
            Color backCol = AssetHierarchy.BackColor;
            Color mainCol = Color.White;
            if (File.Exists(nodePath))
            {
                string ext = Path.GetExtension(nodePath);
                mainCol = parent.FileNodeColor(ext);
            }
            else if (Directory.Exists(nodePath))
            {
                mainCol = Color.Yellow;
            }

            if (node.Checked)
            {
                node.ForeColor = backCol;
                node.BackColor = mainCol;
            }
            else
            {
                node.ForeColor = mainCol;
                node.BackColor = backCol;
            }
        }
    }
}

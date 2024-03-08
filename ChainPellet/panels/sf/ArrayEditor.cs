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
using static ChainPellet.sf;

namespace ChainPellet.panels.sf
{
    public partial class ArrayEditor : UserControl
    {
        public MainForm main;
        public SceneNode loadedNode;
        public bool loading;
        public ArrayEditor(MainForm mainForm, SceneNode node)
        {
            InitializeComponent();
            loadedNode = node;
            main = mainForm;
        }

        private void ArrayEditor_Load(object sender, EventArgs e)
        {
            if (loading) return;
            loading = true;
            PointArray a = loadedNode.data.array;
            ListPoints(a);
            loading = false;
            if (arrayList.Items.Count > 0) arrayList.SelectedIndex = 0;
        }
        private void ListPoints(PointArray array)
        {
            arrayList.Items.Clear();
            for (int i = 0; i < array.points.Length; i++)
            {
                arrayList.Items.Add("Array Point " + (i + 1).ToString());
            }
        }

        private void arrayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            loading = true;
            try
            {
                Vector4 point = loadedNode.data.array.points[arrayList.SelectedIndex];
                xPos.Text = point.X.ToString();
                yPos.Text = point.Y.ToString();
                zPos.Text = point.Z.ToString();
                wPos.Text = point.W.ToString();
            }
            catch { }
            loading = false;
        }
        private void ArrayDataEdited(object sender, EventArgs e)
        {
            if (loading) return;
            loading = true;
            try
            {
                float X = float.Parse(xPos.Text);
                float Y = float.Parse(yPos.Text);
                float Z = float.Parse(zPos.Text);
                float W = float.Parse(wPos.Text);
                loadedNode.data.array.points[arrayList.SelectedIndex] = new Vector4(X, Y, Z, W);
                main.OverwriteNode(loadedNode);
            }
            catch { }
            loading = false;
        }

        private void addPointBtn_Click(object sender, EventArgs e)
        {
            int prevIndex = arrayList.SelectedIndex;
            loading = true;
            List<Vector4> pointList = loadedNode.data.array.points.ToList();
            pointList.Insert(arrayList.SelectedIndex + 1, new Vector4(0, 0, 0, 1));
            loadedNode.data.array.points = pointList.ToArray();
            main.OverwriteNode(loadedNode);
            ListPoints(loadedNode.data.array);
            loading = false;
            prevIndex++;
            if (prevIndex < arrayList.Items.Count) arrayList.SelectedIndex = prevIndex;
        }

        private void delPointBtn_Click(object sender, EventArgs e)
        {
            int prevIndex = arrayList.SelectedIndex;
            if (prevIndex < 0) return;
            loading = true;
            List<Vector4> pointList = loadedNode.data.array.points.ToList();
            pointList.RemoveAt(arrayList.SelectedIndex);
            loadedNode.data.array.points = pointList.ToArray();
            main.OverwriteNode(loadedNode);
            ListPoints(loadedNode.data.array);
            loading = false;
            if (prevIndex > 0) prevIndex--;
            if (prevIndex < arrayList.Items.Count) arrayList.SelectedIndex = prevIndex;
        }
    }
}

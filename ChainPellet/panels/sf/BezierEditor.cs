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
using System.Collections;
using static System.Formats.Asn1.AsnWriter;

namespace ChainPellet.panels.sf
{
    public partial class BezierEditor : UserControl
    {
        public MainForm main;
        public SceneNode loadedNode;
        public bool loading;
        public BezierEditor(MainForm mainForm, SceneNode node)
        {
            InitializeComponent();
            loadedNode = node;
            main = mainForm;
        }

        private void BezierEditor_Load(object sender, EventArgs e)
        {
            controlPointList.ContextMenuStrip = controlPointListContext;
            knotList.ContextMenuStrip = knotListContext;

            loading = true;
            Bezier b = loadedNode.data.bezier;
            lengthBox.Text = b.length.ToString();
            degreeBox.Text = b.degree.ToString();
            unkBox.Text = b.param_type.ToString();
            if (b.closed == 1) checkBox1.Checked = true;
            else checkBox1.Checked = false;

            ListControlPoints(b);
            ListKnots(b);
            loading = false;

            if (controlPointList.Items.Count > 0) controlPointList.SelectedIndex = 0;
            if (knotList.Items.Count > 0) knotList.SelectedIndex = 0;
        }
        private void ListControlPoints(Bezier bezier)
        {
            controlPointList.Items.Clear();
            for (int i = 0; i < bezier.control_points.Length; i++)
            {
                controlPointList.Items.Add("Point " + (i + 1).ToString());
            }
        }
        private void ListKnots(Bezier bezier)
        {
            knotList.Items.Clear();
            for (int i = 0; i < bezier.knots.Length; i++)
            {
                knotList.Items.Add(MathF.Round(bezier.knots[i]).ToString());
            }
        }
        private void controlPoint_TextChanged(object sender, EventArgs e)
        {
            // Overwrite Control Point Data
            if (loading || controlPointList.SelectedIndex == -1) return;
            loading = true;
            try
            {
                float X = float.Parse(xPos.Text);
                float Y = float.Parse(yPos.Text);
                float Z = float.Parse(zPos.Text);
                float W = float.Parse(wPos.Text);
                Vector4 newPoint = new Vector4(X, Y, Z, W);
                Vector4[] controlPoints = loadedNode.data.bezier.control_points;
                controlPoints[controlPointList.SelectedIndex] = newPoint;
                loadedNode.data.bezier.control_points = controlPoints;
                main.OverwriteNode(loadedNode);
            }
            catch { }
            loading = false;
        }
        private void knot_TextChanged(object sender, EventArgs e)
        {
            // Overwrite Knot Data
            if (loading || knotList.SelectedIndex == -1) return;
            loading = true;
            try
            {
                float newKnot = float.Parse(knotBox.Text);
                float[] knots = loadedNode.data.bezier.knots;
                knots[knotList.SelectedIndex] = newKnot;
                knotList.Items[knotList.SelectedIndex] = MathF.Round(newKnot).ToString();
                loadedNode.data.bezier.knots = knots;
                main.OverwriteNode(loadedNode);
            }
            catch { }
            loading = false;
        }
        private void controlPointList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display Control Point
            if (loading || controlPointList.SelectedIndex == -1) return;
            loading = true;
            try
            {
                Vector4 controlPoint = loadedNode.data.bezier.control_points[controlPointList.SelectedIndex];
                xPos.Text = controlPoint.X.ToString();
                yPos.Text = controlPoint.Y.ToString();
                zPos.Text = controlPoint.Z.ToString();
                wPos.Text = controlPoint.W.ToString();
            }
            catch { }
            loading = false;
        }

        private void knotList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display Knot
            if (loading || knotList.SelectedIndex == -1) return;
            loading = true;
            try
            {
                float knot = loadedNode.data.bezier.knots[knotList.SelectedIndex];
                knotBox.Text = knot.ToString();
            }
            catch { }
            loading = false;
        }

        private void BezierDataChanged(object sender, EventArgs e)
        {
            // Overwrite Bezier Data
            if (loading) return;
            loading = true;
            try
            {
                Bezier b = loadedNode.data.bezier;
                b.length = float.Parse(lengthBox.Text);
                b.degree = uint.Parse(degreeBox.Text);
                b.param_type = uint.Parse(unkBox.Text);

                if (checkBox1.Checked) b.closed = 1;
                else b.closed = 0;

                loadedNode.data.bezier = b;
                main.OverwriteNode(loadedNode);
            }
            catch { }
            loading = false;
        }

        private void addPointBtn_Click(object sender, EventArgs e)
        {
            // Add new Control Point
            int prevIndex = controlPointList.SelectedIndex;
            loading = true;
            List<Vector4> controlPoints = loadedNode.data.bezier.control_points.ToList();
            controlPoints.Insert(controlPointList.SelectedIndex + 1, new Vector4(0, 0, 0, 1));
            loadedNode.data.bezier.control_points = controlPoints.ToArray();
            main.OverwriteNode(loadedNode);
            ListControlPoints(loadedNode.data.bezier);
            loading = false;
            prevIndex++;
            if (prevIndex < controlPointList.Items.Count) controlPointList.SelectedIndex = prevIndex;
        }
        private void addKnotBtn_Click(object sender, EventArgs e)
        {
            // Add new Knot
            int prevIndex = knotList.SelectedIndex;
            loading = true;
            List<float> knots = loadedNode.data.bezier.knots.ToList();
            knots.Insert(knotList.SelectedIndex + 1, 0f);
            loadedNode.data.bezier.knots = knots.ToArray();
            main.OverwriteNode(loadedNode);
            ListKnots(loadedNode.data.bezier);
            loading = false;
            prevIndex++;
            if (prevIndex < knotList.Items.Count) knotList.SelectedIndex = prevIndex;
        }
        private void controlPointList_MouseDown(object sender, MouseEventArgs e)
        {
            controlPointList.SelectedIndex = controlPointList.IndexFromPoint(e.X, e.Y);
        }
        private void knotList_MouseDown(object sender, MouseEventArgs e)
        {
            knotList.SelectedIndex = knotList.IndexFromPoint(e.X, e.Y);
        }

        // ############################ CONTEXT STRIPS ############################

        private void duplicateControlPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Duplicate Control Point
            if (controlPointList.SelectedIndex == -1) return;
            int prevIndex = controlPointList.SelectedIndex;
            loading = true;
            List<Vector4> controlPoints = loadedNode.data.bezier.control_points.ToList();
            Vector4 point = loadedNode.data.bezier.control_points[prevIndex];
            controlPoints.Insert(prevIndex + 1, point);
            loadedNode.data.bezier.control_points = controlPoints.ToArray();
            main.OverwriteNode(loadedNode);
            ListControlPoints(loadedNode.data.bezier);
            loading = false;
            controlPointList.SelectedIndex = prevIndex + 1;
        }
        private void deleteControlPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Delete Control Point
            int prevIndex = controlPointList.SelectedIndex;
            if (prevIndex < 0) return;
            loading = true;
            List<Vector4> controlPoints = loadedNode.data.bezier.control_points.ToList();
            controlPoints.RemoveAt(prevIndex);
            loadedNode.data.bezier.control_points = controlPoints.ToArray();
            main.OverwriteNode(loadedNode);
            ListControlPoints(loadedNode.data.bezier);
            loading = false;
            if (prevIndex > 0) prevIndex--;
            if (prevIndex < controlPointList.Items.Count) controlPointList.SelectedIndex = prevIndex;
        }
        private void reversePointOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Reverse Control Points
            int prevIndex = controlPointList.SelectedIndex;
            loading = true;
            Array.Reverse(loadedNode.data.bezier.control_points);
            main.OverwriteNode(loadedNode);
            ListControlPoints(loadedNode.data.bezier);
            loading = false;
            controlPointList.SelectedIndex = prevIndex;
        }
        private void copyPointPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Copy Control Point Position
            Clipboard.SetText($"{xPos.Text},{yPos.Text},{zPos.Text}");
        }
        private void pastePointPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Paste Control Point Position
            string[] input = Clipboard.GetText().Split(",", StringSplitOptions.RemoveEmptyEntries);
            loading = true;
            try
            {
                // Check if these pass as floats BEFORE putting them into the boxes
                float newX = float.Parse(input[0]);
                float newY = float.Parse(input[1]);
                float newZ = float.Parse(input[2]);
                xPos.Text = newX.ToString();
                yPos.Text = newY.ToString();
                zPos.Text = newZ.ToString();
                loading = false;
                controlPoint_TextChanged(sender, e);
            }
            catch { }
            loading = false;
        }
        private void copyKnotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Copy Knot
            Clipboard.SetText($"{knotBox.Text}");
        }
        private void pasteKnotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Paste Knot
            loading = true;
            try
            {
                // Check if these pass as floats BEFORE putting them into the boxes
                float newK = float.Parse(Clipboard.GetText());
                knotBox.Text = newK.ToString();
                loading = false;
                knot_TextChanged(sender, e);
            }
            catch { }
            loading = false;
        }
        private void duplicateKnotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Duplicate Knot
            if (knotList.SelectedIndex == -1) return;
            int prevIndex = knotList.SelectedIndex;
            loading = true;
            List<float> knots = loadedNode.data.bezier.knots.ToList();
            float knot = loadedNode.data.bezier.knots[prevIndex];
            knots.Insert(prevIndex + 1, knot);
            loadedNode.data.bezier.knots = knots.ToArray();
            main.OverwriteNode(loadedNode);
            ListKnots(loadedNode.data.bezier);
            loading = false;
            knotList.SelectedIndex = prevIndex + 1;
        }
        private void deleteKnotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Delete Knot
            int prevIndex = knotList.SelectedIndex;
            if (prevIndex < 0) return;
            loading = true;
            List<float> knots = loadedNode.data.bezier.knots.ToList();
            knots.RemoveAt(prevIndex);
            loadedNode.data.bezier.knots = knots.ToArray();
            main.OverwriteNode(loadedNode);
            ListKnots(loadedNode.data.bezier);
            loading = false;
            if (prevIndex > 0) prevIndex--;
            if (prevIndex < knotList.Items.Count) knotList.SelectedIndex = prevIndex;
        }
    }
}

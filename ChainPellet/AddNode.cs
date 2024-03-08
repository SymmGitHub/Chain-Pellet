using System.Numerics;
using static ChainPellet.sf;

namespace ChainPellet
{
    public partial class AddNode : Form
    {
        public SceneNode loadedNode;
        public bool loading;
        public AddNode()
        {
            InitializeComponent();
        }

        private void AddNode_Load(object sender, EventArgs e)
        {
            string[] types = Enum.GetNames(typeof(SceneModelType));
            string[] subtypes = Enum.GetNames(typeof(SceneGeomFormat));
            typeBox.Items.AddRange(types);
            subtypeBox.Items.AddRange(subtypes);
            typeNum.Value = 0;
            subtypeNum.Value = 0;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SceneNode node = new SceneNode();
                node.model_name = modelName.Text;
                node.geom_name = geomName.Text;
                float X = float.Parse(xPos.Text);
                float Y = float.Parse(yPos.Text);
                float Z = float.Parse(zPos.Text);
                float W = float.Parse(wPos.Text);
                node.pos = new Vector4(X, Y, Z, W);
                X = float.Parse(xRot.Text);
                Y = float.Parse(yRot.Text);
                Z = float.Parse(zRot.Text);
                W = float.Parse(wRot.Text);
                node.rot = new Vector4(X, Y, Z, W);
                X = float.Parse(xScale.Text);
                Y = float.Parse(yScale.Text);
                Z = float.Parse(zScale.Text);
                W = float.Parse(wScale.Text);
                node.scale = new Vector4(X, Y, Z, W);
                uint newType = (uint)typeNum.Value;
                uint subType = (uint)subtypeNum.Value;

                NodeData nd_data = new NodeData();
                nd_data.type = (SceneModelType)newType;
                nd_data.subType = subType;
                nd_data.light = new Light();
                nd_data.array = new PointArray();
                nd_data.camera = new Camera();
                nd_data.bounds = new Bounds();
                nd_data.bezier = new Bezier();
                nd_data.unknown = new Unknown();
                nd_data.unknown.data = new byte[0];

                nd_data.array.points = new Vector4[0];
                nd_data.bezier.control_points = new Vector4[0];
                nd_data.bezier.knots = new float[0];
                node.data = nd_data;
                loadedNode = node;
                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Failed to parse information into a Node.");
            }
        }

        private void typeNum_ValueChanged(object sender, EventArgs e)
        {
            if (loading) return;
            loading = true;
            try
            {
                typeBox.SelectedItem = ((SceneModelType)typeNum.Value).ToString();
            }
            catch
            {
                typeBox.SelectedIndex = -1;
            }
            loading = false;
        }

        private void subtypeNum_ValueChanged(object sender, EventArgs e)
        {
            if (loading) return;
            loading = true;
            try
            {
                subtypeBox.SelectedItem = ((SceneGeomFormat)subtypeNum.Value).ToString();
            }
            catch
            {
                subtypeBox.SelectedIndex = -1;
            }
            loading = false;
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            loading = true;
            try
            {
                typeNum.Value = (int)Enum.Parse(typeof(SceneModelType), typeBox.SelectedItem.ToString());
            }
            catch { }
            loading = false;
        }

        private void subtypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            loading = true;
            try
            {
                subtypeNum.Value = (int)Enum.Parse(typeof(SceneGeomFormat), subtypeBox.SelectedItem.ToString());
            }
            catch { }
            loading = false;
        }
    }
}

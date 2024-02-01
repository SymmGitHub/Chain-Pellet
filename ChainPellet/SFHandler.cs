using System.Diagnostics;
using System.Numerics;
using System.Xml.Linq;
using static ChainPellet.MainForm;

namespace ChainPellet
{
    public class SFHandler
    {
        public byte[] setupData = new byte[0];
        public string levelInternalName;
        public Dictionary<string, SetupNode> levelNodes = new Dictionary<string, SetupNode>();
        public void ReadSetup(string path)
        {
            setupData = File.ReadAllBytes(path);
            levelNodes = new Dictionary<string, SetupNode>();
            int start = 12;
            levelInternalName = ReadName(start, out start);
            for (int i = start; i < setupData.Length - 4;)
            {
                int curHalf1 = int.Parse(BytesToString(i, out i, 4), System.Globalization.NumberStyles.HexNumber);
                int curHalf2 = int.Parse(BytesToString(i, out i, 4), System.Globalization.NumberStyles.HexNumber);
                string name = "";
                string type = "";

                if (curHalf2 == 0)
                {
                    // Object Type
                    type = "UnknownO|X|";
                    switch (curHalf1)
                    {
                        case 6:
                            type = "Point";
                            break;
                        case 9:
                            type = "Camera";
                            break;
                        case 13:
                            type = "Bounds";
                            break;
                        case 19:
                            type = "Array";
                            break;
                        case 22:
                            type = "Nurbs";
                            break;
                    }
                }
                else if (curHalf2 == 9)
                {
                    // Landscape Type
                    type = "UnknownL|X|";
                    switch (curHalf1)
                    {
                        case 0:
                            type = "Environment";
                            break;
                        case 1:
                            type = "Instance";
                            break;
                        case 4:
                            type = "Ground";
                            break;
                    }
                }
                else continue;

                if (type.Contains("|X|")) continue;
                Debug.WriteLine($"Reading new node with type: {type}");
                SetupNode newNode = ReadNode(type, i, out i, out name);
                Debug.WriteLine($"Read new node: {name}");
                if (!levelNodes.ContainsKey(name)) levelNodes.Add(name, newNode);
            }
        }
        public SetupNode ReadNode(string type, int i, out int indexOut, out string name)
        {
            SetupNode newNode = new SetupNode();
            List<Vector4> addendumPoints = new List<Vector4>();
            Nurbs newNurbs = new Nurbs();
            Camera c = new Camera();

            newNode.address = i;
            newNode.type = type;
            name = ReadName(i, out i);
            newNode.name = name;
            string name2 = ReadName(i, out i);
            newNode.name2 = name2;

            newNode.pos = BytesToVector3(i, out i);
            newNode.rot = BytesToVector3(i, out i);
            i += 8;
            newNode.scale = BytesToVector3(i, out i);
            i += 4;

            // Read Bytes until the end of this Node
            int endBytes = int.Parse(BytesToString(i, out i, 4), System.Globalization.NumberStyles.HexNumber);
            Debug.WriteLine($" --- Byte Length is equal to: {endBytes}");

            switch (type)
            {
                case "Bounds":
                    if (endBytes <= 0) break;
                    int boundCount = endBytes / 16;
                    for (int b = 0; b < boundCount; b++)
                    {
                        Vector4 v = BytesToVector4(i, out i);
                        Debug.WriteLine($"Writing secondary point {b}: {v.X}, {v.Y}, {v.Z}, {v.W}");
                        addendumPoints.Add(v);
                    }
                    break;
                case "Camera":
                    break;
                case "Array":
                    if (endBytes <= 0) break;
                    int pointCount = int.Parse(BytesToString(i, out i, 4), System.Globalization.NumberStyles.HexNumber);
                    for (int b = 0; b < pointCount; b++)
                    {
                        Vector4 v = BytesToVector4(i, out i);
                        Debug.WriteLine($"Writing secondary point {b}: {v.X}, {v.Y}, {v.Z}, {v.W}");
                        addendumPoints.Add(v);
                    }
                    break;
                case "Nurbs":
                    if (endBytes <= 0) break;
                    newNurbs.unk1 = BytesToFloat(i, out i);
                    newNurbs.unk2 = int.Parse(BytesToString(i, out i, 4), System.Globalization.NumberStyles.HexNumber);
                    newNurbs.unk3 = int.Parse(BytesToString(i, out i, 4), System.Globalization.NumberStyles.HexNumber);
                    newNurbs.unk4 = int.Parse(BytesToString(i, out i, 4), System.Globalization.NumberStyles.HexNumber);
                    newNurbs.unk5 = int.Parse(BytesToString(i, out i, 4), System.Globalization.NumberStyles.HexNumber);
                    int nurbCount = int.Parse(BytesToString(i, out i, 4), System.Globalization.NumberStyles.HexNumber);
                    i += 40;
                    newNurbs.controlPoints = new List<Vector4>();
                    newNurbs.knotVector = new List<float>();
                    for (int n = 0; n < nurbCount; n++)
                    {
                        Vector4 controlPoint = BytesToVector4(i, out i);
                        newNurbs.controlPoints.Add(controlPoint);
                    }
                    i += 16;
                    for (int n = 0; n < nurbCount; n++)
                    {
                        float knot = BytesToFloat(i, out i);
                        newNurbs.knotVector.Add(knot);
                    }
                    break;
            }
            newNode.secondaryPoints = addendumPoints.ToArray();
            newNode.nurbs = newNurbs;
            newNode.camera = c;
            indexOut = i;
            Debug.WriteLine($"Writing new {type} node at address: {newNode.address.ToString("X8")}, {name}");
            return newNode;
        }
        public void WriteSetup(string path)
        {
            foreach (SetupNode node in levelNodes.Values)
            {
                WriteNode(node);
            }
            File.WriteAllBytes(path, setupData);
        }
        public void WriteNode(SetupNode node)
        {
            int i = node.address + 64;
            WriteByteVector3(i, out i, node.pos);
            WriteByteVector3(i, out i, node.rot);
            i += 8;
            WriteByteVector3(i, out i, node.scale);
            i += 4;
            switch (node.type)
            {
                case "Array":
                    string arrayEndBytes = ((16 * node.secondaryPoints.Count()) + 4).ToString("X8");
                    WriteByteQuad(i, out i, arrayEndBytes);
                    string arrayPoints = node.secondaryPoints.Count().ToString("X8");
                    WriteByteQuad(i, out i, arrayPoints);
                    for (int p = 0; p < node.secondaryPoints.Count(); p++)
                    {
                        WriteByteVector4(i, out i, node.secondaryPoints[p]);
                    }
                    break;
                case "Bounds":
                    string boundEndBytes = (16 * node.secondaryPoints.Count()).ToString("X8");
                    WriteByteQuad(i, out i, boundEndBytes);
                    for (int p = 0; p < node.secondaryPoints.Count(); p++)
                    {
                        WriteByteVector4(i, out i, node.secondaryPoints[p]);
                    }
                    break;
                case "Nurbs":
                    Nurbs n = node.nurbs;
                    int nurbsEndBytes = ((n.controlPoints.Count * 16) + (n.knotVector.Count * 4) + 80);
                    WriteByteQuad(i, out i, nurbsEndBytes.ToString("X8"));
                    WriteByteQuad(i, out i, BitConverter.SingleToInt32Bits(n.unk1).ToString("X8"));
                    WriteByteQuad(i, out i, n.unk2.ToString("X8"));
                    WriteByteQuad(i, out i, n.unk3.ToString("X8"));
                    WriteByteQuad(i, out i, n.unk4.ToString("X8"));
                    WriteByteQuad(i, out i, n.unk5.ToString("X8"));
                    WriteByteQuad(i, out i, n.controlPoints.Count.ToString("X8"));
                    i += 40;

                    for (int p = 0; p < n.controlPoints.Count; p++)
                    {
                        WriteByteVector4(i, out i, n.controlPoints[p]);
                    }
                    i += 16;
                    for (int p = 0; p < n.knotVector.Count; p++)
                    {
                        WriteByteQuad(i, out i, BitConverter.SingleToInt32Bits(n.knotVector[p]).ToString("X8"));
                    }
                    break;
            }
        }
        private float BytesToFloat(int i, out int output)
        {
            byte[] quad = new byte[4] { setupData[i + 3], setupData[i + 2], setupData[i + 1], setupData[i] };
            output = i + 4;
            return BitConverter.ToSingle(quad, 0);
        }
        private Vector3 BytesToVector3(int i, out int output)
        {
            float X = BytesToFloat(i, out i);
            float Y = BytesToFloat(i, out i);
            float Z = BytesToFloat(i, out i);
            output = i;
            return new Vector3(X, Y, Z);
        }
        private Vector4 BytesToVector4(int i, out int output)
        {
            float X = BytesToFloat(i, out i);
            float Y = BytesToFloat(i, out i);
            float Z = BytesToFloat(i, out i);
            float W = BytesToFloat(i, out i);
            output = i;
            return new Vector4(X, Y, Z, W);
        }
        private string BytesToString(int i, out int output, int length)
        {
            string byteString = "";
            for (int a = i; a < i + length; a++)
            {
                byteString += setupData[a].ToString("X2");
            }
            output = i + length;
            return byteString;
        }
        private string ReadName(int i, out int output)
        {
            string name = "";
            for (int n = 0; n < 32; n++)
            {
                if (setupData[i] != 0x00)
                {
                    int value = Convert.ToInt32(setupData[i + n].ToString("X2"), 16);
                    name += Char.ConvertFromUtf32(value);
                }
            }
            output = i + 32;
            return name;
        }
        private void WriteByteVector3(int i, out int output, Vector3 v)
        {
            string hexX = BitConverter.SingleToInt32Bits(v.X).ToString("X8");
            string hexY = BitConverter.SingleToInt32Bits(v.Y).ToString("X8");
            string hexZ = BitConverter.SingleToInt32Bits(v.Z).ToString("X8");
            WriteByteQuad(i, out i, hexX);
            WriteByteQuad(i, out i, hexY);
            WriteByteQuad(i, out i, hexZ);
            output = i;
        }
        private void WriteByteVector4(int i, out int output, Vector4 v)
        {
            string hexX = BitConverter.SingleToInt32Bits(v.X).ToString("X8");
            string hexY = BitConverter.SingleToInt32Bits(v.Y).ToString("X8");
            string hexZ = BitConverter.SingleToInt32Bits(v.Z).ToString("X8");
            string hexW = BitConverter.SingleToInt32Bits(v.W).ToString("X8");
            WriteByteQuad(i, out i, hexX);
            WriteByteQuad(i, out i, hexY);
            WriteByteQuad(i, out i, hexZ);
            WriteByteQuad(i, out i, hexW);
            output = i;
        }
        private void WriteByteQuad(int i, out int output, string input)
        {
            setupData[i] = byte.Parse(input.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            setupData[i + 1] = byte.Parse(input.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            setupData[i + 2] = byte.Parse(input.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
            setupData[i + 3] = byte.Parse(input.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
            output = i + 4;
        }
        public struct SetupNode
        {
            public string name;
            public string name2;
            public string type;
            public Vector3 pos;
            public Vector3 rot;
            public Vector3 scale;
            public Vector4[] secondaryPoints;
            public int address;
            public Nurbs nurbs;
            public Camera camera;
        }
        public struct Nurbs
        {
            public float unk1;
            public int unk2;
            public int unk3;
            public int unk4;
            public int unk5;
            public List<Vector4> controlPoints;
            public List<float> knotVector;
        }
        public struct Camera
        {
            public Vector4[] camPoints;
            public int unk1;
            public Vector4 unk2;
        }
    }
}
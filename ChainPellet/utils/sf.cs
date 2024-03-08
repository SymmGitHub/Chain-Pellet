using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using ChainPellet.utils;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace ChainPellet
{
    public class sf
    {
        public uint header;
        public uint format;
        public float version;
        public string name;
        public float x_cut_size;
        public float z_cut_size;
        public float min_x;
        public float max_x;
        public float min_z;
        public float max_z;
        public List<SceneClump> clumps;
        public enum SceneModelType
        {
            Static = 0,
            StaticInst = 1,
            Animated = 2,
            AnimatedInst = 3,
            Ground = 4,
            GroundVu1 = 5,
            Point = 6,
            DirLight = 7,
            AmbLight = 8,
            Camera = 9,
            Path = 10,
            AnimWPath = 11,
            AnimWOPath = 12,
            BoundingBox = 13,
            Unknown_14 = 14,
            Unknown_15 = 15,
            Unknown_16 = 16,
            Unknown_17 = 17,
            WorldSprite = 18,
            PointArray = 19,
            Sky = 20,
            Unknown_21 = 21,
            Bezier = 22,
            Unknown_23 = 23,
            Unknown_22 = 24,
            ColCylinder = 25,
            CoverList = 26,
            CombatPath = 27,
        }
        public enum SceneGeomFormat
        {
            Unknown_0 = 0,
            Imf = 1,
            Hmf = 2,
            Hxf = 3,
            Hxf2 = 4,
            Unknown_5 = 5,
            Vu1 = 6,
            Vu1Paged = 7,
            Ixf = 8,
            Nxf = 9, 
        }
        public void ReadSF(string path, bool bigEndian, out bool switchedEndian)
        {
            switchedEndian = false;
            if (File.Exists(path))
            {
                using (var stream = File.Open(path, FileMode.Open))
                {
                    using (var read = new CustomBinaryReader(stream, bigEndian))
                    {
                        Debug.WriteLine("Reading Setup...");

                        header = read.ReadUInt32();
                        
                        if (header == 0x0000FFFF)
                        {
                            // Header is reversed, notify user to switch Endianness and try again.
                            read.Close();
                            read.Dispose();
                            

                            MessageBox.Show("Header was reversed, switching Endianness and retrying...");
                            bigEndian = !bigEndian;
                            switchedEndian = true;
                            ReadSF(path, bigEndian, out bool dummy);
                            return;
                        }

                        format = read.ReadUInt32();
                        version = read.ReadSingle();
                        name = Encoding.ASCII.GetString(read.ReadBytes(32)).TrimEnd('\0');
                        x_cut_size = read.ReadSingle();
                        z_cut_size = read.ReadSingle();
                        min_x = read.ReadSingle();
                        max_x = read.ReadSingle();
                        min_z = read.ReadSingle();
                        max_z = read.ReadSingle();

                        Debug.WriteLine($"Name: {name}");
                        Debug.WriteLine($"Header: {header.ToString("X8")}, Format: {format.ToString("X8")}, Version: {version}");
                        Debug.WriteLine($"XCut: {x_cut_size}, ZCut: {z_cut_size}");
                        Debug.WriteLine($"MIN: ({min_x}, {min_z}), MAX: ({max_x}, {max_z})");

                        ushort num_clumps = read.ReadUInt16();
                        ushort pad = read.ReadUInt16();
                        clumps = new List<SceneClump>();

                        Debug.WriteLine($"Scene Clump Count: {num_clumps}");
                        for (int i = 0; i < num_clumps; i++)
                        {
                            uint offset = read.ReadUInt32();
                            long save = read.BaseStream.Position;
                            read.BaseStream.Seek(offset, SeekOrigin.Begin);

                            Debug.WriteLine($"Reading Clump {i + 1} at position {read.BaseStream.Position.ToString("X8")}...");
                            Debug.WriteLine($"Offset: {offset.ToString("X8")}, Saved Position: {save.ToString("X8")}");

                            SceneClump clump = SceneClump.ReadClump(read, bigEndian);
                            clumps.Add(clump);
                            read.BaseStream.Seek(save, SeekOrigin.Begin);
                        }
                        read.Close();
                        read.Dispose();
                    }
                }
            }
        }
        public void WriteSF(string path, bool bigEndian)
        {
            using (var stream = File.OpenWrite(path))
            {
                using (var write = new CustomBinaryWriter(stream, bigEndian))
                {
                    Debug.WriteLine("Writing Setup...");
                    write.Write(header);
                    write.Write(format);
                    write.Write(version);
                    write.Write32String(name);
                    write.Write(x_cut_size);
                    write.Write(z_cut_size);
                    write.Write(min_x);
                    write.Write(max_x);
                    write.Write(min_z);
                    write.Write(max_z);

                    write.Write((ushort)clumps.Count);
                    write.Write((ushort)0x0);

                    // Write empty space where pointers to clumps go
                    // so they can be overwritten later.
                    int clumpStart = (int)write.BaseStream.Position;
                    for (int i = 0; i < clumps.Count; i++)
                    {
                        write.Write(0);
                    }

                    for (int c = 0; c < clumps.Count; c++)
                    {
                        Debug.WriteLine($"Writing Clump Data...");
                        
                        int returnPos = (int)write.BaseStream.Position;
                        write.BaseStream.Seek(clumpStart + (c * 4), SeekOrigin.Begin);
                        write.Write(returnPos);
                        write.BaseStream.Seek(returnPos, SeekOrigin.Begin);

                        write.Write((ushort)clumps[c].nodes.Count);
                        write.Write((ushort)0x0);

                        write.Write(clumps[c].min_x);
                        write.Write(clumps[c].max_x);
                        write.Write(clumps[c].min_z);
                        write.Write(clumps[c].max_z);

                        for (int i = 0; i < clumps[c].nodes.Count; i++)
                        {
                            // Write Node
                            SceneNode node = clumps[c].nodes[i];
                            WriteNode(write, node);
                        }
                    }

                    // Write FF bytes until the file has bytes in a multiple of 16
                    while ((int)write.BaseStream.Position % 16 != 0) write.Write((byte)0xFF);

                    write.Close();
                    write.Dispose();
                }
            }
        }
        public bool ClumpValuesAreDivisible(float xSize, float zSize, float xCut, float zCut)
        {
            float xRemainder = (xSize % xCut);
            if (xRemainder != 0) return false;
            float zRemainder = (zSize % zCut);
            if (zRemainder != 0) return false;
            return true;
        }
        public void RegenerateClumps()
        {
            // This will take all the Nodes and sort them into newly regenerated clumps based on cut size;
            Debug.WriteLine("Regenerating Clumps...");

            // First check to see if the size and cuts are perfectly divisible, otherwise cancel.
            

            int xCuts = (int)((max_x - min_x) / x_cut_size);
            int zCuts = (int)((max_z - min_z) / z_cut_size);

            // Generate new list of clumps.
            List<SceneClump> newClumps = new List<SceneClump>();
            for (int z = 0; z < zCuts; z++)
            {
                for (int x = 0; x < xCuts; x++)
                {
                    SceneClump clump = new SceneClump();
                    clump.nodes = new List<SceneNode>();
                    clump.min_x = min_x + (x * x_cut_size);
                    clump.min_z = min_z + (z * z_cut_size);
                    clump.max_x = clump.min_x + x_cut_size;
                    clump.max_z = clump.min_z + z_cut_size;
                    newClumps.Add(clump);
                }
            }
            Debug.WriteLine($"Cut Counts: ({xCuts}, {zCuts}). Total Clump Count: {newClumps.Count}");

            // Take all the nodes currently loaded and add them to a temporary list
            List<SceneNode> floatingNodes = new List<SceneNode>();
            foreach (SceneClump clump in clumps)
            {
                foreach (SceneNode node in clump.nodes)
                {
                    floatingNodes.Add(node);
                }
            }

            // Assign nodes to clumps that contain is position
            for (int i = 0; i < floatingNodes.Count; i++)
            {
                Debug.WriteLine($"Assigning Node: {floatingNodes[i].model_name}...");
                Vector4 pos = PossibleNodePosition(floatingNodes[i]);
                Debug.WriteLine($"X: {pos.X}, Z: {pos.Z}");
                int X = 0;
                int Z = 0;
                while (pos.X > (min_x + (X * x_cut_size)))
                {
                    X++;
                }
                while (pos.Z > (min_z + (Z * z_cut_size)))
                {
                    Z++;
                }
                Debug.WriteLine($"X: {X}, Z: {Z}");

                if (X >= xCuts) X = xCuts - 1;
                if (Z >= zCuts) Z = zCuts - 1;

                Debug.WriteLine($"Assigning to Clump[{(Z * xCuts) + X}]");
                newClumps[(Z * xCuts) + X].nodes.Add(floatingNodes[i]);
            }
            clumps = newClumps;
        }
        public int ClumpIDFromGlobalIndex(int globalIndex, out int nodeIndex)
        {
            // Instead of having you sift through each individual clump for the nodes you're looking for,
            // this function just gets the clump from a combined list of all clump node indexes.

            // It'll also return the exact index of the node the global index matches up with,
            // letting you also get the node from this function.

            nodeIndex = 0;
            int curIndex = 0;
            for (int c = 0; c < clumps.Count; c++)
            {
                for (int n = 0; n < clumps[c].nodes.Count; n++)
                {
                    if (curIndex == globalIndex) 
                    {
                        nodeIndex = n;
                        return c;
                    }
                    curIndex++;
                }
            }
            return 0;
        }
        public struct Light
        {
            public float r;
            public float g;
            public float b;
        }

        public struct Camera
        {
            public Vector3 interest;
            public float field_of_view;
        }

         public struct Bounds
        {
            public Vector4 min;
            public Vector4 max;
        }
        public struct PointArray
        {
            public Vector4[] points;
        }
        public struct Bezier
        {
            public float length;
            public uint degree;
            public uint closed;
            public uint param_type;
            public uint[] pad;
            public Vector4[] control_points;
            public float[] knots;
        }
        public struct Unknown
        {
            public byte[] data;
        }
        public struct SceneClump
        {
            public float min_x;
            public float max_x;
            public float min_z;
            public float max_z;
            public List<SceneNode> nodes;

            public static SceneClump ReadClump(BinaryReader read, bool bigEndian)
            {
                Debug.WriteLine($"Reading Clump Data...");
                SceneClump clump = new SceneClump();
                ushort num_placements = read.ReadUInt16();
                ushort pad = read.ReadUInt16();
                clump.min_x = read.ReadSingle();
                clump.max_x = read.ReadSingle();
                clump.min_z = read.ReadSingle();
                clump.max_z = read.ReadSingle();
                clump.nodes = new List<SceneNode>();
                Debug.WriteLine($"MIN: ({clump.min_x}, {clump.min_z}), MAX: ({clump.max_x}, {clump.max_z})");
                Debug.WriteLine($"Node Count in this Clump: {num_placements}");

                for (int i = 0; i < num_placements; i++)
                {
                    SceneNode node = SceneNode.ReadNode(read, bigEndian);
                    clump.nodes.Add(node);
                    Debug.WriteLine($"Successfully Added Node!");
                }
                return clump;
            }
        }
        public struct SceneNode
        {
            public string model_name;
            public string geom_name;
            public Vector4 pos;
            public Vector4 rot;
            public Vector4 scale;
            public NodeData data;

            public static SceneNode ReadNode(BinaryReader read, bool bigEndian)
            {
                SceneNode node = new SceneNode();
                uint mainType = read.ReadUInt32();
                uint subType = read.ReadUInt32();
                node.model_name = Encoding.ASCII.GetString(read.ReadBytes(32));
                node.geom_name = Encoding.ASCII.GetString(read.ReadBytes(32));

                Debug.WriteLine("Model Name: " + node.model_name + " --- ");
                Debug.WriteLine("Geometry Name: " + node.geom_name + " --- ");

                float X = read.ReadSingle();
                float Y = read.ReadSingle();
                float Z = read.ReadSingle();
                float W = read.ReadSingle();
                node.pos = new Vector4(X, Y, Z, W);
                Debug.WriteLine($"Position: ({X}, {Y}, {Z}, {W})");
                X = read.ReadSingle();
                Y = read.ReadSingle();
                Z = read.ReadSingle();
                W = read.ReadSingle();
                node.rot = new Vector4(X, Y, Z, W);
                Debug.WriteLine($"Rotation: ({X}, {Y}, {Z}, {W})");
                X = read.ReadSingle();
                Y = read.ReadSingle();
                Z = read.ReadSingle();
                W = read.ReadSingle();
                node.scale = new Vector4(X, Y, Z, W);
                Debug.WriteLine($"Scale: ({X}, {Y}, {Z}, {W})");
                uint data_len = read.ReadUInt32();
                byte[] data = read.ReadBytes((int)data_len);
                Debug.WriteLine($"Addendum Data Length: {data_len}");
                node.data = NodeData.ReadNodeData(mainType, subType, data, bigEndian);
                return node;
            }
        }
        public struct NodeData
        {
            public SceneModelType type;
            public uint subType;
            public PointArray array;
            public Light light;
            public Camera camera;
            public Bounds bounds;
            public Bezier bezier;
            public Unknown unknown;
            public static NodeData ReadNodeData(uint mainType, uint subType, byte[] data, bool bigEndian)
            {
                NodeData nd_data = new NodeData();
                nd_data.type = (SceneModelType)mainType;
                Debug.WriteLine($"Reading Placement Data with type: '{nd_data.type.ToString()}'...)");
                nd_data.subType = subType;
                nd_data.light = new Light();
                nd_data.array = new PointArray();
                nd_data.camera = new Camera();
                nd_data.bounds = new Bounds();
                nd_data.bezier = new Bezier();
                nd_data.bezier.pad = new uint[10];
                nd_data.unknown = new Unknown();
                nd_data.unknown.data = new byte[0];

                nd_data.array.points = new Vector4[0];
                nd_data.bezier.control_points = new Vector4[0];
                nd_data.bezier.knots = new float[0];

                switch (mainType)
                {
                    case 7:
                        // Directional Light
                        nd_data.light.r = BytesToFloat(data, 0, bigEndian);
                        nd_data.light.g = BytesToFloat(data, 4, bigEndian);
                        nd_data.light.b = BytesToFloat(data, 8, bigEndian);
                        break;
                    case 8:
                        // Ambient Light
                        nd_data.light.r = BytesToFloat(data, 0, bigEndian);
                        nd_data.light.g = BytesToFloat(data, 4, bigEndian);
                        nd_data.light.b = BytesToFloat(data, 8, bigEndian);
                        break;
                    case 9:
                        // Camera
                        float inX = BytesToFloat(data, 0, bigEndian);
                        float inY = BytesToFloat(data, 4, bigEndian);
                        float inZ = BytesToFloat(data, 8, bigEndian);
                        nd_data.camera.interest = new Vector3(inX, inY, inZ);
                        nd_data.camera.field_of_view = BytesToFloat(data, 12, bigEndian);
                        break;
                    case 13:
                        // Boundary Box
                        nd_data.bounds.min = new Vector4(
                            BytesToFloat(data, 0, bigEndian),
                            BytesToFloat(data, 4, bigEndian),
                            BytesToFloat(data, 8, bigEndian),
                            BytesToFloat(data, 12, bigEndian)
                        );
                        nd_data.bounds.max = new Vector4(
                            BytesToFloat(data, 16, bigEndian),
                            BytesToFloat(data, 20, bigEndian),
                            BytesToFloat(data, 24, bigEndian),
                            BytesToFloat(data, 28, bigEndian)
                        );
                        break;
                    case 19:
                        // Point Array
                        uint count = BytesToUInt32(data, 0, bigEndian);
                        nd_data.array.points = new Vector4[count];
                        for (int i = 0; i < count; i++)
                        {
                            float X = BytesToFloat(data, (i * 16) + 4, bigEndian);
                            float Y = BytesToFloat(data, (i * 16) + 8, bigEndian);
                            float Z = BytesToFloat(data, (i * 16) + 12, bigEndian);
                            float W = BytesToFloat(data, (i * 16) + 16, bigEndian);
                            nd_data.array.points[i] = new Vector4(X, Y, Z, W);
                        }
                        break;
                    case 22:
                        // Bezier Curve
                        Debug.WriteLine($"Reading Bezier Data...");
                        nd_data.bezier.length = BytesToFloat(data, 0, bigEndian);
                        nd_data.bezier.degree = BytesToUInt32(data, 4, bigEndian);
                        nd_data.bezier.closed = BytesToUInt32(data, 8, bigEndian);
                        nd_data.bezier.param_type = BytesToUInt32(data, 12, bigEndian);
                        uint nb_knots = BytesToUInt32(data, 16, bigEndian);
                        uint nb_control_points = BytesToUInt32(data, 20, bigEndian);

                        int bytePos = 24;
                        for (int i = 0; i < 10; i++)
                        {
                            nd_data.bezier.pad[i] = BytesToUInt32(data, bytePos, bigEndian);
                            bytePos += 4;
                        }
                        nd_data.bezier.control_points = new Vector4[nb_control_points];
                        for (int i = 0; i < nb_control_points; i++ )
                        {
                            float X = BytesToFloat(data, bytePos, bigEndian);
                            float Y = BytesToFloat(data, bytePos + 4, bigEndian);
                            float Z = BytesToFloat(data, bytePos + 8, bigEndian);
                            float W = BytesToFloat(data, bytePos + 12, bigEndian);
                            nd_data.bezier.control_points[i] = new Vector4(X, Y, Z, W);
                            bytePos += 16;
                        }
                        nd_data.bezier.knots = new float[nb_knots];
                        for (int i = 0; i < nb_knots; i++)
                        {
                            nd_data.bezier.knots[i] = BytesToFloat(data, bytePos, bigEndian);
                            bytePos += 4;
                        }
                        break;
                    case 25:
                        // Boundary Cylinder
                        nd_data.bounds.min = new Vector4(
                            BytesToFloat(data, 0, bigEndian),
                            BytesToFloat(data, 4, bigEndian),
                            BytesToFloat(data, 8, bigEndian),
                            BytesToFloat(data, 12, bigEndian)
                        );
                        nd_data.bounds.max = new Vector4(
                            BytesToFloat(data, 16, bigEndian),
                            BytesToFloat(data, 20, bigEndian),
                            BytesToFloat(data, 24, bigEndian),
                            BytesToFloat(data, 28, bigEndian)
                        );
                        break;
                    default:
                        // Unknown
                        Array.Copy(data, nd_data.unknown.data, data.Length);
                        break;
                }
                return nd_data;
            }
            public static NodeData Copy(NodeData inData)
            {
                NodeData outData = new NodeData();
                outData.type = inData.type;
                outData.subType = inData.subType;

                outData.light = inData.light;
                outData.camera = inData.camera;
                outData.bounds = inData.bounds;

                outData.bezier = new Bezier();
                outData.bezier.length = inData.bezier.length;
                outData.bezier.degree = inData.bezier.degree;
                outData.bezier.closed = inData.bezier.closed;
                outData.bezier.param_type = inData.bezier.param_type;
                outData.bezier.pad = new uint[inData.bezier.pad.Length];
                outData.bezier.control_points = new Vector4[inData.bezier.control_points.Length];
                outData.bezier.knots = new float[inData.bezier.knots.Length];

                outData.array = new PointArray();
                outData.array.points = new Vector4[inData.array.points.Length];

                outData.unknown = new Unknown();
                outData.unknown.data = new byte[inData.unknown.data.Length];

                Array.Copy(inData.bezier.pad, outData.bezier.pad, inData.bezier.pad.Length);
                Array.Copy(inData.bezier.control_points, outData.bezier.control_points, inData.bezier.control_points.Length);
                Array.Copy(inData.bezier.knots, outData.bezier.knots, inData.bezier.knots.Length);
                Array.Copy(inData.array.points, outData.array.points, inData.array.points.Length);
                Array.Copy(inData.unknown.data, outData.unknown.data, inData.unknown.data.Length);
                return outData;
            }
        }
        public void WriteNode(CustomBinaryWriter write, SceneNode node)
        {
            write.Write(Convert.ToInt32(node.data.type));
            write.Write(node.data.subType);
            write.Write32String(node.model_name);
            write.Write32String(node.geom_name);
            write.Write(node.pos.X);
            write.Write(node.pos.Y);
            write.Write(node.pos.Z);
            write.Write(node.pos.W);
            write.Write(node.rot.X);
            write.Write(node.rot.Y);
            write.Write(node.rot.Z);
            write.Write(node.rot.W);
            write.Write(node.scale.X);
            write.Write(node.scale.Y);
            write.Write(node.scale.Z);
            write.Write(node.scale.W);

            // Write Node Data
            NodeData nd_data = node.data;
            int byteCountStart = (int)write.BaseStream.Position;
            write.Write(0);
            switch (Convert.ToInt32(nd_data.type))
            {
                case 7:
                    // Directional Light
                    write.Write(nd_data.light.r);
                    write.Write(nd_data.light.g);
                    write.Write(nd_data.light.b);
                    break;
                case 8:
                    // Ambient Light
                    write.Write(nd_data.light.r);
                    write.Write(nd_data.light.g);
                    write.Write(nd_data.light.b);
                    break;
                case 9:
                    // Camera
                    write.Write(nd_data.camera.interest.X);
                    write.Write(nd_data.camera.interest.Y);
                    write.Write(nd_data.camera.interest.Z);
                    write.Write(nd_data.camera.field_of_view);
                    break;
                case 13:
                    // Bounding Box
                    write.Write(nd_data.bounds.min.X);
                    write.Write(nd_data.bounds.min.Y);
                    write.Write(nd_data.bounds.min.Z);
                    write.Write(nd_data.bounds.min.W);
                    write.Write(nd_data.bounds.max.X);
                    write.Write(nd_data.bounds.max.Y);
                    write.Write(nd_data.bounds.max.Z);
                    write.Write(nd_data.bounds.max.W);
                    break;
                case 19:
                    // Point Array
                    write.Write(nd_data.array.points.Length);
                    for (int i = 0; i < nd_data.array.points.Length; i++)
                    {
                        write.Write(nd_data.array.points[i].X);
                        write.Write(nd_data.array.points[i].Y);
                        write.Write(nd_data.array.points[i].Z);
                        write.Write(nd_data.array.points[i].W);
                    }
                    break;
                case 22:
                    // Bezier
                    write.Write(nd_data.bezier.length);
                    write.Write(nd_data.bezier.degree);
                    write.Write(nd_data.bezier.closed);
                    write.Write(nd_data.bezier.param_type);
                    write.Write(nd_data.bezier.knots.Length);
                    write.Write(nd_data.bezier.control_points.Length);
                    for (int i = 0; i < nd_data.bezier.pad.Length; i++)
                    {
                        write.Write(nd_data.bezier.pad[i]);
                    }
                    for (int i = 0; i < nd_data.bezier.control_points.Length; i++)
                    {
                        write.Write(nd_data.bezier.control_points[i].X);
                        write.Write(nd_data.bezier.control_points[i].Y);
                        write.Write(nd_data.bezier.control_points[i].Z);
                        write.Write(nd_data.bezier.control_points[i].W);
                    }
                    for (int i = 0; i < nd_data.bezier.knots.Length; i++)
                    {
                        write.Write(nd_data.bezier.knots[i]);
                    }
                    break;
                case 25:
                    // Bounding Cylinder
                    write.Write(nd_data.bounds.min.X);
                    write.Write(nd_data.bounds.min.Y);
                    write.Write(nd_data.bounds.min.Z);
                    write.Write(nd_data.bounds.min.W);
                    write.Write(nd_data.bounds.max.X);
                    write.Write(nd_data.bounds.max.Y);
                    write.Write(nd_data.bounds.max.Z);
                    write.Write(nd_data.bounds.max.W);
                    break;
                default:
                    // Unknown
                    if (nd_data.unknown.data.Length > 0) write.Write(nd_data.unknown.data);
                    break;
            }
            int returnPoint = (int)write.BaseStream.Position;
            write.Seek(byteCountStart, SeekOrigin.Begin);
            write.Write(returnPoint - (byteCountStart + 4));
            write.Seek(returnPoint, SeekOrigin.Begin);
        }
        static uint BytesToUInt32(byte[] data, int startIndex, bool bigEndian)
        {
            // Custom uint returning function because BitConverter is only Little Endian.
            byte[] newArray = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                newArray[i] = data[startIndex + i];
            }
            if (bigEndian) newArray = newArray.Reverse().ToArray();
            return BitConverter.ToUInt32(newArray, 0);
        }
        static float BytesToFloat(byte[] data, int startIndex, bool bigEndian)
        {
            byte[] newArray = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                newArray[i] = data[startIndex + i];
            }
            if (bigEndian) newArray = newArray.Reverse().ToArray();
            return BitConverter.ToSingle(newArray, 0);
        }
        static Vector4 PossibleNodePosition(SceneNode node)
        {
            Vector4 pos = node.pos;
            if (pos == Vector4.Zero)
            {
                // If the position is zero, this will check other possible positions and set it to those instead
                if (node.data.array.points.Length != 0)
                {
                    pos = node.data.array.points[0];
                }
                else if (node.data.bounds.min != Vector4.Zero)
                {
                    pos = node.data.bounds.min;
                }
                else if (node.data.bezier.control_points.Length != 0)
                {
                    pos = node.data.bezier.control_points[0];
                }
            }
            return pos;
        }
    }
}

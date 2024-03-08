//using ChainPellet.panels.setup;
using ChainPellet.panels.sf;
using ChainPellet.utils;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static ChainPellet.sf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChainPellet
{
    public partial class MainForm : Form
    {
        public bool loading = true;
        public string filePath;
        public string folderPath;
        public string objectsPath;
        public string scriptPath;
        public string assetPath;
        public string sfPath;
        public bool scriptOverwriteAvailable = false;
        public sf scene;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load Settings
            AssetHierarchy.ContextMenuStrip = assetHierarchyContext;
            nodeList.ContextMenuStrip = nodeListContext;

            objectsPath = Properties.Settings.Default.ObjectsPath;
            assetFilterBox.Text = Properties.Settings.Default.prevAssetFilter;
            folderPath = Properties.Settings.Default.ExtractPath;
            if (String.IsNullOrEmpty(folderPath)) folderPath = Directory.GetCurrentDirectory() + "\\ArchiveData";

            autoSaveScriptsToolStripMenuItem.Checked = Properties.Settings.Default.ScriptAutoSave;
            hideTXTFilesToolStripMenuItem.Checked = Properties.Settings.Default.HideTXT;
            hideHXFFilesToolStripMenuItem.Checked = Properties.Settings.Default.HideHXF;
            hideNXFFilesToolStripMenuItem.Checked = Properties.Settings.Default.HideNXF;
            hideAMFFilesToolStripMenuItem.Checked = Properties.Settings.Default.HideAMF;
            hideSFFilesToolStripMenuItem.Checked = Properties.Settings.Default.HideSF;
            hideTPLFilesToolStripMenuItem.Checked = Properties.Settings.Default.HideTPL;
            hideCCCFilesToolStripMenuItem.Checked = Properties.Settings.Default.HideCCC;
            regenerateClumpsOnSaveToolStripMenuItem.Checked = Properties.Settings.Default.RegenClumps;
            UpdateEndianness();

            scene = new sf();
            scene.clumps = new List<SceneClump>();
            string[] types = Enum.GetNames(typeof(SceneModelType));
            typeBox.Items.AddRange(types);

            LoadLevelData();
            UpdateClumpRegenStatus();
            loading = false;
        }
        private void LoadLevelData()
        {
            AssetHierarchy.Nodes.Clear();
            nodeList.Items.Clear();
            MainPanel.Controls.Clear();
            NodeDataPanel.Controls.Clear();
            if (Directory.Exists(folderPath))
            {
                AssetHierarchy.Nodes.AddRange(CreateDirectoryNodes(folderPath, false));
                foreach (TreeNode node in AssetHierarchy.Nodes)
                {
                    if (node.FullPath == "script.txt")
                    {
                        ScriptEditor editor = new ScriptEditor();
                        editor.scriptPath = folderPath + "\\" + node.FullPath;
                        MainPanel.Controls.Clear();
                        MainPanel.Controls.Add(editor);
                    }
                    else if (node.FullPath == "level.sf")
                    {
                        ReadSceneData(folderPath + "\\" + node.FullPath);
                    }
                }
                AssetHierarchy.Nodes.Clear();
                AssetHierarchy.Nodes.AddRange(CreateDirectoryNodes(folderPath, true));
            }

            MainPanel_Resize(this, new EventArgs());
            NodeDataPanel_Resize(this, new EventArgs());
        }

        // ###############################################################################################################
        // ######_______________________________________TOOLSTRIP_AND_PANELS________________________________________######
        // ###############################################################################################################

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open a Pac-Man World 2 Archive File";
            open.Filter = "PMW2 RAR File (*.rar)|*.rar|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                filePath = open.FileName;
                folderPath = Properties.Settings.Default.ExtractPath;
                if (String.IsNullOrEmpty(folderPath)) folderPath = Directory.GetCurrentDirectory() + "\\ArchiveData";

                // Create extraction directory
                if (Directory.Exists(folderPath))
                {
                    Directory.Delete(folderPath, true);
                }
                Directory.CreateDirectory(folderPath);
                Process extract = new Process();
                extract.StartInfo = extractRAR(filePath, folderPath);
                extract.Start();
                extract.WaitForExit();
                extract.Dispose();
                LoadLevelData();
            }
        }
        private void openDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog open = new FolderBrowserDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                folderPath = open.SelectedPath;
                LoadLevelData();
            }
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loading = true;
            LoadLevelData();
            loading = false;
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(folderPath)) return;
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save a Pac-Man World 2 Archive File";
            save.Filter = "PMW2 RAR File (*.rar)|*.rar|All files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                filePath = save.FileName;
                if (File.Exists(sfPath)) SaveScene_Click(sender, e);
                BuildLevel(folderPath);
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(folderPath)) return;
            if (string.IsNullOrEmpty(filePath))
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else 
            {
                if (File.Exists(sfPath)) SaveScene_Click(sender, e);
                BuildLevel(folderPath);
            }
        }
        private void BuildLevel(string folderPath)
        {
            if (File.Exists(filePath)) File.Delete(filePath);
            Process build = new Process();
            build.StartInfo = buildRAR(filePath, folderPath);
            build.Start();
            build.WaitForExit();
            build.Dispose();
        }
        private void extractPMW2RarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Extract a Pac-Man World 2 RAR File into a folder";
            open.Filter = "PMW2 RAR File (*.rar)|*.rar|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string path = open.FileName;
                int extLength = Path.GetExtension(path).Length;
                string destFolder = path.Substring(0, path.Length - extLength);
                if (!Directory.Exists(destFolder)) Directory.CreateDirectory(destFolder);

                Process extract = new Process();
                extract.StartInfo = extractRAR(path, destFolder);
                extract.Start();
                extract.WaitForExit();
                extract.Dispose();
            }
        }

        private void createPMW2RarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog open = new FolderBrowserDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Process build = new Process();
                build.StartInfo = buildRAR(open.SelectedPath + ".rar", open.SelectedPath);
                build.Start();
                build.WaitForExit();
                build.Dispose();
            }
        }
        private void editInternalStringsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Edit hard-coded strings in PMW2";
            open.Filter = "GCN File (*.dol)|*.dol|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                DolEditor editor = new DolEditor(File.ReadAllBytes(open.FileName));
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(open.FileName, editor.dolData);
                }
            }
        }
        private void autoSaveScriptsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (loading) return;
            Properties.Settings.Default.ScriptAutoSave = autoSaveScriptsToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
        }
        private void regenerateClumpsOnSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loading) return;
            Properties.Settings.Default.RegenClumps = regenerateClumpsOnSaveToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
            UpdateClumpRegenStatus();
        }
        public void UpdateClumpRegenStatus()
        {
            // Disable or Enable making changes to the Level X and Z values
            bool crs = Properties.Settings.Default.RegenClumps;
            levelXMin.Text = scene.min_x.ToString();
            levelXMin.Enabled = crs;
            levelZMin.Text = scene.min_z.ToString();
            levelZMin.Enabled = crs;
            levelXMax.Text = scene.max_x.ToString();
            levelXMax.Enabled = crs;
            levelZMax.Text = scene.max_z.ToString();
            levelZMax.Enabled = crs;
            levelXCut.Text = scene.x_cut_size.ToString();
            levelXCut.Enabled = crs;
            levelZCut.Text = scene.z_cut_size.ToString();
            levelZCut.Enabled = crs;
        }

        public void UpdateEndianness()
        {
            bool usingBigEndianness = Properties.Settings.Default.useBigEndian;
            useBigEndianToolStripMenuItem.Checked = usingBigEndianness;
            useBigEndianToolStripMenuItem.Enabled = !usingBigEndianness;
            useLittleEndianToolStripMenuItem.Checked = !usingBigEndianness;
            useLittleEndianToolStripMenuItem.Enabled = usingBigEndianness;
        }
        public void ReverseEndianness(object sender, EventArgs e)
        {
            if (loading) return;
            loading = true;
            Properties.Settings.Default.useBigEndian = !Properties.Settings.Default.useBigEndian;
            Properties.Settings.Default.Save();
            UpdateEndianness();
            loading = false;
        }

        private void setObjectsFolderPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetObjectFolderPath();
        }

        private void SetObjectFolderPath()
        {
            MessageBox.Show("Please select the directory of a Pac-Man World 2" + Environment.NewLine +
                "'objects' Folder. It will allow you to easily copy" + Environment.NewLine +
                "assets from it into individual level RARs." + Environment.NewLine +
                Environment.NewLine +
                "Typically found in { DATA > netdata > objects }"
                );

            FolderBrowserDialog open = new FolderBrowserDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                objectsPath = open.SelectedPath;
                Properties.Settings.Default.ObjectsPath = objectsPath;
                Properties.Settings.Default.Save();
            }
        }
        private void setExtractionPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog open = new FolderBrowserDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ExtractPath = open.SelectedPath + "\\ArchiveData";
                folderPath = open.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }
        private void MainPanel_Resize(object sender, EventArgs e)
        {
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Size = MainPanel.Size;
            }
        }
        private void NodeDataPanel_Resize(object sender, EventArgs e)
        {
            if (NodeDataPanel.Controls.Count > 0)
            {
                NodeDataPanel.Controls[0].Size = NodeDataPanel.Size;
            }
        }

        // ###############################################################################################################
        // ######____________________________________ASSET_HIERARCHY_HANDLING_______________________________________######
        // ###############################################################################################################

        private void AssetHierarchy_MouseDown(object sender, MouseEventArgs e)
        {
            AssetHierarchy.SelectedNode = AssetHierarchy.GetNodeAt(e.X, e.Y);
        }
        private void AssetHierarchy_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;
            string fullPath = folderPath + "\\" + e.Node.FullPath;
            if (!File.Exists(fullPath) && !Directory.Exists(fullPath))
            {
                MessageBox.Show("No File/Directory Found at: " + fullPath);
                return;
            }
            else if (fullPath.EndsWith(".txt"))
            {
                ScriptEditor editor = new ScriptEditor();
                editor.scriptPath = fullPath;
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(editor);
            }
            else if (fullPath.EndsWith(".hxf") || fullPath.EndsWith(".nxf"))
            {
                ModelEditor editor = new ModelEditor();
                editor.filePath = fullPath;
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(editor);
            }
            else if (fullPath.EndsWith(".sf"))
            {
                ReadSceneData(fullPath);
            }
            MainPanel_Resize(sender, e);
        }
        public void RefreshAssetTreeview()
        {
            AssetHierarchy.Nodes.Clear();
            if (Directory.Exists(folderPath)) AssetHierarchy.Nodes.AddRange(CreateDirectoryNodes(folderPath, true));
        }
        private void updateHierarchyVisibility(object sender, EventArgs e)
        {
            if (loading) return;
            RefreshAssetTreeview();

            Properties.Settings.Default.HideTXT = hideTXTFilesToolStripMenuItem.Checked;
            Properties.Settings.Default.HideHXF = hideHXFFilesToolStripMenuItem.Checked;
            Properties.Settings.Default.HideNXF = hideNXFFilesToolStripMenuItem.Checked;
            Properties.Settings.Default.HideAMF = hideAMFFilesToolStripMenuItem.Checked;
            Properties.Settings.Default.HideTPL = hideTPLFilesToolStripMenuItem.Checked;
            Properties.Settings.Default.HideSF = hideSFFilesToolStripMenuItem.Checked;
            Properties.Settings.Default.HideCCC = hideCCCFilesToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
        }
        public TreeNode[] CreateDirectoryNodes(string path, bool hideEnabled)
        {
            List<TreeNode> newNodes = new List<TreeNode>();
            foreach (string directory in Directory.GetDirectories(path))
            {
                TreeNode node = new TreeNode(directory);
                DirectoryInfo dir = new DirectoryInfo(directory);
                node.Tag = directory;
                node.Text = dir.Name;
                node.ForeColor = Color.Yellow;
                node.Nodes.AddRange(CreateDirectoryNodes(directory, hideEnabled));
                newNodes.Add(node);
            }
            foreach (string file in Directory.GetFiles(path))
            {
                string ext = Path.GetExtension(file);
                if (hideEnabled)
                {
                    if (ext == ".txt" && hideTXTFilesToolStripMenuItem.Checked) continue;
                    else if (ext == ".hxf" && hideHXFFilesToolStripMenuItem.Checked) continue;
                    else if (ext == ".nxf" && hideNXFFilesToolStripMenuItem.Checked) continue;
                    else if (ext == ".amf" && hideAMFFilesToolStripMenuItem.Checked) continue;
                    else if (ext == ".tpl" && hideTPLFilesToolStripMenuItem.Checked) continue;
                    else if (ext == ".sf" && hideSFFilesToolStripMenuItem.Checked) continue;
                    else if (ext == ".ccc" && hideCCCFilesToolStripMenuItem.Checked) continue;

                    if (assetFilterBox.Text.Replace(" ", "").Length > 0)
                    {
                        // Check if node's name passes through filters
                        string[] filters = assetFilterBox.Text.Split("|");
                        bool failedFilter = false;
                        foreach (string filter in filters)
                        {
                            if (filter.StartsWith("!"))
                            {
                                if (Path.GetFileName(file).Contains(filter.Substring(1))) failedFilter = true;
                            }
                            else
                            {
                                if (!Path.GetFileName(file).Contains(filter)) failedFilter = true;
                            }
                        }
                        if (failedFilter) continue;
                    }
                }
                TreeNode node = new TreeNode(file);
                node.Tag = file;
                node.Text = Path.GetFileName(file);
                node.ForeColor = FileNodeColor(Path.GetExtension(file));
                newNodes.Add(node);
            }
            return newNodes.ToArray();
        }
        private void assetFilterBox_TextChanged(object sender, EventArgs e)
        {
            if (!loading)
            {
                Properties.Settings.Default.prevAssetFilter = assetFilterBox.Text;
                Properties.Settings.Default.Save();
                RefreshAssetTreeview();
            }
        }
        private void addAsset_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(objectsPath) || String.IsNullOrEmpty(objectsPath))
            {
                SetObjectFolderPath();
            }
            if (!Directory.Exists(objectsPath)) return;
            AssetImport editor = new AssetImport(this);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(editor);
        }
        private void deleteAssetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Delete Asset
            if (AssetHierarchy.Nodes.Count > 0)
            {
                if (AssetHierarchy.SelectedNode != null)
                {
                    if (File.Exists(folderPath + "\\" + AssetHierarchy.SelectedNode.FullPath))
                    {
                        File.Delete(folderPath + "\\" + AssetHierarchy.SelectedNode.FullPath);
                    }
                    else if (Directory.Exists(folderPath + "\\" + AssetHierarchy.SelectedNode.FullPath))
                    {
                        Directory.Delete(folderPath + "\\" + AssetHierarchy.SelectedNode.FullPath, true);
                    }
                    AssetHierarchy.Nodes.Remove(AssetHierarchy.SelectedNode);
                }
            }
        }
        private void AssetHierarchy_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            openAssetToolStripMenuItem_Click(sender, new EventArgs());
        }
        private void openAssetLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open File's Directory
            if (!Directory.Exists(folderPath)) return;
            string filePath = folderPath + "\\" + AssetHierarchy.SelectedNode.FullPath;
            filePath = Path.GetDirectoryName(filePath);
            var process = new Process();
            try
            {
                process.StartInfo = new ProcessStartInfo()
                {
                    UseShellExecute = true,
                    FileName = filePath
                };
                process.Start();
            }
            catch { }
            process.Dispose();
        }
        private void openAssetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open File using default program
            if (!Directory.Exists(folderPath)) return;
            string filePath = folderPath + "\\" + AssetHierarchy.SelectedNode.FullPath;
            var process = new Process();
            try
            {
                process.StartInfo = new ProcessStartInfo()
                {
                    UseShellExecute = true,
                    FileName = filePath
                };
                process.Start();
            }
            catch { }
            process.Dispose();
        }
        private void AssetHierarchy_DragDrop(object sender, DragEventArgs e)
        {
            //MessageBox.Show(e.Data.ToString());
        }

        // ###############################################################################################################
        // ######_______________________________________SETUP_FILE_HANDLING_________________________________________######
        // ###############################################################################################################
        private void ReadSceneData(string path)
        {
            sfPath = path;
            scene = new sf();
            scene.clumps = new List<SceneClump>();
            scene.ReadSF(path, Properties.Settings.Default.useBigEndian, out bool switchedEndian);
            if (switchedEndian)
            {
                ReverseEndianness(this, new EventArgs());
            }
            levelName.Text = scene.name;
            levelVersion.Text = scene.version.ToString();
            levelXCut.Text = scene.x_cut_size.ToString();
            levelZCut.Text = scene.z_cut_size.ToString();
            levelXMin.Text = scene.min_x.ToString();
            levelZMin.Text = scene.min_z.ToString();
            levelXMax.Text = scene.max_x.ToString();
            levelZMax.Text = scene.max_z.ToString();
            ListSceneNodes();
        }
        private void ListSceneNodes()
        {
            nodeList.Items.Clear();
            if (scene.clumps.Count == 0) return;

            for (int c = 0; c < scene.clumps.Count; c++)
            {
                for (int n = 0; n < scene.clumps[c].nodes.Count; n++)
                {
                    nodeList.Items.Add(scene.clumps[c].nodes[n].model_name);
                }
            }
        }
        private void SaveScene_Click(object sender, EventArgs e)
        {
            if (scene.clumps.Count == 0) return;
            if (!File.Exists(sfPath))
            {
                SaveSceneAs_Click(sender, e);
            }
            else
            {
                OverwiteSceneLevelData();
                if (regenerateClumpsOnSaveToolStripMenuItem.Checked) scene.RegenerateClumps();
                scene.WriteSF(sfPath, Properties.Settings.Default.useBigEndian);
                if (regenerateClumpsOnSaveToolStripMenuItem.Checked) ListSceneNodes();
            }

        }
        private void SaveSceneAs_Click(object sender, EventArgs e)
        {
            if (scene.clumps.Count == 0) return;
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save a Pac-Man World 2 Scene File";
            save.Filter = "PMW2 Scene File (*.sf)|*.sf|All files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                OverwiteSceneLevelData();
                if (regenerateClumpsOnSaveToolStripMenuItem.Checked) scene.RegenerateClumps();
                scene.WriteSF(save.FileName, Properties.Settings.Default.useBigEndian);
                if (regenerateClumpsOnSaveToolStripMenuItem.Checked) ListSceneNodes();
            }
        }
        private void nodeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading || nodeList.SelectedIndex == -1) return;

            loading = true;
            int nodeIndex;
            int clumpIndex = scene.ClumpIDFromGlobalIndex(nodeList.SelectedIndex, out nodeIndex);
            SceneNode curNode = scene.clumps[clumpIndex].nodes[nodeIndex];

            // Update Generic Data
            modelName.Text = curNode.model_name;
            geomName.Text = curNode.geom_name;
            try { typeBox.SelectedItem = curNode.data.type.ToString(); }
            catch { typeBox.SelectedIndex = -1; }
            subTypeNum.Value = curNode.data.subType;

            xPos.Text = curNode.pos.X.ToString();
            yPos.Text = curNode.pos.Y.ToString();
            zPos.Text = curNode.pos.Z.ToString();
            wPos.Text = curNode.pos.W.ToString();
            xRot.Text = curNode.rot.X.ToString();
            yRot.Text = curNode.rot.Y.ToString();
            zRot.Text = curNode.rot.Z.ToString();
            wRot.Text = curNode.rot.W.ToString();
            xScale.Text = curNode.scale.X.ToString();
            yScale.Text = curNode.scale.Y.ToString();
            zScale.Text = curNode.scale.Z.ToString();
            wScale.Text = curNode.scale.W.ToString();
            UpdateSpecialNodeTab(sender, e);
            loading = false;
        }
        private void UpdateSpecialNodeTab(object sender, EventArgs e)
        {
            int nodeIndex;
            int clumpIndex = scene.ClumpIDFromGlobalIndex(nodeList.SelectedIndex, out nodeIndex);
            SceneNode curNode = scene.clumps[clumpIndex].nodes[nodeIndex];

            string category = "";
            switch (curNode.data.type)
            {
                case SceneModelType.Bezier:
                    category = "Bezier";
                    break;
                case SceneModelType.BoundingBox:
                    category = "Bounds";
                    break;
                case SceneModelType.ColCylinder:
                    category = "Bounds";
                    break;
                case SceneModelType.PointArray:
                    category = "Array";
                    break;
                case SceneModelType.DirLight:
                    category = "Light";
                    break;
                case SceneModelType.AmbLight:
                    category = "Light";
                    break;
            }

            NodeDataPanel.Controls.Clear();
            Control editor = new EmptyEditor();
            switch (category)
            {
                case "Bounds":
                    editor = new BoundsEditor(this, curNode);
                    break;
                case "Array":
                    editor = new ArrayEditor(this, curNode);
                    break;
                case "Light":
                    editor = new LightEditor(this, curNode);
                    break;
                case "Bezier":
                    editor = new BezierEditor(this, curNode);
                    break;
            }
            if (editor != null) NodeDataPanel.Controls.Add(editor);
            NodeDataPanel_Resize(sender, e);
        }
        private void nodeFilterBox_TextChanged(object sender, EventArgs e)
        {
            //type.Text = objs.BossList.FirstOrDefault(x => x.Value == objDropDown.Text).Key.ToString();

            for (int i = 0; i < nodeList.Items.Count; i++)
            {
                if (nodeList.Items[i].ToString().Contains(nodeFilterBox.Text))
                {
                    nodeList.SelectedIndex = i;
                    break;
                }
            }
        }
        private void addNodeBtn_Click(object sender, EventArgs e)
        {
            if (scene.clumps.Count == 0) return;
            AddNode editor = new AddNode();
            if (editor.ShowDialog() == DialogResult.OK)
            {
                scene.clumps[scene.clumps.Count - 1].nodes.Add(editor.loadedNode);
                ListSceneNodes();
                nodeList.SelectedIndex = nodeList.Items.Count - 1;
            }
        }
        private void nodeList_MouseDown(object sender, MouseEventArgs e)
        {
            nodeList.SelectedIndex = nodeList.IndexFromPoint(e.X, e.Y);
        }

        private void duplicateNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nodeList.SelectedIndex == -1) return;
            int nodeIndex;
            int clumpIndex = scene.ClumpIDFromGlobalIndex(nodeList.SelectedIndex, out nodeIndex);

            // Clone Node inside Scene
            SceneNode clonedNode = scene.clumps[clumpIndex].nodes[nodeIndex];
            clonedNode.data = NodeData.Copy(clonedNode.data);
            scene.clumps[clumpIndex].nodes.Insert(nodeIndex + 1, clonedNode);

            // Clone Node inside Node List
            string cloneName = nodeList.SelectedItem.ToString();
            nodeList.Items.Insert(nodeList.SelectedIndex + 1, cloneName);

            nodeList.SelectedIndex++;
        }
        private void deleteNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nodeList.SelectedIndex == -1) return;
            int sel = nodeList.SelectedIndex;
            int nodeIndex;
            int clumpIndex = scene.ClumpIDFromGlobalIndex(sel, out nodeIndex);
            scene.clumps[clumpIndex].nodes.RemoveAt(nodeIndex);
            nodeList.Items.RemoveAt(sel);
            if (nodeList.Items.Count > 0)
            {
                if (sel > nodeList.Items.Count - 1) sel = nodeList.Items.Count - 1;
                nodeList.SelectedIndex = sel;
            }
        }
        private void copyNodePositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText($"{xPos.Text},{yPos.Text},{zPos.Text}");
        }
        private void pasteNodePositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                OverwriteNodeGenericData(sender, e);
            }
            catch { }
            loading = false;
        }
        private void importNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Import one or more Pac-Man World 2 Scene Node";
            open.Multiselect = true;
            open.Filter = "PMW2 Scene Node (*.dat)|*.dat|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in open.FileNames)
                {
                    using (var stream = File.OpenRead(file))
                    {
                        using (var read = new CustomBinaryReader(stream, true))
                        {
                            try
                            {
                                SceneNode node = SceneNode.ReadNode(read, true);
                                scene.clumps[scene.clumps.Count - 1].nodes.Add(node);

                            }
                            catch { }
                            read.Close();
                            read.Dispose();
                        }
                    }
                }
                ListSceneNodes();
                nodeList.SelectedIndex = nodeList.Items.Count - 1;
            }
        }
        private void exportNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int nodeIndex;
            int clumpIndex = scene.ClumpIDFromGlobalIndex(nodeList.SelectedIndex, out nodeIndex);
            SceneNode node = scene.clumps[clumpIndex].nodes[nodeIndex];

            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Export a Pac-Man World 2 Scene Node";
            save.FileName = $"{node.model_name}.dat";
            save.Filter = "PMW2 Scene Node (*.dat)|*.dat|All files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (var stream = File.OpenWrite(save.FileName))
                {
                    using (var write = new CustomBinaryWriter(stream, true))
                    {
                        try { scene.WriteNode(write, node); } catch { }
                        write.Close();
                        write.Dispose();
                    }
                }
            }
        }
        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            OverwriteNodeGenericData(sender, e);
            UpdateSpecialNodeTab(sender, e);
        }
        public void OverwriteNodeGenericData(object sender, EventArgs e)
        {
            if (loading || nodeList.SelectedIndex == -1) return;

            loading = true;
            int nodeIndex;
            int clumpIndex = scene.ClumpIDFromGlobalIndex(nodeList.SelectedIndex, out nodeIndex);
            SceneNode curNode = scene.clumps[clumpIndex].nodes[nodeIndex];

            try
            {
                curNode.data.type = (SceneModelType)Enum.Parse(typeof(SceneModelType), typeBox.SelectedItem.ToString());
                curNode.data.subType = (uint)subTypeNum.Value;
                curNode.model_name = modelName.Text;
                curNode.geom_name = geomName.Text;
                float X = float.Parse(xPos.Text);
                float Y = float.Parse(yPos.Text);
                float Z = float.Parse(zPos.Text);
                float W = float.Parse(wPos.Text);
                curNode.pos = new Vector4(X, Y, Z, W);
                X = float.Parse(xRot.Text);
                Y = float.Parse(yRot.Text);
                Z = float.Parse(zRot.Text);
                W = float.Parse(wRot.Text);
                curNode.rot = new Vector4(X, Y, Z, W);
                X = float.Parse(xScale.Text);
                Y = float.Parse(yScale.Text);
                Z = float.Parse(zScale.Text);
                W = float.Parse(wScale.Text);
                curNode.scale = new Vector4(X, Y, Z, W);
                scene.clumps[clumpIndex].nodes[nodeIndex] = curNode;
            }
            catch { }

            // Update the listed node's name to match the model name.
            nodeList.Items[nodeList.SelectedIndex] = curNode.model_name;
            loading = false;
        }
        public void OverwiteSceneLevelData()
        {
            try
            {
                scene.name = levelName.Text;
                scene.version = float.Parse(levelVersion.Text);
                if (regenerateClumpsOnSaveToolStripMenuItem.Checked)
                {
                    float xCut = float.Parse(levelXCut.Text);
                    float zCut = float.Parse(levelZCut.Text);
                    float xMin = float.Parse(levelXMin.Text);
                    float zMin = float.Parse(levelZMin.Text);
                    float xMax = float.Parse(levelXMax.Text);
                    float zMax = float.Parse(levelZMax.Text);

                    if (scene.ClumpValuesAreDivisible((xMax - xMin), (zMax - zMin), xCut, zCut))
                    {
                        scene.x_cut_size = xCut;
                        scene.z_cut_size = zCut;
                        scene.min_x = xMin;
                        scene.max_x = xMax;
                        scene.min_z = zMin;
                        scene.max_z = zMax;
                    }
                    else
                    {
                        MessageBox.Show("Level Size was not perfectly divisible by the Level Cut Size..." + Environment.NewLine + "Saving with previous values.");
                        UpdateClumpRegenStatus();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed to parse the Scene's Level Data. Continuing...");
            }
        }
        public void OverwriteNode(SceneNode replacementNode)
        {
            if (nodeList.SelectedIndex == -1) return;
            int nodeIndex;
            int clumpIndex = scene.ClumpIDFromGlobalIndex(nodeList.SelectedIndex, out nodeIndex);
            scene.clumps[clumpIndex].nodes[nodeIndex] = replacementNode;
        }

        // ###############################################################################################################
        // ######_____________________________________MISC VARIABLES_AND_PROCESSES__________________________________######
        // ###############################################################################################################


        public Color FileNodeColor(string extension)
        {
            Color nodeCol = Color.White;
            switch (extension)
            {
                case ".txt":
                    // Script
                    // Cyan
                    nodeCol = Color.FromArgb(95, 144, 142);
                    break;
                case ".ccc":
                    // Level Collision(?)
                    // Green
                    nodeCol = Color.FromArgb(129, 163, 105);
                    break;
                case ".sf":
                    // Level Setup
                    // Also Green
                    nodeCol = Color.FromArgb(129, 163, 105);
                    break;
                case ".hxf":
                    // Character Model
                    // Pink
                    nodeCol = Color.FromArgb(187, 93, 105);
                    break;
                case ".nxf":
                    // Landscape Model
                    // Orange
                    nodeCol = Color.FromArgb(187, 109, 93);
                    break;
                case ".amf":
                    // Animation
                    // Reddish Brown
                    nodeCol = Color.FromArgb(109, 63, 63);
                    break;
                case ".tpl":
                    // Texture
                    // Ourple
                    nodeCol = Color.FromArgb(137, 117, 147);
                    break;

            }
            return nodeCol;
        }
        public ProcessStartInfo extractRAR(string sourcePath, string destPath)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
                FileName = $"\"{AppDomain.CurrentDomain.BaseDirectory}\\Rar.exe\"",
                Arguments = $" x \"{sourcePath}\" \"{destPath}\"",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true
            };
            return processStartInfo;
        }
        public ProcessStartInfo buildRAR(string sourcePath, string destPath)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
                FileName = $"\"{AppDomain.CurrentDomain.BaseDirectory}\\Rar.exe\"",
                Arguments = $" a -r -ep1 -ed \"{sourcePath}\" \"{destPath}\"",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true
            };
            return processStartInfo;
        }
    }
}
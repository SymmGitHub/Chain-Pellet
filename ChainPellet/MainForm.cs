using ChainPellet.panels.setup;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static ChainPellet.SFHandler;

namespace ChainPellet
{
    public partial class MainForm : Form
    {
        public bool loading = true;
        public string filePath;
        public string folderPath;
        public string objectsPath;
        public string scriptPath;
        public bool scriptOverwriteAvailable = false;
        SFHandler sf = new SFHandler();

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load Settings
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

            LoadLevelData();
            loading = false;
        }
        private void LoadLevelData()
        {
            AssetHierarchy.Nodes.Clear();
            nodeList.Items.Clear();
            sf = new SFHandler();
            MainPanel.Controls.Clear();
            setupPanel.Controls.Clear();
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
                        sf.ReadSetup(folderPath + "\\level.sf");
                        listLevelNodes(nodeFilterBox.Text);
                        levelName.Text = sf.levelInternalName;
                    }
                }
                AssetHierarchy.Nodes.Clear();
                AssetHierarchy.Nodes.AddRange(CreateDirectoryNodes(folderPath, true));
            }
            else MessageBox.Show("No directory found at: " + Environment.NewLine + folderPath);

            MainPanel_Resize(this, new EventArgs());
            SetupPanel_Resize(this, new EventArgs());
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
            AssetHierarchy.Nodes.Clear();
            if (Directory.Exists(folderPath))
            {
                // Automatically open path if it exists
                AssetHierarchy.Nodes.AddRange(CreateDirectoryNodes(folderPath, true));
            }
            else MessageBox.Show("No directory found at: " + Environment.NewLine + folderPath);
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
            else BuildLevel(folderPath);
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
        private void delAsset_Click(object sender, EventArgs e)
        {
            if (AssetHierarchy.Nodes.Count > 0)
            {
                if (AssetHierarchy.SelectedNode != null)
                {
                    if (File.Exists(folderPath + "\\" + AssetHierarchy.SelectedNode.FullPath))
                    {
                        File.Delete(folderPath + "\\" + AssetHierarchy.SelectedNode.FullPath);
                        AssetHierarchy.Nodes.Clear();
                        AssetHierarchy.Nodes.AddRange(CreateDirectoryNodes(folderPath, true));
                    }
                    else if (Directory.Exists(folderPath + "\\" + AssetHierarchy.SelectedNode.FullPath))
                    {
                        Directory.Delete(folderPath + "\\" + AssetHierarchy.SelectedNode.FullPath, true);
                        AssetHierarchy.Nodes.Clear();
                        AssetHierarchy.Nodes.AddRange(CreateDirectoryNodes(folderPath, true));
                    }
                }
            }
        }
        private void openArchive_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(folderPath)) return;
            var process = new Process();
            try
            {
                process.StartInfo = new ProcessStartInfo()
                {
                    UseShellExecute = true,
                    FileName = folderPath
                };
                process.Start();
            }
            catch { }
            process.Dispose();
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
        private void SetupPanel_Resize(object sender, EventArgs e)
        {
            if (setupPanel.Controls.Count > 0)
            {
                setupPanel.Controls[0].Size = setupPanel.Size;
            }
        }

        // ###############################################################################################################
        // ######____________________________________ASSET_HIERARCHY_HANDLING_______________________________________######
        // ###############################################################################################################

        private void AssetHierarchy_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
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
                nodeList.Items.Clear();
                sf.ReadSetup(fullPath);
                listLevelNodes(nodeFilterBox.Text);
                levelName.Text = sf.levelInternalName;
            }
            MainPanel_Resize(sender, e);
        }
        private void AssetHierarchy_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string filePath = folderPath + "\\" + e.Node.FullPath;
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
        public void RefreshAssetTreeview()
        {
            AssetHierarchy.Nodes.Clear();
            if (Directory.Exists(folderPath)) AssetHierarchy.Nodes.AddRange(CreateDirectoryNodes(folderPath, true));
            else MessageBox.Show("No directory found at: " + Environment.NewLine + folderPath);
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
        private void AssetHierarchy_DragDrop(object sender, DragEventArgs e)
        {
            //MessageBox.Show(e.Data.ToString());
        }

        // ###############################################################################################################
        // ######_______________________________________SETUP_FILE_HANDLING_________________________________________######
        // ###############################################################################################################
        private void SaveSetup_Click(object sender, EventArgs e)
        {
            if (File.Exists(folderPath + "\\level.sf"))
            {
                sf.WriteSetup(folderPath + "\\level.sf");
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Save a Pac-Man World 2 Setup File";
                save.Filter = "PMW2 Setup File (*.sf)|*.sf|All files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    sf.WriteSetup(save.FileName);
                }
            }
        }

        private void nodeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModifierKeys == Keys.Control) MessageBox.Show("Node List Count is: " + nodeList.Items.Count);
            if (nodeList.SelectedIndex != -1)
            {
                string nodeName = nodeList.SelectedItem.ToString();
                if (nodeName == null) return;
                SetupNode curNode = sf.levelNodes[nodeName];
                string category = "";

                switch (curNode.type)
                {
                    case "Point":
                        category = "Generic";
                        break;
                    case "Environment":
                        category = "Generic";
                        break;
                    case "Instance":
                        category = "Generic";
                        break;
                    case "Ground":
                        category = "Generic";
                        break;
                    case "Nurbs":
                        category = "Nurbs";
                        break;
                    case "Bounds":
                        category = "Array";
                        break;
                    case "Array":
                        category = "Array";
                        break;
                }
                switch (category)
                {
                    case "Generic":
                        SetupGeneric editorG = new SetupGeneric(this, curNode);
                        setupPanel.Controls.Clear();
                        setupPanel.Controls.Add(editorG);
                        break;
                    case "Array":
                        SetupBounds editorA = new SetupBounds(this, curNode);
                        setupPanel.Controls.Clear();
                        setupPanel.Controls.Add(editorA);
                        break;
                    case "Nurbs":
                        SetupNurbs editorN = new SetupNurbs(this, curNode);
                        setupPanel.Controls.Clear();
                        setupPanel.Controls.Add(editorN);
                        break;
                }
                SetupPanel_Resize(sender, e);
            }
        }
        private void listLevelNodes(string masterFilter)
        {
            if (sf.setupData.Length == 0) return;
            nodeList.Items.Clear();
            if (string.IsNullOrEmpty(masterFilter.Replace(" ", "")))
            {
                // No Filter, show all
                nodeList.Items.AddRange(sf.levelNodes.Keys.ToArray());
            }
            else
            {
                // Filter By filter string
                string[] filters = masterFilter.Split("|");
                foreach (string filter in filters)
                {
                    foreach (string nodeName in sf.levelNodes.Keys)
                    {
                        // Skip checking if it's already part of the Node List
                        if (!nodeList.Items.Contains(nodeName))
                        {
                            if (filter.StartsWith("#"))
                            {
                                // Filter by type
                                if (sf.levelNodes[nodeName].type.ToUpper() == filter.Substring(1).ToUpper())
                                    nodeList.Items.Add(nodeName);
                            }
                            else
                            {
                                // Filter by name
                                if (nodeName.Contains(filter))
                                    nodeList.Items.Add(nodeName);
                            }
                        }
                    }
                }
            }
        }
        private void RefreshNodeList(object sender, EventArgs e)
        {
            if (sf.setupData.Length > 0) listLevelNodes(nodeFilterBox.Text);
        }
        public void OverwriteNode(SetupNode node)
        {
            if (nodeList.SelectedIndex != -1)
            {
                sf.levelNodes[node.name] = node;
            }
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
namespace ChainPellet
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            openDirectoryToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            extractPMW2RarToolStripMenuItem = new ToolStripMenuItem();
            createPMW2RarToolStripMenuItem = new ToolStripMenuItem();
            editInternalStringsToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            assetHierarchyToolStripMenuItem = new ToolStripMenuItem();
            hideTXTFilesToolStripMenuItem = new ToolStripMenuItem();
            hideHXFFilesToolStripMenuItem = new ToolStripMenuItem();
            hideNXFFilesToolStripMenuItem = new ToolStripMenuItem();
            hideAMFFilesToolStripMenuItem = new ToolStripMenuItem();
            hideTPLFilesToolStripMenuItem = new ToolStripMenuItem();
            hideSFFilesToolStripMenuItem = new ToolStripMenuItem();
            hideCCCFilesToolStripMenuItem = new ToolStripMenuItem();
            sceneEditToolStripMenuItem = new ToolStripMenuItem();
            regenerateClumpsOnSaveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            useBigEndianToolStripMenuItem = new ToolStripMenuItem();
            useLittleEndianToolStripMenuItem = new ToolStripMenuItem();
            scriptEditorToolStripMenuItem = new ToolStripMenuItem();
            autoSaveScriptsToolStripMenuItem = new ToolStripMenuItem();
            setExtractionPathToolStripMenuItem = new ToolStripMenuItem();
            setObjectsFolderPathToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            AssetHierarchy = new TreeView();
            toolTip1 = new ToolTip(components);
            addAsset = new Button();
            addNodeBtn = new Button();
            label1 = new Label();
            MainPanel = new Panel();
            NodeDataPanel = new Panel();
            nodeList = new ListBox();
            groupBox1 = new GroupBox();
            SaveSceneAs = new Button();
            label17 = new Label();
            label16 = new Label();
            levelXMax = new TextBox();
            levelXMin = new TextBox();
            levelZMax = new TextBox();
            levelZMin = new TextBox();
            levelXCut = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label4 = new Label();
            levelZCut = new TextBox();
            label13 = new Label();
            label6 = new Label();
            levelVersion = new TextBox();
            nodeTabs = new TabControl();
            tabTransform = new TabPage();
            subTypeNum = new NumericUpDown();
            label19 = new Label();
            label18 = new Label();
            typeBox = new ComboBox();
            label12 = new Label();
            wScale = new TextBox();
            modelName = new TextBox();
            label11 = new Label();
            wRot = new TextBox();
            geomName = new TextBox();
            wPos = new TextBox();
            label10 = new Label();
            zScale = new TextBox();
            xPos = new TextBox();
            yScale = new TextBox();
            labelScale = new Label();
            zRot = new TextBox();
            label7 = new Label();
            xScale = new TextBox();
            labelPos = new Label();
            label8 = new Label();
            label9 = new Label();
            labelRot = new Label();
            zPos = new TextBox();
            yPos = new TextBox();
            xRot = new TextBox();
            yRot = new TextBox();
            tabSpecial = new TabPage();
            label5 = new Label();
            levelName = new TextBox();
            SaveScene = new Button();
            nodeFilterBox = new TextBox();
            label3 = new Label();
            assetFilterBox = new TextBox();
            nodeListContext = new ContextMenuStrip(components);
            duplicateNodeToolStripMenuItem = new ToolStripMenuItem();
            deleteNodeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            copyNodeCoordinatesToolStripMenuItem = new ToolStripMenuItem();
            pasteNodePositionToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            importNodeToolStripMenuItem = new ToolStripMenuItem();
            exportNodeToolStripMenuItem = new ToolStripMenuItem();
            assetHierarchyContext = new ContextMenuStrip(components);
            openAssetToolStripMenuItem = new ToolStripMenuItem();
            openAssetLocationToolStripMenuItem = new ToolStripMenuItem();
            deleteAssetToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            nodeTabs.SuspendLayout();
            tabTransform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)subTypeNum).BeginInit();
            tabSpecial.SuspendLayout();
            nodeListContext.SuspendLayout();
            assetHierarchyContext.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1402, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, openDirectoryToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(286, 26);
            openToolStripMenuItem.Text = "Open Rar";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // openDirectoryToolStripMenuItem
            // 
            openDirectoryToolStripMenuItem.Name = "openDirectoryToolStripMenuItem";
            openDirectoryToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.O;
            openDirectoryToolStripMenuItem.Size = new Size(286, 26);
            openDirectoryToolStripMenuItem.Text = "Open Directory";
            openDirectoryToolStripMenuItem.Click += openDirectoryToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(286, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(286, 26);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refreshToolStripMenuItem, extractPMW2RarToolStripMenuItem, createPMW2RarToolStripMenuItem, editInternalStringsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(58, 24);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            refreshToolStripMenuItem.Size = new Size(259, 26);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // extractPMW2RarToolStripMenuItem
            // 
            extractPMW2RarToolStripMenuItem.Name = "extractPMW2RarToolStripMenuItem";
            extractPMW2RarToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.D;
            extractPMW2RarToolStripMenuItem.Size = new Size(259, 26);
            extractPMW2RarToolStripMenuItem.Text = "Extract PMW2 Rar";
            extractPMW2RarToolStripMenuItem.ToolTipText = "Extract a PMW2 Archive (*.rar) file\r\ninto a folder of the same name.";
            extractPMW2RarToolStripMenuItem.Click += extractPMW2RarToolStripMenuItem_Click;
            // 
            // createPMW2RarToolStripMenuItem
            // 
            createPMW2RarToolStripMenuItem.Name = "createPMW2RarToolStripMenuItem";
            createPMW2RarToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            createPMW2RarToolStripMenuItem.Size = new Size(259, 26);
            createPMW2RarToolStripMenuItem.Text = "Create PMW2 Rar";
            createPMW2RarToolStripMenuItem.ToolTipText = "Compile a folder into a new PMW2\r\nArchive (*.rar) of the same name.\r\n";
            createPMW2RarToolStripMenuItem.Click += createPMW2RarToolStripMenuItem_Click;
            // 
            // editInternalStringsToolStripMenuItem
            // 
            editInternalStringsToolStripMenuItem.Name = "editInternalStringsToolStripMenuItem";
            editInternalStringsToolStripMenuItem.Size = new Size(259, 26);
            editInternalStringsToolStripMenuItem.Text = "Edit Internal Strings";
            editInternalStringsToolStripMenuItem.Click += editInternalStringsToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { assetHierarchyToolStripMenuItem, sceneEditToolStripMenuItem, scriptEditorToolStripMenuItem, setExtractionPathToolStripMenuItem, setObjectsFolderPathToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(76, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // assetHierarchyToolStripMenuItem
            // 
            assetHierarchyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hideTXTFilesToolStripMenuItem, hideHXFFilesToolStripMenuItem, hideNXFFilesToolStripMenuItem, hideAMFFilesToolStripMenuItem, hideTPLFilesToolStripMenuItem, hideSFFilesToolStripMenuItem, hideCCCFilesToolStripMenuItem });
            assetHierarchyToolStripMenuItem.Name = "assetHierarchyToolStripMenuItem";
            assetHierarchyToolStripMenuItem.Size = new Size(245, 26);
            assetHierarchyToolStripMenuItem.Text = "Asset Hierarchy";
            // 
            // hideTXTFilesToolStripMenuItem
            // 
            hideTXTFilesToolStripMenuItem.CheckOnClick = true;
            hideTXTFilesToolStripMenuItem.Name = "hideTXTFilesToolStripMenuItem";
            hideTXTFilesToolStripMenuItem.Size = new Size(319, 26);
            hideTXTFilesToolStripMenuItem.Text = "Hide TXT (Script) Files";
            hideTXTFilesToolStripMenuItem.CheckedChanged += updateHierarchyVisibility;
            // 
            // hideHXFFilesToolStripMenuItem
            // 
            hideHXFFilesToolStripMenuItem.CheckOnClick = true;
            hideHXFFilesToolStripMenuItem.Name = "hideHXFFilesToolStripMenuItem";
            hideHXFFilesToolStripMenuItem.Size = new Size(319, 26);
            hideHXFFilesToolStripMenuItem.Text = "Hide HXF (Character Model) Files";
            hideHXFFilesToolStripMenuItem.CheckedChanged += updateHierarchyVisibility;
            // 
            // hideNXFFilesToolStripMenuItem
            // 
            hideNXFFilesToolStripMenuItem.CheckOnClick = true;
            hideNXFFilesToolStripMenuItem.Name = "hideNXFFilesToolStripMenuItem";
            hideNXFFilesToolStripMenuItem.Size = new Size(319, 26);
            hideNXFFilesToolStripMenuItem.Text = "Hide NXF (Landscape Model) Files";
            hideNXFFilesToolStripMenuItem.CheckedChanged += updateHierarchyVisibility;
            // 
            // hideAMFFilesToolStripMenuItem
            // 
            hideAMFFilesToolStripMenuItem.CheckOnClick = true;
            hideAMFFilesToolStripMenuItem.Name = "hideAMFFilesToolStripMenuItem";
            hideAMFFilesToolStripMenuItem.Size = new Size(319, 26);
            hideAMFFilesToolStripMenuItem.Text = "Hide AMF (Animation) Files";
            hideAMFFilesToolStripMenuItem.CheckedChanged += updateHierarchyVisibility;
            // 
            // hideTPLFilesToolStripMenuItem
            // 
            hideTPLFilesToolStripMenuItem.CheckOnClick = true;
            hideTPLFilesToolStripMenuItem.Name = "hideTPLFilesToolStripMenuItem";
            hideTPLFilesToolStripMenuItem.Size = new Size(319, 26);
            hideTPLFilesToolStripMenuItem.Text = "Hide TPL (Texture) Files";
            hideTPLFilesToolStripMenuItem.CheckedChanged += updateHierarchyVisibility;
            // 
            // hideSFFilesToolStripMenuItem
            // 
            hideSFFilesToolStripMenuItem.CheckOnClick = true;
            hideSFFilesToolStripMenuItem.Name = "hideSFFilesToolStripMenuItem";
            hideSFFilesToolStripMenuItem.Size = new Size(319, 26);
            hideSFFilesToolStripMenuItem.Text = "Hide SF (Level Setup) Files";
            hideSFFilesToolStripMenuItem.CheckedChanged += updateHierarchyVisibility;
            // 
            // hideCCCFilesToolStripMenuItem
            // 
            hideCCCFilesToolStripMenuItem.CheckOnClick = true;
            hideCCCFilesToolStripMenuItem.Name = "hideCCCFilesToolStripMenuItem";
            hideCCCFilesToolStripMenuItem.Size = new Size(319, 26);
            hideCCCFilesToolStripMenuItem.Text = "Hide CCC (Level Collision) Files";
            hideCCCFilesToolStripMenuItem.CheckedChanged += updateHierarchyVisibility;
            // 
            // sceneEditToolStripMenuItem
            // 
            sceneEditToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { regenerateClumpsOnSaveToolStripMenuItem, toolStripSeparator3, useBigEndianToolStripMenuItem, useLittleEndianToolStripMenuItem });
            sceneEditToolStripMenuItem.Name = "sceneEditToolStripMenuItem";
            sceneEditToolStripMenuItem.Size = new Size(245, 26);
            sceneEditToolStripMenuItem.Text = "Scene Editor";
            // 
            // regenerateClumpsOnSaveToolStripMenuItem
            // 
            regenerateClumpsOnSaveToolStripMenuItem.Checked = true;
            regenerateClumpsOnSaveToolStripMenuItem.CheckOnClick = true;
            regenerateClumpsOnSaveToolStripMenuItem.CheckState = CheckState.Checked;
            regenerateClumpsOnSaveToolStripMenuItem.Name = "regenerateClumpsOnSaveToolStripMenuItem";
            regenerateClumpsOnSaveToolStripMenuItem.Size = new Size(279, 26);
            regenerateClumpsOnSaveToolStripMenuItem.Text = "Regenerate Clumps On Save";
            regenerateClumpsOnSaveToolStripMenuItem.Click += regenerateClumpsOnSaveToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(276, 6);
            // 
            // useBigEndianToolStripMenuItem
            // 
            useBigEndianToolStripMenuItem.CheckOnClick = true;
            useBigEndianToolStripMenuItem.Name = "useBigEndianToolStripMenuItem";
            useBigEndianToolStripMenuItem.Size = new Size(279, 26);
            useBigEndianToolStripMenuItem.Text = "Use Big Endian";
            useBigEndianToolStripMenuItem.CheckedChanged += ReverseEndianness;
            // 
            // useLittleEndianToolStripMenuItem
            // 
            useLittleEndianToolStripMenuItem.CheckOnClick = true;
            useLittleEndianToolStripMenuItem.Name = "useLittleEndianToolStripMenuItem";
            useLittleEndianToolStripMenuItem.Size = new Size(279, 26);
            useLittleEndianToolStripMenuItem.Text = "Use Little Endian";
            useLittleEndianToolStripMenuItem.CheckedChanged += ReverseEndianness;
            // 
            // scriptEditorToolStripMenuItem
            // 
            scriptEditorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { autoSaveScriptsToolStripMenuItem });
            scriptEditorToolStripMenuItem.Name = "scriptEditorToolStripMenuItem";
            scriptEditorToolStripMenuItem.Size = new Size(245, 26);
            scriptEditorToolStripMenuItem.Text = "Script Editor";
            // 
            // autoSaveScriptsToolStripMenuItem
            // 
            autoSaveScriptsToolStripMenuItem.CheckOnClick = true;
            autoSaveScriptsToolStripMenuItem.Name = "autoSaveScriptsToolStripMenuItem";
            autoSaveScriptsToolStripMenuItem.Size = new Size(209, 26);
            autoSaveScriptsToolStripMenuItem.Text = "Auto-Save Scripts";
            autoSaveScriptsToolStripMenuItem.ToolTipText = "If enabled, any edits made to TXT files\r\nwill be automatically saved to its file\r\nin the extracted archive.";
            autoSaveScriptsToolStripMenuItem.CheckedChanged += autoSaveScriptsToolStripMenuItem_CheckedChanged;
            // 
            // setExtractionPathToolStripMenuItem
            // 
            setExtractionPathToolStripMenuItem.Name = "setExtractionPathToolStripMenuItem";
            setExtractionPathToolStripMenuItem.Size = new Size(245, 26);
            setExtractionPathToolStripMenuItem.Text = "Set Extraction Path";
            setExtractionPathToolStripMenuItem.Click += setExtractionPathToolStripMenuItem_Click;
            // 
            // setObjectsFolderPathToolStripMenuItem
            // 
            setObjectsFolderPathToolStripMenuItem.Name = "setObjectsFolderPathToolStripMenuItem";
            setObjectsFolderPathToolStripMenuItem.Size = new Size(245, 26);
            setObjectsFolderPathToolStripMenuItem.Text = "Set Objects Folder Path";
            setObjectsFolderPathToolStripMenuItem.Click += setObjectsFolderPathToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(11, 32);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 4;
            label2.Text = "Asset Hierarchy";
            // 
            // AssetHierarchy
            // 
            AssetHierarchy.AllowDrop = true;
            AssetHierarchy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AssetHierarchy.BackColor = Color.FromArgb(32, 32, 35);
            AssetHierarchy.ForeColor = SystemColors.Window;
            AssetHierarchy.HideSelection = false;
            AssetHierarchy.LineColor = Color.White;
            AssetHierarchy.Location = new Point(11, 56);
            AssetHierarchy.Name = "AssetHierarchy";
            AssetHierarchy.Size = new Size(382, 563);
            AssetHierarchy.TabIndex = 10;
            AssetHierarchy.AfterSelect += AssetHierarchy_AfterSelect;
            AssetHierarchy.NodeMouseDoubleClick += AssetHierarchy_NodeMouseDoubleClick;
            AssetHierarchy.DragDrop += AssetHierarchy_DragDrop;
            AssetHierarchy.MouseDown += AssetHierarchy_MouseDown;
            // 
            // addAsset
            // 
            addAsset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addAsset.Location = new Point(11, 625);
            addAsset.Name = "addAsset";
            addAsset.Size = new Size(105, 36);
            addAsset.TabIndex = 0;
            addAsset.Text = "Add Asset";
            toolTip1.SetToolTip(addAsset, "Copy assets from PMW2's 'Object'\r\nfolder to the extracted folder path.");
            addAsset.UseVisualStyleBackColor = true;
            addAsset.Click += addAsset_Click;
            // 
            // addNodeBtn
            // 
            addNodeBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addNodeBtn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            addNodeBtn.ForeColor = SystemColors.ControlText;
            addNodeBtn.Location = new Point(6, 256);
            addNodeBtn.Name = "addNodeBtn";
            addNodeBtn.Size = new Size(196, 30);
            addNodeBtn.TabIndex = 40;
            addNodeBtn.Text = "Create New Node";
            toolTip1.SetToolTip(addNodeBtn, "Create a new Node to add to the Node List.");
            addNodeBtn.UseVisualStyleBackColor = true;
            addNodeBtn.Click += addNodeBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(209, 259);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 17;
            label1.Text = "Search";
            toolTip1.SetToolTip(label1, "Select a Node from the Node List\r\nby the first one containing your\r\nsearch term.");
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainPanel.BackColor = Color.FromArgb(64, 64, 68);
            MainPanel.Location = new Point(399, 32);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(578, 630);
            MainPanel.TabIndex = 12;
            MainPanel.SizeChanged += MainPanel_Resize;
            // 
            // NodeDataPanel
            // 
            NodeDataPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NodeDataPanel.BackColor = Color.FromArgb(64, 64, 68);
            NodeDataPanel.Location = new Point(0, 0);
            NodeDataPanel.Name = "NodeDataPanel";
            NodeDataPanel.Size = new Size(395, 300);
            NodeDataPanel.TabIndex = 13;
            NodeDataPanel.SizeChanged += NodeDataPanel_Resize;
            // 
            // nodeList
            // 
            nodeList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            nodeList.BackColor = Color.FromArgb(32, 32, 35);
            nodeList.ForeColor = SystemColors.Control;
            nodeList.FormattingEnabled = true;
            nodeList.ItemHeight = 20;
            nodeList.Location = new Point(6, 46);
            nodeList.Name = "nodeList";
            nodeList.Size = new Size(196, 204);
            nodeList.TabIndex = 15;
            nodeList.SelectedIndexChanged += nodeList_SelectedIndexChanged;
            nodeList.MouseDown += nodeList_MouseDown;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(SaveSceneAs);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(addNodeBtn);
            groupBox1.Controls.Add(levelXMax);
            groupBox1.Controls.Add(levelXMin);
            groupBox1.Controls.Add(levelZMax);
            groupBox1.Controls.Add(levelZMin);
            groupBox1.Controls.Add(levelXCut);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(levelZCut);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(levelVersion);
            groupBox1.Controls.Add(nodeTabs);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(levelName);
            groupBox1.Controls.Add(SaveScene);
            groupBox1.Controls.Add(nodeList);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(nodeFilterBox);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(983, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 629);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Scene Editor";
            // 
            // SaveSceneAs
            // 
            SaveSceneAs.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveSceneAs.ForeColor = SystemColors.ControlText;
            SaveSceneAs.Location = new Point(300, 217);
            SaveSceneAs.Name = "SaveSceneAs";
            SaveSceneAs.Size = new Size(101, 33);
            SaveSceneAs.TabIndex = 44;
            SaveSceneAs.Text = "Save (.sf) As";
            SaveSceneAs.UseVisualStyleBackColor = true;
            SaveSceneAs.Click += SaveSceneAs_Click;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Location = new Point(208, 183);
            label17.Name = "label17";
            label17.Size = new Size(40, 20);
            label17.TabIndex = 42;
            label17.Text = "Max.";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Location = new Point(208, 150);
            label16.Name = "label16";
            label16.Size = new Size(37, 20);
            label16.TabIndex = 41;
            label16.Text = "Min.";
            // 
            // levelXMax
            // 
            levelXMax.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            levelXMax.Location = new Point(276, 180);
            levelXMax.Name = "levelXMax";
            levelXMax.Size = new Size(60, 27);
            levelXMax.TabIndex = 39;
            // 
            // levelXMin
            // 
            levelXMin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            levelXMin.Location = new Point(276, 147);
            levelXMin.Name = "levelXMin";
            levelXMin.Size = new Size(60, 27);
            levelXMin.TabIndex = 38;
            // 
            // levelZMax
            // 
            levelZMax.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            levelZMax.Location = new Point(341, 180);
            levelZMax.Name = "levelZMax";
            levelZMax.Size = new Size(60, 27);
            levelZMax.TabIndex = 37;
            // 
            // levelZMin
            // 
            levelZMin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            levelZMin.Location = new Point(341, 147);
            levelZMin.Name = "levelZMin";
            levelZMin.Size = new Size(60, 27);
            levelZMin.TabIndex = 36;
            // 
            // levelXCut
            // 
            levelXCut.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            levelXCut.Location = new Point(276, 114);
            levelXCut.Name = "levelXCut";
            levelXCut.Size = new Size(60, 27);
            levelXCut.TabIndex = 35;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Location = new Point(334, 91);
            label15.Name = "label15";
            label15.Size = new Size(18, 20);
            label15.TabIndex = 34;
            label15.Text = "Z";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(276, 89);
            label14.Name = "label14";
            label14.Size = new Size(18, 20);
            label14.TabIndex = 33;
            label14.Text = "X";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(208, 117);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 32;
            label4.Text = "Cut Size";
            // 
            // levelZCut
            // 
            levelZCut.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            levelZCut.Location = new Point(341, 114);
            levelZCut.Name = "levelZCut";
            levelZCut.Size = new Size(60, 27);
            levelZCut.TabIndex = 31;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(209, 23);
            label13.Name = "label13";
            label13.Size = new Size(49, 20);
            label13.TabIndex = 30;
            label13.Text = "Name";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(209, 56);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 29;
            label6.Text = "Version";
            // 
            // levelVersion
            // 
            levelVersion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            levelVersion.Location = new Point(277, 53);
            levelVersion.Name = "levelVersion";
            levelVersion.Size = new Size(125, 27);
            levelVersion.TabIndex = 28;
            // 
            // nodeTabs
            // 
            nodeTabs.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nodeTabs.Controls.Add(tabTransform);
            nodeTabs.Controls.Add(tabSpecial);
            nodeTabs.Location = new Point(6, 294);
            nodeTabs.Name = "nodeTabs";
            nodeTabs.SelectedIndex = 0;
            nodeTabs.Size = new Size(400, 329);
            nodeTabs.TabIndex = 24;
            // 
            // tabTransform
            // 
            tabTransform.BackColor = Color.FromArgb(64, 64, 68);
            tabTransform.Controls.Add(subTypeNum);
            tabTransform.Controls.Add(label19);
            tabTransform.Controls.Add(label18);
            tabTransform.Controls.Add(typeBox);
            tabTransform.Controls.Add(label12);
            tabTransform.Controls.Add(wScale);
            tabTransform.Controls.Add(modelName);
            tabTransform.Controls.Add(label11);
            tabTransform.Controls.Add(wRot);
            tabTransform.Controls.Add(geomName);
            tabTransform.Controls.Add(wPos);
            tabTransform.Controls.Add(label10);
            tabTransform.Controls.Add(zScale);
            tabTransform.Controls.Add(xPos);
            tabTransform.Controls.Add(yScale);
            tabTransform.Controls.Add(labelScale);
            tabTransform.Controls.Add(zRot);
            tabTransform.Controls.Add(label7);
            tabTransform.Controls.Add(xScale);
            tabTransform.Controls.Add(labelPos);
            tabTransform.Controls.Add(label8);
            tabTransform.Controls.Add(label9);
            tabTransform.Controls.Add(labelRot);
            tabTransform.Controls.Add(zPos);
            tabTransform.Controls.Add(yPos);
            tabTransform.Controls.Add(xRot);
            tabTransform.Controls.Add(yRot);
            tabTransform.ForeColor = SystemColors.Control;
            tabTransform.Location = new Point(4, 29);
            tabTransform.Name = "tabTransform";
            tabTransform.Padding = new Padding(3);
            tabTransform.Size = new Size(392, 296);
            tabTransform.TabIndex = 0;
            tabTransform.Text = "Transform";
            // 
            // subTypeNum
            // 
            subTypeNum.Location = new Point(305, 96);
            subTypeNum.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            subTypeNum.Name = "subTypeNum";
            subTypeNum.Size = new Size(76, 27);
            subTypeNum.TabIndex = 79;
            subTypeNum.ValueChanged += OverwriteNodeGenericData;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = SystemColors.Control;
            label19.Location = new Point(228, 98);
            label19.Name = "label19";
            label19.Size = new Size(71, 20);
            label19.TabIndex = 78;
            label19.Text = "Sub-Type";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = SystemColors.Control;
            label18.Location = new Point(10, 98);
            label18.Name = "label18";
            label18.Size = new Size(40, 20);
            label18.TabIndex = 77;
            label18.Text = "Type";
            // 
            // typeBox
            // 
            typeBox.FormattingEnabled = true;
            typeBox.Location = new Point(56, 95);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(166, 28);
            typeBox.TabIndex = 76;
            typeBox.SelectedIndexChanged += typeBox_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(10, 53);
            label12.Name = "label12";
            label12.Size = new Size(96, 20);
            label12.TabIndex = 75;
            label12.Text = "Geom. Name";
            // 
            // wScale
            // 
            wScale.Location = new Point(261, 254);
            wScale.Name = "wScale";
            wScale.Size = new Size(108, 27);
            wScale.TabIndex = 71;
            wScale.TextChanged += OverwriteNodeGenericData;
            // 
            // modelName
            // 
            modelName.Location = new Point(112, 17);
            modelName.MaxLength = 32;
            modelName.Name = "modelName";
            modelName.Size = new Size(269, 27);
            modelName.TabIndex = 72;
            modelName.TextChanged += OverwriteNodeGenericData;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(10, 20);
            label11.Name = "label11";
            label11.Size = new Size(96, 20);
            label11.TabIndex = 74;
            label11.Text = "Model Name";
            // 
            // wRot
            // 
            wRot.Location = new Point(148, 254);
            wRot.Name = "wRot";
            wRot.Size = new Size(108, 27);
            wRot.TabIndex = 70;
            wRot.TextChanged += OverwriteNodeGenericData;
            // 
            // geomName
            // 
            geomName.Location = new Point(112, 50);
            geomName.MaxLength = 32;
            geomName.Name = "geomName";
            geomName.Size = new Size(269, 27);
            geomName.TabIndex = 73;
            geomName.TextChanged += OverwriteNodeGenericData;
            // 
            // wPos
            // 
            wPos.Location = new Point(35, 254);
            wPos.Name = "wPos";
            wPos.Size = new Size(108, 27);
            wPos.TabIndex = 69;
            wPos.TextChanged += OverwriteNodeGenericData;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(10, 257);
            label10.Name = "label10";
            label10.Size = new Size(23, 20);
            label10.TabIndex = 68;
            label10.Text = "W";
            // 
            // zScale
            // 
            zScale.Location = new Point(261, 223);
            zScale.Name = "zScale";
            zScale.Size = new Size(108, 27);
            zScale.TabIndex = 61;
            zScale.TextChanged += OverwriteNodeGenericData;
            // 
            // xPos
            // 
            xPos.Location = new Point(35, 161);
            xPos.Name = "xPos";
            xPos.Size = new Size(108, 27);
            xPos.TabIndex = 53;
            xPos.TextChanged += OverwriteNodeGenericData;
            // 
            // yScale
            // 
            yScale.Location = new Point(261, 192);
            yScale.Name = "yScale";
            yScale.Size = new Size(108, 27);
            yScale.TabIndex = 60;
            yScale.TextChanged += OverwriteNodeGenericData;
            // 
            // labelScale
            // 
            labelScale.AutoSize = true;
            labelScale.ForeColor = SystemColors.Control;
            labelScale.Location = new Point(259, 138);
            labelScale.Name = "labelScale";
            labelScale.Size = new Size(44, 20);
            labelScale.TabIndex = 67;
            labelScale.Text = "Scale";
            // 
            // zRot
            // 
            zRot.Location = new Point(148, 223);
            zRot.Name = "zRot";
            zRot.Size = new Size(108, 27);
            zRot.TabIndex = 58;
            zRot.TextChanged += OverwriteNodeGenericData;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(10, 195);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 63;
            label7.Text = "Y";
            // 
            // xScale
            // 
            xScale.Location = new Point(261, 161);
            xScale.Name = "xScale";
            xScale.Size = new Size(108, 27);
            xScale.TabIndex = 59;
            xScale.TextChanged += OverwriteNodeGenericData;
            // 
            // labelPos
            // 
            labelPos.AutoSize = true;
            labelPos.ForeColor = SystemColors.Control;
            labelPos.Location = new Point(35, 138);
            labelPos.Name = "labelPos";
            labelPos.Size = new Size(61, 20);
            labelPos.TabIndex = 65;
            labelPos.Text = "Position";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(10, 164);
            label8.Name = "label8";
            label8.Size = new Size(18, 20);
            label8.TabIndex = 62;
            label8.Text = "X";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(10, 226);
            label9.Name = "label9";
            label9.Size = new Size(18, 20);
            label9.TabIndex = 64;
            label9.Text = "Z";
            // 
            // labelRot
            // 
            labelRot.AutoSize = true;
            labelRot.ForeColor = SystemColors.Control;
            labelRot.Location = new Point(145, 138);
            labelRot.Name = "labelRot";
            labelRot.Size = new Size(66, 20);
            labelRot.TabIndex = 66;
            labelRot.Text = "Rotation";
            // 
            // zPos
            // 
            zPos.Location = new Point(35, 223);
            zPos.Name = "zPos";
            zPos.Size = new Size(108, 27);
            zPos.TabIndex = 55;
            zPos.TextChanged += OverwriteNodeGenericData;
            // 
            // yPos
            // 
            yPos.Location = new Point(35, 192);
            yPos.Name = "yPos";
            yPos.Size = new Size(108, 27);
            yPos.TabIndex = 54;
            yPos.TextChanged += OverwriteNodeGenericData;
            // 
            // xRot
            // 
            xRot.Location = new Point(148, 161);
            xRot.Name = "xRot";
            xRot.Size = new Size(108, 27);
            xRot.TabIndex = 56;
            xRot.TextChanged += OverwriteNodeGenericData;
            // 
            // yRot
            // 
            yRot.Location = new Point(148, 192);
            yRot.Name = "yRot";
            yRot.Size = new Size(108, 27);
            yRot.TabIndex = 57;
            yRot.TextChanged += OverwriteNodeGenericData;
            // 
            // tabSpecial
            // 
            tabSpecial.BackColor = Color.FromArgb(64, 64, 68);
            tabSpecial.Controls.Add(NodeDataPanel);
            tabSpecial.Location = new Point(4, 29);
            tabSpecial.Name = "tabSpecial";
            tabSpecial.Padding = new Padding(3);
            tabSpecial.Size = new Size(392, 296);
            tabSpecial.TabIndex = 1;
            tabSpecial.Text = "Additional Data";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 23);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 21;
            label5.Text = "Node List";
            // 
            // levelName
            // 
            levelName.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            levelName.Location = new Point(277, 20);
            levelName.Name = "levelName";
            levelName.Size = new Size(125, 27);
            levelName.TabIndex = 20;
            // 
            // SaveScene
            // 
            SaveScene.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveScene.ForeColor = SystemColors.ControlText;
            SaveScene.Location = new Point(209, 217);
            SaveScene.Name = "SaveScene";
            SaveScene.Size = new Size(85, 33);
            SaveScene.TabIndex = 18;
            SaveScene.Text = "Save (.sf)";
            SaveScene.UseVisualStyleBackColor = true;
            SaveScene.Click += SaveScene_Click;
            // 
            // nodeFilterBox
            // 
            nodeFilterBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nodeFilterBox.Location = new Point(265, 256);
            nodeFilterBox.Name = "nodeFilterBox";
            nodeFilterBox.Size = new Size(136, 27);
            nodeFilterBox.TabIndex = 16;
            nodeFilterBox.TextChanged += nodeFilterBox_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(122, 632);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 19;
            label3.Text = "Filter";
            // 
            // assetFilterBox
            // 
            assetFilterBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            assetFilterBox.Location = new Point(170, 629);
            assetFilterBox.Name = "assetFilterBox";
            assetFilterBox.Size = new Size(223, 27);
            assetFilterBox.TabIndex = 18;
            assetFilterBox.TextChanged += assetFilterBox_TextChanged;
            // 
            // nodeListContext
            // 
            nodeListContext.ImageScalingSize = new Size(20, 20);
            nodeListContext.Items.AddRange(new ToolStripItem[] { duplicateNodeToolStripMenuItem, deleteNodeToolStripMenuItem, toolStripSeparator1, copyNodeCoordinatesToolStripMenuItem, pasteNodePositionToolStripMenuItem, toolStripSeparator2, importNodeToolStripMenuItem, exportNodeToolStripMenuItem });
            nodeListContext.Name = "contextMenuStrip1";
            nodeListContext.Size = new Size(210, 160);
            // 
            // duplicateNodeToolStripMenuItem
            // 
            duplicateNodeToolStripMenuItem.Name = "duplicateNodeToolStripMenuItem";
            duplicateNodeToolStripMenuItem.Size = new Size(209, 24);
            duplicateNodeToolStripMenuItem.Text = "Duplicate Node";
            duplicateNodeToolStripMenuItem.Click += duplicateNodeToolStripMenuItem_Click;
            // 
            // deleteNodeToolStripMenuItem
            // 
            deleteNodeToolStripMenuItem.Name = "deleteNodeToolStripMenuItem";
            deleteNodeToolStripMenuItem.Size = new Size(209, 24);
            deleteNodeToolStripMenuItem.Text = "Delete Node";
            deleteNodeToolStripMenuItem.Click += deleteNodeToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(206, 6);
            // 
            // copyNodeCoordinatesToolStripMenuItem
            // 
            copyNodeCoordinatesToolStripMenuItem.Name = "copyNodeCoordinatesToolStripMenuItem";
            copyNodeCoordinatesToolStripMenuItem.Size = new Size(209, 24);
            copyNodeCoordinatesToolStripMenuItem.Text = "Copy Node Position";
            copyNodeCoordinatesToolStripMenuItem.Click += copyNodePositionToolStripMenuItem_Click;
            // 
            // pasteNodePositionToolStripMenuItem
            // 
            pasteNodePositionToolStripMenuItem.Name = "pasteNodePositionToolStripMenuItem";
            pasteNodePositionToolStripMenuItem.Size = new Size(209, 24);
            pasteNodePositionToolStripMenuItem.Text = "Paste Node Position";
            pasteNodePositionToolStripMenuItem.Click += pasteNodePositionToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(206, 6);
            // 
            // importNodeToolStripMenuItem
            // 
            importNodeToolStripMenuItem.Name = "importNodeToolStripMenuItem";
            importNodeToolStripMenuItem.Size = new Size(209, 24);
            importNodeToolStripMenuItem.Text = "Import Node";
            importNodeToolStripMenuItem.Click += importNodeToolStripMenuItem_Click;
            // 
            // exportNodeToolStripMenuItem
            // 
            exportNodeToolStripMenuItem.Name = "exportNodeToolStripMenuItem";
            exportNodeToolStripMenuItem.Size = new Size(209, 24);
            exportNodeToolStripMenuItem.Text = "Export Node";
            exportNodeToolStripMenuItem.Click += exportNodeToolStripMenuItem_Click;
            // 
            // assetHierarchyContext
            // 
            assetHierarchyContext.ImageScalingSize = new Size(20, 20);
            assetHierarchyContext.Items.AddRange(new ToolStripItem[] { openAssetToolStripMenuItem, openAssetLocationToolStripMenuItem, deleteAssetToolStripMenuItem });
            assetHierarchyContext.Name = "assetHierarchyContext";
            assetHierarchyContext.Size = new Size(215, 76);
            // 
            // openAssetToolStripMenuItem
            // 
            openAssetToolStripMenuItem.Name = "openAssetToolStripMenuItem";
            openAssetToolStripMenuItem.Size = new Size(214, 24);
            openAssetToolStripMenuItem.Text = "Open Asset";
            openAssetToolStripMenuItem.Click += openAssetToolStripMenuItem_Click;
            // 
            // openAssetLocationToolStripMenuItem
            // 
            openAssetLocationToolStripMenuItem.Name = "openAssetLocationToolStripMenuItem";
            openAssetLocationToolStripMenuItem.Size = new Size(214, 24);
            openAssetLocationToolStripMenuItem.Text = "Open Asset Location";
            openAssetLocationToolStripMenuItem.Click += openAssetLocationToolStripMenuItem_Click;
            // 
            // deleteAssetToolStripMenuItem
            // 
            deleteAssetToolStripMenuItem.Name = "deleteAssetToolStripMenuItem";
            deleteAssetToolStripMenuItem.Size = new Size(214, 24);
            deleteAssetToolStripMenuItem.Text = "Delete Asset";
            deleteAssetToolStripMenuItem.Click += deleteAssetToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 68);
            ClientSize = new Size(1402, 673);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(assetFilterBox);
            Controls.Add(addAsset);
            Controls.Add(MainPanel);
            Controls.Add(AssetHierarchy);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1420, 720);
            Name = "MainForm";
            Text = "Chain Pellet - Pac-Man World 2 Editor";
            Load += MainForm_Load;
            ResizeEnd += MainPanel_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            nodeTabs.ResumeLayout(false);
            tabTransform.ResumeLayout(false);
            tabTransform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)subTypeNum).EndInit();
            tabSpecial.ResumeLayout(false);
            nodeListContext.ResumeLayout(false);
            assetHierarchyContext.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private Label label2;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem extractPMW2RarToolStripMenuItem;
        private ToolStripMenuItem createPMW2RarToolStripMenuItem;
        private TreeView AssetHierarchy;
        private ToolTip toolTip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem assetHierarchyToolStripMenuItem;
        private ToolStripMenuItem hideHXFFilesToolStripMenuItem;
        private ToolStripMenuItem hideNXFFilesToolStripMenuItem;
        private ToolStripMenuItem hideTXTFilesToolStripMenuItem;
        private ToolStripMenuItem hideSFFilesToolStripMenuItem;
        private ToolStripMenuItem hideCCCFilesToolStripMenuItem;
        private ToolStripMenuItem hideAMFFilesToolStripMenuItem;
        private ToolStripMenuItem hideTPLFilesToolStripMenuItem;
        private ToolStripMenuItem scriptEditorToolStripMenuItem;
        private ToolStripMenuItem autoSaveScriptsToolStripMenuItem;
        private ToolStripMenuItem setObjectsFolderPathToolStripMenuItem;
        private Panel MainPanel;
        private Button addAsset;
        private ListBox nodeList;
        private GroupBox groupBox1;
        private TextBox nodeFilterBox;
        private Label label1;
        private Panel NodeDataPanel;
        private ToolStripMenuItem openDirectoryToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private Label label3;
        private TextBox assetFilterBox;
        private ToolStripMenuItem setExtractionPathToolStripMenuItem;
        private Button SaveScene;
        private TextBox levelName;
        private Label label5;
        private ToolStripMenuItem editInternalStringsToolStripMenuItem;
        private TabControl nodeTabs;
        private TabPage tabTransform;
        private TabPage tabSpecial;
        private TextBox zScale;
        private TextBox xPos;
        private TextBox yScale;
        private Label labelScale;
        private TextBox zRot;
        private Label label7;
        private TextBox xScale;
        private Label labelPos;
        private Label label8;
        private Label label9;
        private Label labelRot;
        private TextBox zPos;
        private TextBox yPos;
        private TextBox xRot;
        private TextBox yRot;
        private TextBox modelName;
        private TextBox wScale;
        private TextBox wRot;
        private TextBox wPos;
        private Label label10;
        private Label label12;
        private Label label11;
        private TextBox geomName;
        private Label label6;
        private TextBox levelVersion;
        private Label label13;
        private TextBox levelXCut;
        private Label label15;
        private Label label14;
        private Label label4;
        private TextBox levelZCut;
        private TextBox levelXMax;
        private TextBox levelXMin;
        private TextBox levelZMax;
        private TextBox levelZMin;
        private Label label18;
        private ToolStripMenuItem sceneEditToolStripMenuItem;
        private ToolStripMenuItem regenerateClumpsOnSaveToolStripMenuItem;
        private Button addNodeBtn;
        private Label label17;
        private Label label16;
        private ComboBox typeBox;
        private NumericUpDown subTypeNum;
        private Label label19;
        private Button SaveSceneAs;
        private ContextMenuStrip nodeListContext;
        private ToolStripMenuItem deleteNodeToolStripMenuItem;
        private ToolStripMenuItem duplicateNodeToolStripMenuItem;
        private ToolStripMenuItem copyNodeCoordinatesToolStripMenuItem;
        private ToolStripMenuItem exportNodeToolStripMenuItem;
        private ToolStripMenuItem importNodeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem pasteNodePositionToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem useBigEndianToolStripMenuItem;
        private ToolStripMenuItem useLittleEndianToolStripMenuItem;
        private ContextMenuStrip assetHierarchyContext;
        private ToolStripMenuItem openAssetToolStripMenuItem;
        private ToolStripMenuItem openAssetLocationToolStripMenuItem;
        private ToolStripMenuItem deleteAssetToolStripMenuItem;
    }
}
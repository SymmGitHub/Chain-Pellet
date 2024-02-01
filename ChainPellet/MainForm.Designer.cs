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
            settingsToolStripMenuItem = new ToolStripMenuItem();
            assetHierarchyToolStripMenuItem = new ToolStripMenuItem();
            hideTXTFilesToolStripMenuItem = new ToolStripMenuItem();
            hideHXFFilesToolStripMenuItem = new ToolStripMenuItem();
            hideNXFFilesToolStripMenuItem = new ToolStripMenuItem();
            hideAMFFilesToolStripMenuItem = new ToolStripMenuItem();
            hideTPLFilesToolStripMenuItem = new ToolStripMenuItem();
            hideSFFilesToolStripMenuItem = new ToolStripMenuItem();
            hideCCCFilesToolStripMenuItem = new ToolStripMenuItem();
            scriptEditorToolStripMenuItem = new ToolStripMenuItem();
            autoSaveScriptsToolStripMenuItem = new ToolStripMenuItem();
            setExtractionPathToolStripMenuItem = new ToolStripMenuItem();
            setObjectsFolderPathToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            AssetHierarchy = new TreeView();
            toolTip1 = new ToolTip(components);
            addAsset = new Button();
            delAsset = new Button();
            openArchive = new Button();
            MainPanel = new Panel();
            setupPanel = new Panel();
            nodeList = new ListBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            levelName = new TextBox();
            label4 = new Label();
            SaveSetup = new Button();
            label1 = new Label();
            nodeFilterBox = new TextBox();
            label3 = new Label();
            assetFilterBox = new TextBox();
            editInternalStringsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
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
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { assetHierarchyToolStripMenuItem, scriptEditorToolStripMenuItem, setExtractionPathToolStripMenuItem, setObjectsFolderPathToolStripMenuItem });
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
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Asset List";
            // 
            // AssetHierarchy
            // 
            AssetHierarchy.AllowDrop = true;
            AssetHierarchy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AssetHierarchy.BackColor = Color.FromArgb(32, 32, 35);
            AssetHierarchy.ForeColor = SystemColors.Window;
            AssetHierarchy.HideSelection = false;
            AssetHierarchy.LineColor = Color.White;
            AssetHierarchy.Location = new Point(11, 55);
            AssetHierarchy.Name = "AssetHierarchy";
            AssetHierarchy.Size = new Size(382, 531);
            AssetHierarchy.TabIndex = 10;
            AssetHierarchy.NodeMouseClick += AssetHierarchy_NodeMouseClick;
            AssetHierarchy.NodeMouseDoubleClick += AssetHierarchy_NodeMouseDoubleClick;
            AssetHierarchy.DragDrop += AssetHierarchy_DragDrop;
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
            // delAsset
            // 
            delAsset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            delAsset.Location = new Point(122, 625);
            delAsset.Name = "delAsset";
            delAsset.Size = new Size(105, 36);
            delAsset.TabIndex = 13;
            delAsset.Text = "Delete Asset";
            toolTip1.SetToolTip(delAsset, "Delete the selected asset\r\nfrom the Asset List above.");
            delAsset.UseVisualStyleBackColor = true;
            delAsset.Click += delAsset_Click;
            // 
            // openArchive
            // 
            openArchive.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            openArchive.Location = new Point(233, 625);
            openArchive.Name = "openArchive";
            openArchive.Size = new Size(160, 36);
            openArchive.TabIndex = 14;
            openArchive.Text = "Open Archive Folder";
            toolTip1.SetToolTip(openArchive, "Open your file explorer to the folder\r\n(.rar) files are extracted to.");
            openArchive.UseVisualStyleBackColor = true;
            openArchive.Click += openArchive_Click;
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
            // setupPanel
            // 
            setupPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            setupPanel.BackColor = Color.FromArgb(64, 64, 68);
            setupPanel.Location = new Point(6, 323);
            setupPanel.Name = "setupPanel";
            setupPanel.Size = new Size(400, 300);
            setupPanel.TabIndex = 13;
            setupPanel.SizeChanged += SetupPanel_Resize;
            // 
            // nodeList
            // 
            nodeList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nodeList.BackColor = Color.FromArgb(32, 32, 35);
            nodeList.ForeColor = SystemColors.Control;
            nodeList.FormattingEnabled = true;
            nodeList.ItemHeight = 20;
            nodeList.Location = new Point(6, 46);
            nodeList.Name = "nodeList";
            nodeList.Size = new Size(269, 244);
            nodeList.TabIndex = 15;
            nodeList.SelectedIndexChanged += nodeList_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(levelName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(SaveSetup);
            groupBox1.Controls.Add(setupPanel);
            groupBox1.Controls.Add(nodeList);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(nodeFilterBox);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(983, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 629);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Level Data";
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
            levelName.Location = new Point(281, 46);
            levelName.Name = "levelName";
            levelName.Size = new Size(125, 27);
            levelName.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(282, 23);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 19;
            label4.Text = "Internal Name";
            // 
            // SaveSetup
            // 
            SaveSetup.ForeColor = SystemColors.ControlText;
            SaveSetup.Location = new Point(281, 288);
            SaveSetup.Name = "SaveSetup";
            SaveSetup.Size = new Size(126, 33);
            SaveSetup.TabIndex = 18;
            SaveSetup.Text = "Save Data";
            SaveSetup.UseVisualStyleBackColor = true;
            SaveSetup.Click += SaveSetup_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 294);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 17;
            label1.Text = "Filter";
            // 
            // nodeFilterBox
            // 
            nodeFilterBox.Location = new Point(54, 291);
            nodeFilterBox.Name = "nodeFilterBox";
            nodeFilterBox.Size = new Size(221, 27);
            nodeFilterBox.TabIndex = 16;
            nodeFilterBox.TextChanged += RefreshNodeList;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 595);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 19;
            label3.Text = "Filter";
            // 
            // assetFilterBox
            // 
            assetFilterBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            assetFilterBox.Location = new Point(60, 592);
            assetFilterBox.Name = "assetFilterBox";
            assetFilterBox.Size = new Size(333, 27);
            assetFilterBox.TabIndex = 18;
            assetFilterBox.TextChanged += assetFilterBox_TextChanged;
            // 
            // editInternalStringsToolStripMenuItem
            // 
            editInternalStringsToolStripMenuItem.Name = "editInternalStringsToolStripMenuItem";
            editInternalStringsToolStripMenuItem.Size = new Size(259, 26);
            editInternalStringsToolStripMenuItem.Text = "Edit Internal Strings";
            editInternalStringsToolStripMenuItem.Click += editInternalStringsToolStripMenuItem_Click;
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
            Controls.Add(openArchive);
            Controls.Add(delAsset);
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
        private Button delAsset;
        private Button openArchive;
        private ListBox nodeList;
        private GroupBox groupBox1;
        private TextBox nodeFilterBox;
        private Label label1;
        private Panel setupPanel;
        private ToolStripMenuItem openDirectoryToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private Label label3;
        private TextBox assetFilterBox;
        private ToolStripMenuItem setExtractionPathToolStripMenuItem;
        private Button SaveSetup;
        private TextBox levelName;
        private Label label4;
        private Label label5;
        private ToolStripMenuItem editInternalStringsToolStripMenuItem;
    }
}
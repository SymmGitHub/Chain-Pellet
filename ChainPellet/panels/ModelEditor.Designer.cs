namespace ChainPellet
{
    partial class ModelEditor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            saveBtn = new Button();
            replaceColorOne = new Button();
            groupBox2 = new GroupBox();
            alphaIgnore = new CheckBox();
            label3 = new Label();
            alphaValue = new NumericUpDown();
            newColBtn = new Button();
            newHex = new TextBox();
            colorSectionList = new ListBox();
            replaceColorAll = new Button();
            label2 = new Label();
            paletteList = new ComboBox();
            toolTip1 = new ToolTip(components);
            addressList = new ListBox();
            colorList = new ListView();
            hexColumn = new ColumnHeader();
            colorColumn = new ColumnHeader();
            colorListContext = new ContextMenuStrip(components);
            copyColorHexToolStripMenuItem = new ToolStripMenuItem();
            copyColorRGBToolStripMenuItem = new ToolStripMenuItem();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)alphaValue).BeginInit();
            colorListContext.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 32;
            label1.Text = "Model Color Editor";
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveBtn.BackColor = Color.FromArgb(32, 32, 35);
            saveBtn.ForeColor = SystemColors.Control;
            saveBtn.Location = new Point(295, 591);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(280, 36);
            saveBtn.TabIndex = 31;
            saveBtn.Text = "Save Model";
            toolTip1.SetToolTip(saveBtn, "Save the changes made\r\nto this model's colors.");
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // replaceColorOne
            // 
            replaceColorOne.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            replaceColorOne.BackColor = Color.FromArgb(32, 32, 35);
            replaceColorOne.ForeColor = SystemColors.Control;
            replaceColorOne.Location = new Point(3, 591);
            replaceColorOne.Name = "replaceColorOne";
            replaceColorOne.Size = new Size(136, 36);
            replaceColorOne.TabIndex = 30;
            replaceColorOne.Text = "Replace";
            toolTip1.SetToolTip(replaceColorOne, "Replace a selected color value\r\nat this address.");
            replaceColorOne.UseVisualStyleBackColor = false;
            replaceColorOne.Click += ReplaceColor_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.Controls.Add(alphaIgnore);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(alphaValue);
            groupBox2.Controls.Add(newColBtn);
            groupBox2.Controls.Add(newHex);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(3, 327);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(136, 260);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "New Color";
            // 
            // alphaIgnore
            // 
            alphaIgnore.AutoSize = true;
            alphaIgnore.Checked = true;
            alphaIgnore.CheckState = CheckState.Checked;
            alphaIgnore.Location = new Point(6, 222);
            alphaIgnore.MinimumSize = new Size(124, 0);
            alphaIgnore.Name = "alphaIgnore";
            alphaIgnore.Size = new Size(124, 24);
            alphaIgnore.TabIndex = 40;
            alphaIgnore.Text = "Ignore Alpha";
            alphaIgnore.TextAlign = ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(alphaIgnore, "Toggle whether the alpha value is\r\nreplaced when overwriting a color.");
            alphaIgnore.UseVisualStyleBackColor = true;
            alphaIgnore.CheckedChanged += alphaIgnore_CheckedChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(6, 191);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 39;
            label3.Text = "Alpha";
            toolTip1.SetToolTip(label3, "Edit the fourth byte after the RGB values\r\nof a color, may affect opacity of certain\r\ncolors on a model.\r\n");
            // 
            // alphaValue
            // 
            alphaValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            alphaValue.Enabled = false;
            alphaValue.Location = new Point(60, 189);
            alphaValue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            alphaValue.Name = "alphaValue";
            alphaValue.Size = new Size(70, 27);
            alphaValue.TabIndex = 39;
            toolTip1.SetToolTip(alphaValue, "Edit the fourth byte after the RGB values\r\nof a color, may affect opacity of certain\r\ncolors on a model.");
            alphaValue.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // newColBtn
            // 
            newColBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            newColBtn.Location = new Point(6, 26);
            newColBtn.Name = "newColBtn";
            newColBtn.Size = new Size(124, 124);
            newColBtn.TabIndex = 18;
            newColBtn.UseVisualStyleBackColor = true;
            newColBtn.Click += newColBtn_Click;
            // 
            // newHex
            // 
            newHex.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            newHex.BackColor = Color.FromArgb(32, 32, 35);
            newHex.ForeColor = SystemColors.Control;
            newHex.Location = new Point(6, 156);
            newHex.MaxLength = 20;
            newHex.Name = "newHex";
            newHex.Size = new Size(124, 27);
            newHex.TabIndex = 17;
            newHex.TextAlign = HorizontalAlignment.Center;
            newHex.TextChanged += newHex_TextChanged;
            // 
            // colorSectionList
            // 
            colorSectionList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            colorSectionList.BackColor = Color.FromArgb(32, 32, 35);
            colorSectionList.ForeColor = SystemColors.Control;
            colorSectionList.FormattingEnabled = true;
            colorSectionList.ItemHeight = 20;
            colorSectionList.Location = new Point(3, 23);
            colorSectionList.Name = "colorSectionList";
            colorSectionList.Size = new Size(286, 264);
            colorSectionList.TabIndex = 26;
            colorSectionList.SelectedIndexChanged += colorSectionList_SelectedIndexChanged;
            // 
            // replaceColorAll
            // 
            replaceColorAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            replaceColorAll.BackColor = Color.FromArgb(32, 32, 35);
            replaceColorAll.ForeColor = SystemColors.Control;
            replaceColorAll.Location = new Point(145, 591);
            replaceColorAll.Name = "replaceColorAll";
            replaceColorAll.Size = new Size(144, 36);
            replaceColorAll.TabIndex = 25;
            replaceColorAll.Text = "Replace All";
            toolTip1.SetToolTip(replaceColorAll, "Replace every color value\r\nat this address.");
            replaceColorAll.UseVisualStyleBackColor = false;
            replaceColorAll.Click += ReplaceAll_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(3, 296);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 24;
            label2.Text = "Palette";
            // 
            // paletteList
            // 
            paletteList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            paletteList.FormattingEnabled = true;
            paletteList.Location = new Point(63, 293);
            paletteList.Name = "paletteList";
            paletteList.Size = new Size(226, 28);
            paletteList.TabIndex = 23;
            paletteList.SelectedIndexChanged += palette_SelectedIndexChanged;
            // 
            // addressList
            // 
            addressList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addressList.BackColor = Color.FromArgb(32, 32, 35);
            addressList.ForeColor = SystemColors.Control;
            addressList.FormattingEnabled = true;
            addressList.ItemHeight = 20;
            addressList.Location = new Point(295, 3);
            addressList.Name = "addressList";
            addressList.Size = new Size(280, 584);
            addressList.TabIndex = 35;
            addressList.SelectedIndexChanged += addressList_SelectedIndexChanged;
            // 
            // colorList
            // 
            colorList.Activation = ItemActivation.OneClick;
            colorList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            colorList.AutoArrange = false;
            colorList.BackColor = Color.FromArgb(32, 32, 35);
            colorList.Columns.AddRange(new ColumnHeader[] { hexColumn, colorColumn });
            colorList.ForeColor = SystemColors.Window;
            colorList.FullRowSelect = true;
            colorList.HideSelection = true;
            colorList.LabelWrap = false;
            colorList.Location = new Point(145, 335);
            colorList.MultiSelect = false;
            colorList.Name = "colorList";
            colorList.ShowGroups = false;
            colorList.Size = new Size(144, 252);
            colorList.TabIndex = 38;
            colorList.UseCompatibleStateImageBehavior = false;
            colorList.View = View.Details;
            // 
            // hexColumn
            // 
            hexColumn.DisplayIndex = 1;
            hexColumn.Text = "Hex";
            hexColumn.Width = 80;
            // 
            // colorColumn
            // 
            colorColumn.DisplayIndex = 0;
            colorColumn.Text = "Col.";
            colorColumn.Width = 45;
            // 
            // colorListContext
            // 
            colorListContext.ImageScalingSize = new Size(20, 20);
            colorListContext.Items.AddRange(new ToolStripItem[] { copyColorHexToolStripMenuItem, copyColorRGBToolStripMenuItem });
            colorListContext.Name = "colorListContext";
            colorListContext.Size = new Size(185, 52);
            // 
            // copyColorHexToolStripMenuItem
            // 
            copyColorHexToolStripMenuItem.Name = "copyColorHexToolStripMenuItem";
            copyColorHexToolStripMenuItem.Size = new Size(184, 24);
            copyColorHexToolStripMenuItem.Text = "Copy Color Hex";
            copyColorHexToolStripMenuItem.Click += copyColorHexToolStripMenuItem_Click;
            // 
            // copyColorRGBToolStripMenuItem
            // 
            copyColorRGBToolStripMenuItem.Name = "copyColorRGBToolStripMenuItem";
            copyColorRGBToolStripMenuItem.Size = new Size(184, 24);
            copyColorRGBToolStripMenuItem.Text = "Copy Color RGB";
            copyColorRGBToolStripMenuItem.Click += copyColorRGBToolStripMenuItem_Click;
            // 
            // ModelEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 68);
            Controls.Add(colorList);
            Controls.Add(addressList);
            Controls.Add(label1);
            Controls.Add(saveBtn);
            Controls.Add(replaceColorOne);
            Controls.Add(groupBox2);
            Controls.Add(colorSectionList);
            Controls.Add(replaceColorAll);
            Controls.Add(label2);
            Controls.Add(paletteList);
            Name = "ModelEditor";
            Size = new Size(578, 630);
            Load += ModelEditor_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)alphaValue).EndInit();
            colorListContext.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button saveBtn;
        private Button replaceColorOne;
        private GroupBox groupBox2;
        private ListBox colorSectionList;
        private Button replaceColorAll;
        private Label label2;
        private ComboBox paletteList;
        private Button newColBtn;
        private TextBox newHex;
        private ToolTip toolTip1;
        private ListBox addressList;
        private ListView colorList;
        private ColumnHeader colorColumn;
        private ColumnHeader hexColumn;
        private NumericUpDown alphaValue;
        private Label label3;
        private CheckBox alphaIgnore;
        private ContextMenuStrip colorListContext;
        private ToolStripMenuItem copyColorHexToolStripMenuItem;
        private ToolStripMenuItem copyColorRGBToolStripMenuItem;
        private ToolStripMenuItem pasteColorHexToolStripMenuItem;
        private ToolStripMenuItem pasteColorRGBToolStripMenuItem;
    }
}

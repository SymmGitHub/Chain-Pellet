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
            saveColor = new Button();
            groupBox2 = new GroupBox();
            newColBtn = new Button();
            newHex = new TextBox();
            groupBox1 = new GroupBox();
            oldColBtn = new Button();
            oldHex = new TextBox();
            colorSectionList = new ListBox();
            savePalette = new Button();
            label2 = new Label();
            palette = new ComboBox();
            searchColor = new Button();
            toolTip1 = new ToolTip(components);
            label3 = new Label();
            addressOffset = new NumericUpDown();
            addressList = new ListBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addressOffset).BeginInit();
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
            saveBtn.Location = new Point(409, 591);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(166, 36);
            saveBtn.TabIndex = 31;
            saveBtn.Text = "Save Model";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // saveColor
            // 
            saveColor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            saveColor.BackColor = Color.FromArgb(32, 32, 35);
            saveColor.ForeColor = SystemColors.Control;
            saveColor.Location = new Point(3, 551);
            saveColor.Name = "saveColor";
            saveColor.Size = new Size(140, 36);
            saveColor.TabIndex = 30;
            saveColor.Text = "Replace";
            saveColor.UseVisualStyleBackColor = false;
            saveColor.Click += saveColor_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.Controls.Add(newColBtn);
            groupBox2.Controls.Add(newHex);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(3, 387);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(140, 158);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "New Color";
            // 
            // newColBtn
            // 
            newColBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            newColBtn.Location = new Point(6, 26);
            newColBtn.Name = "newColBtn";
            newColBtn.Size = new Size(128, 93);
            newColBtn.TabIndex = 18;
            newColBtn.UseVisualStyleBackColor = true;
            newColBtn.Click += newColBtn_Click;
            // 
            // newHex
            // 
            newHex.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            newHex.BackColor = Color.FromArgb(32, 32, 35);
            newHex.ForeColor = SystemColors.Control;
            newHex.Location = new Point(6, 125);
            newHex.MaxLength = 6;
            newHex.Name = "newHex";
            newHex.Size = new Size(128, 27);
            newHex.TabIndex = 17;
            newHex.TextAlign = HorizontalAlignment.Center;
            newHex.TextChanged += newHex_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(oldColBtn);
            groupBox1.Controls.Add(oldHex);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(149, 387);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(140, 158);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Old Color";
            // 
            // oldColBtn
            // 
            oldColBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            oldColBtn.Location = new Point(6, 26);
            oldColBtn.Name = "oldColBtn";
            oldColBtn.Size = new Size(128, 93);
            oldColBtn.TabIndex = 19;
            oldColBtn.UseVisualStyleBackColor = true;
            // 
            // oldHex
            // 
            oldHex.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            oldHex.BackColor = Color.FromArgb(32, 32, 35);
            oldHex.ForeColor = SystemColors.Control;
            oldHex.Location = new Point(6, 125);
            oldHex.MaxLength = 6;
            oldHex.Name = "oldHex";
            oldHex.ReadOnly = true;
            oldHex.Size = new Size(128, 27);
            oldHex.TabIndex = 18;
            oldHex.TextAlign = HorizontalAlignment.Center;
            oldHex.TextChanged += oldHex_TextChanged;
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
            colorSectionList.Size = new Size(286, 324);
            colorSectionList.TabIndex = 26;
            colorSectionList.SelectedIndexChanged += colorSectionList_SelectedIndexChanged;
            // 
            // savePalette
            // 
            savePalette.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            savePalette.BackColor = Color.FromArgb(32, 32, 35);
            savePalette.ForeColor = SystemColors.Control;
            savePalette.Location = new Point(149, 551);
            savePalette.Name = "savePalette";
            savePalette.Size = new Size(140, 36);
            savePalette.TabIndex = 25;
            savePalette.Text = "Replace All";
            savePalette.UseVisualStyleBackColor = false;
            savePalette.Click += savePalette_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(3, 356);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 24;
            label2.Text = "Palette";
            // 
            // palette
            // 
            palette.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            palette.FormattingEnabled = true;
            palette.Location = new Point(63, 353);
            palette.Name = "palette";
            palette.Size = new Size(226, 28);
            palette.TabIndex = 23;
            palette.SelectedIndexChanged += palette_SelectedIndexChanged;
            // 
            // searchColor
            // 
            searchColor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            searchColor.BackColor = Color.FromArgb(32, 32, 35);
            searchColor.ForeColor = SystemColors.Control;
            searchColor.Location = new Point(3, 591);
            searchColor.Name = "searchColor";
            searchColor.Size = new Size(286, 36);
            searchColor.TabIndex = 33;
            searchColor.Text = "Search Color";
            toolTip1.SetToolTip(searchColor, "Search for any instances of the\r\nnew color above and adds them\r\nto the address list on the right.");
            searchColor.UseVisualStyleBackColor = false;
            searchColor.Click += searchColor_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(295, 599);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 36;
            label3.Text = "Offset";
            toolTip1.SetToolTip(label3, "Offset where color data is read\r\nfrom by N bytes, if you can't find\r\nthe color you're looking for.");
            // 
            // addressOffset
            // 
            addressOffset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addressOffset.Increment = new decimal(new int[] { 4, 0, 0, 0 });
            addressOffset.Location = new Point(350, 597);
            addressOffset.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            addressOffset.Minimum = new decimal(new int[] { 64, 0, 0, int.MinValue });
            addressOffset.Name = "addressOffset";
            addressOffset.Size = new Size(53, 27);
            addressOffset.TabIndex = 37;
            toolTip1.SetToolTip(addressOffset, "Offset where color data is read\r\nfrom by N bytes, if you can't find\r\nthe color you're looking for.");
            addressOffset.ValueChanged += addressOffset_ValueChanged;
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
            // ModelEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 68);
            Controls.Add(addressOffset);
            Controls.Add(label3);
            Controls.Add(addressList);
            Controls.Add(searchColor);
            Controls.Add(label1);
            Controls.Add(saveBtn);
            Controls.Add(saveColor);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(colorSectionList);
            Controls.Add(savePalette);
            Controls.Add(label2);
            Controls.Add(palette);
            Name = "ModelEditor";
            Size = new Size(578, 630);
            Load += ModelEditor_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addressOffset).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button saveBtn;
        private Button saveColor;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private ListBox colorSectionList;
        private Button savePalette;
        private Label label2;
        private ComboBox palette;
        private Button newColBtn;
        private TextBox newHex;
        private Button oldColBtn;
        private TextBox oldHex;
        private Button searchColor;
        private ToolTip toolTip1;
        private ListView listView1;
        private ListBox addressList;
        private Label label3;
        private NumericUpDown addressOffset;
    }
}

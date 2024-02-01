namespace ChainPellet
{
    partial class DolEditor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            stringList = new ListBox();
            stringBox = new TextBox();
            label1 = new Label();
            filter = new TextBox();
            label2 = new Label();
            label3 = new Label();
            startPos = new TextBox();
            endPos = new TextBox();
            save = new Button();
            CharLimit = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // stringList
            // 
            stringList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stringList.BackColor = Color.FromArgb(32, 32, 35);
            stringList.ForeColor = SystemColors.Window;
            stringList.FormattingEnabled = true;
            stringList.ItemHeight = 20;
            stringList.Location = new Point(12, 12);
            stringList.Name = "stringList";
            stringList.Size = new Size(408, 264);
            stringList.TabIndex = 0;
            stringList.SelectedIndexChanged += stringList_SelectedIndexChanged;
            // 
            // stringBox
            // 
            stringBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stringBox.Location = new Point(12, 311);
            stringBox.Name = "stringBox";
            stringBox.Size = new Size(275, 27);
            stringBox.TabIndex = 1;
            stringBox.TextChanged += stringBox_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 288);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 2;
            label1.Text = "Text";
            // 
            // filter
            // 
            filter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            filter.Location = new Point(12, 364);
            filter.Name = "filter";
            filter.Size = new Size(224, 27);
            filter.TabIndex = 3;
            filter.TextChanged += filter_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 341);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 4;
            label2.Text = "Search Filter";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(242, 341);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 6;
            label3.Text = "Address Range";
            // 
            // startPos
            // 
            startPos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            startPos.BackColor = Color.FromArgb(200, 200, 255);
            startPos.Location = new Point(242, 364);
            startPos.Name = "startPos";
            startPos.Size = new Size(86, 27);
            startPos.TabIndex = 7;
            startPos.TextChanged += addressRangeChanged;
            // 
            // endPos
            // 
            endPos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            endPos.BackColor = Color.FromArgb(200, 200, 255);
            endPos.Location = new Point(334, 364);
            endPos.Name = "endPos";
            endPos.Size = new Size(86, 27);
            endPos.TabIndex = 8;
            endPos.TextChanged += addressRangeChanged;
            // 
            // save
            // 
            save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            save.Location = new Point(334, 309);
            save.Name = "save";
            save.Size = new Size(86, 31);
            save.TabIndex = 9;
            save.Text = "Save DOL";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // CharLimit
            // 
            CharLimit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CharLimit.Enabled = false;
            CharLimit.Location = new Point(293, 311);
            CharLimit.Name = "CharLimit";
            CharLimit.Size = new Size(35, 27);
            CharLimit.TabIndex = 10;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(288, 288);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 11;
            label4.Text = "Chars. ";
            // 
            // DolEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 68);
            ClientSize = new Size(432, 403);
            Controls.Add(label4);
            Controls.Add(CharLimit);
            Controls.Add(save);
            Controls.Add(endPos);
            Controls.Add(startPos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(filter);
            Controls.Add(label1);
            Controls.Add(stringBox);
            Controls.Add(stringList);
            MinimumSize = new Size(350, 350);
            Name = "DolEditor";
            Text = "DolEditor";
            Load += DolEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox stringList;
        private TextBox stringBox;
        private Label label1;
        private TextBox filter;
        private Label label2;
        private Label label3;
        private TextBox startPos;
        private TextBox endPos;
        private Button save;
        private TextBox CharLimit;
        private Label label4;
    }
}
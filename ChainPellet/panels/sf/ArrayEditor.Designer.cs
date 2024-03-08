namespace ChainPellet.panels.sf
{
    partial class ArrayEditor
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
            arrayList = new ListBox();
            addPointBtn = new Button();
            delPointBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            xPos = new TextBox();
            yPos = new TextBox();
            zPos = new TextBox();
            wPos = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // arrayList
            // 
            arrayList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            arrayList.BackColor = Color.FromArgb(32, 32, 35);
            arrayList.ForeColor = SystemColors.Window;
            arrayList.FormattingEnabled = true;
            arrayList.ItemHeight = 20;
            arrayList.Location = new Point(3, 23);
            arrayList.Name = "arrayList";
            arrayList.Size = new Size(130, 224);
            arrayList.TabIndex = 0;
            arrayList.SelectedIndexChanged += arrayList_SelectedIndexChanged;
            // 
            // addPointBtn
            // 
            addPointBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addPointBtn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            addPointBtn.ForeColor = SystemColors.ControlText;
            addPointBtn.Location = new Point(3, 253);
            addPointBtn.Name = "addPointBtn";
            addPointBtn.Size = new Size(62, 30);
            addPointBtn.TabIndex = 1;
            addPointBtn.Text = "Add";
            addPointBtn.UseVisualStyleBackColor = true;
            addPointBtn.Click += addPointBtn_Click;
            // 
            // delPointBtn
            // 
            delPointBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            delPointBtn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            delPointBtn.ForeColor = SystemColors.ControlText;
            delPointBtn.Location = new Point(71, 253);
            delPointBtn.Name = "delPointBtn";
            delPointBtn.Size = new Size(62, 30);
            delPointBtn.TabIndex = 2;
            delPointBtn.Text = "Delete";
            delPointBtn.UseVisualStyleBackColor = true;
            delPointBtn.Click += delPointBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(145, 36);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 3;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(12, 2);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 4;
            label2.Text = "Array Point List";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(139, 162);
            label3.Name = "label3";
            label3.Size = new Size(253, 65);
            label3.TabIndex = 86;
            label3.Text = "Edit the coordinates of this Point within the Point Array.\r\n";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // xPos
            // 
            xPos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            xPos.Location = new Point(176, 33);
            xPos.Name = "xPos";
            xPos.Size = new Size(175, 27);
            xPos.TabIndex = 87;
            xPos.TextChanged += ArrayDataEdited;
            // 
            // yPos
            // 
            yPos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            yPos.Location = new Point(176, 66);
            yPos.Name = "yPos";
            yPos.Size = new Size(175, 27);
            yPos.TabIndex = 88;
            yPos.TextChanged += ArrayDataEdited;
            // 
            // zPos
            // 
            zPos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            zPos.Location = new Point(176, 99);
            zPos.Name = "zPos";
            zPos.Size = new Size(175, 27);
            zPos.TabIndex = 89;
            zPos.TextChanged += ArrayDataEdited;
            // 
            // wPos
            // 
            wPos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            wPos.Location = new Point(176, 132);
            wPos.Name = "wPos";
            wPos.Size = new Size(175, 27);
            wPos.TabIndex = 90;
            wPos.TextChanged += ArrayDataEdited;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(145, 69);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 91;
            label4.Text = "Y";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(145, 102);
            label5.Name = "label5";
            label5.Size = new Size(18, 20);
            label5.TabIndex = 92;
            label5.Text = "Z";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(145, 135);
            label6.Name = "label6";
            label6.Size = new Size(23, 20);
            label6.TabIndex = 93;
            label6.Text = "W";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(232, 2);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 94;
            label7.Text = "Position";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ArrayEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 68);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(wPos);
            Controls.Add(zPos);
            Controls.Add(yPos);
            Controls.Add(xPos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(delPointBtn);
            Controls.Add(addPointBtn);
            Controls.Add(arrayList);
            ForeColor = SystemColors.Control;
            Name = "ArrayEditor";
            Size = new Size(395, 300);
            Load += ArrayEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox arrayList;
        private Button addPointBtn;
        private Button delPointBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox xPos;
        private TextBox yPos;
        private TextBox zPos;
        private TextBox wPos;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}

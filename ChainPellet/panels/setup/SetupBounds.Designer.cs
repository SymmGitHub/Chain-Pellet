namespace ChainPellet.panels.setup
{
    partial class SetupBounds
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
            label2 = new Label();
            label4 = new Label();
            label7 = new Label();
            label1 = new Label();
            weight = new TextBox();
            xPos2 = new TextBox();
            zPos2 = new TextBox();
            yPos2 = new TextBox();
            secondaryPoints = new ListBox();
            zScale = new TextBox();
            xPos = new TextBox();
            yScale = new TextBox();
            labelScale = new Label();
            zRot = new TextBox();
            label5 = new Label();
            xScale = new TextBox();
            labelPos = new Label();
            label3 = new Label();
            label6 = new Label();
            labelRot = new Label();
            zPos = new TextBox();
            yPos = new TextBox();
            xRot = new TextBox();
            yRot = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(216, 235);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 98;
            label2.Text = "Y Pos";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(215, 202);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 97;
            label4.Text = "X Pos";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(215, 268);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 99;
            label7.Text = "Z Pos";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(203, 169);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 96;
            label1.Text = "Weight";
            // 
            // weight
            // 
            weight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            weight.BackColor = Color.FromArgb(200, 200, 255);
            weight.Location = new Point(265, 166);
            weight.Name = "weight";
            weight.Size = new Size(119, 27);
            weight.TabIndex = 95;
            weight.TextChanged += OnSecondaryDataChanged;
            // 
            // xPos2
            // 
            xPos2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            xPos2.BackColor = Color.FromArgb(200, 200, 255);
            xPos2.Location = new Point(265, 199);
            xPos2.Name = "xPos2";
            xPos2.Size = new Size(119, 27);
            xPos2.TabIndex = 92;
            xPos2.TextChanged += OnSecondaryDataChanged;
            // 
            // zPos2
            // 
            zPos2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            zPos2.BackColor = Color.FromArgb(200, 200, 255);
            zPos2.Location = new Point(265, 265);
            zPos2.Name = "zPos2";
            zPos2.Size = new Size(119, 27);
            zPos2.TabIndex = 94;
            zPos2.TextChanged += OnSecondaryDataChanged;
            // 
            // yPos2
            // 
            yPos2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            yPos2.BackColor = Color.FromArgb(200, 200, 255);
            yPos2.Location = new Point(265, 232);
            yPos2.Name = "yPos2";
            yPos2.Size = new Size(119, 27);
            yPos2.TabIndex = 93;
            yPos2.TextChanged += OnSecondaryDataChanged;
            // 
            // secondaryPoints
            // 
            secondaryPoints.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            secondaryPoints.BackColor = Color.FromArgb(32, 32, 50);
            secondaryPoints.ForeColor = SystemColors.Control;
            secondaryPoints.FormattingEnabled = true;
            secondaryPoints.ItemHeight = 20;
            secondaryPoints.Location = new Point(9, 153);
            secondaryPoints.Name = "secondaryPoints";
            secondaryPoints.Size = new Size(188, 144);
            secondaryPoints.TabIndex = 76;
            secondaryPoints.SelectedIndexChanged += secondaryPoints_SelectedIndexChanged;
            // 
            // zScale
            // 
            zScale.Location = new Point(242, 89);
            zScale.Name = "zScale";
            zScale.Size = new Size(70, 27);
            zScale.TabIndex = 85;
            zScale.TextChanged += OnNodeDataChanged;
            // 
            // xPos
            // 
            xPos.Location = new Point(90, 23);
            xPos.Name = "xPos";
            xPos.Size = new Size(70, 27);
            xPos.TabIndex = 77;
            xPos.TextChanged += OnNodeDataChanged;
            // 
            // yScale
            // 
            yScale.Location = new Point(242, 56);
            yScale.Name = "yScale";
            yScale.Size = new Size(70, 27);
            yScale.TabIndex = 84;
            yScale.TextChanged += OnNodeDataChanged;
            // 
            // labelScale
            // 
            labelScale.AutoSize = true;
            labelScale.ForeColor = SystemColors.Control;
            labelScale.Location = new Point(242, 0);
            labelScale.Name = "labelScale";
            labelScale.Size = new Size(44, 20);
            labelScale.TabIndex = 91;
            labelScale.Text = "Scale";
            // 
            // zRot
            // 
            zRot.Location = new Point(166, 89);
            zRot.Name = "zRot";
            zRot.Size = new Size(70, 27);
            zRot.TabIndex = 82;
            zRot.TextChanged += OnNodeDataChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(67, 59);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 87;
            label5.Text = "Y";
            // 
            // xScale
            // 
            xScale.Location = new Point(242, 23);
            xScale.Name = "xScale";
            xScale.Size = new Size(70, 27);
            xScale.TabIndex = 83;
            xScale.TextChanged += OnNodeDataChanged;
            // 
            // labelPos
            // 
            labelPos.AutoSize = true;
            labelPos.ForeColor = SystemColors.Control;
            labelPos.Location = new Point(90, 0);
            labelPos.Name = "labelPos";
            labelPos.Size = new Size(61, 20);
            labelPos.TabIndex = 89;
            labelPos.Text = "Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(67, 26);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 86;
            label3.Text = "X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(67, 92);
            label6.Name = "label6";
            label6.Size = new Size(18, 20);
            label6.TabIndex = 88;
            label6.Text = "Z";
            // 
            // labelRot
            // 
            labelRot.AutoSize = true;
            labelRot.ForeColor = SystemColors.Control;
            labelRot.Location = new Point(166, 0);
            labelRot.Name = "labelRot";
            labelRot.Size = new Size(66, 20);
            labelRot.TabIndex = 90;
            labelRot.Text = "Rotation";
            // 
            // zPos
            // 
            zPos.Location = new Point(90, 89);
            zPos.Name = "zPos";
            zPos.Size = new Size(70, 27);
            zPos.TabIndex = 79;
            zPos.TextChanged += OnNodeDataChanged;
            // 
            // yPos
            // 
            yPos.Location = new Point(90, 56);
            yPos.Name = "yPos";
            yPos.Size = new Size(70, 27);
            yPos.TabIndex = 78;
            yPos.TextChanged += OnNodeDataChanged;
            // 
            // xRot
            // 
            xRot.Location = new Point(166, 23);
            xRot.Name = "xRot";
            xRot.Size = new Size(70, 27);
            xRot.TabIndex = 80;
            xRot.TextChanged += OnNodeDataChanged;
            // 
            // yRot
            // 
            yRot.Location = new Point(166, 56);
            yRot.Name = "yRot";
            yRot.Size = new Size(70, 27);
            yRot.TabIndex = 81;
            yRot.TextChanged += OnNodeDataChanged;
            // 
            // SetupBounds
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 68);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(weight);
            Controls.Add(xPos2);
            Controls.Add(zPos2);
            Controls.Add(yPos2);
            Controls.Add(secondaryPoints);
            Controls.Add(zScale);
            Controls.Add(xPos);
            Controls.Add(yScale);
            Controls.Add(labelScale);
            Controls.Add(zRot);
            Controls.Add(label5);
            Controls.Add(xScale);
            Controls.Add(labelPos);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(labelRot);
            Controls.Add(zPos);
            Controls.Add(yPos);
            Controls.Add(xRot);
            Controls.Add(yRot);
            Name = "SetupBounds";
            Size = new Size(400, 300);
            Load += SetupBounds_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label4;
        private Label label7;
        private Label label1;
        private TextBox weight;
        private TextBox xPos2;
        private TextBox zPos2;
        private TextBox yPos2;
        private ListBox secondaryPoints;
        private TextBox zScale;
        private TextBox xPos;
        private TextBox yScale;
        private Label labelScale;
        private TextBox zRot;
        private Label label5;
        private TextBox xScale;
        private Label labelPos;
        private Label label3;
        private Label label6;
        private Label labelRot;
        private TextBox zPos;
        private TextBox yPos;
        private TextBox xRot;
        private TextBox yRot;
    }
}

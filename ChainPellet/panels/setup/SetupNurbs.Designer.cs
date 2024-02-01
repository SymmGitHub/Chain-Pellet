namespace ChainPellet.panels.setup
{
    partial class SetupNurbs
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
            secondaryPoints = new ListBox();
            xPos2 = new TextBox();
            zPos2 = new TextBox();
            yPos2 = new TextBox();
            weight = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label7 = new Label();
            Unk1 = new TextBox();
            label8 = new Label();
            Unk2 = new TextBox();
            label9 = new Label();
            Unk3 = new TextBox();
            Unk5 = new TextBox();
            Unk4 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            knot = new TextBox();
            label13 = new Label();
            SuspendLayout();
            // 
            // zScale
            // 
            zScale.Location = new Point(178, 89);
            zScale.Name = "zScale";
            zScale.Size = new Size(70, 27);
            zScale.TabIndex = 61;
            zScale.TextChanged += OnNodeDataChanged;
            // 
            // xPos
            // 
            xPos.Location = new Point(26, 23);
            xPos.Name = "xPos";
            xPos.Size = new Size(70, 27);
            xPos.TabIndex = 53;
            xPos.TextChanged += OnNodeDataChanged;
            // 
            // yScale
            // 
            yScale.Location = new Point(178, 56);
            yScale.Name = "yScale";
            yScale.Size = new Size(70, 27);
            yScale.TabIndex = 60;
            yScale.TextChanged += OnNodeDataChanged;
            // 
            // labelScale
            // 
            labelScale.AutoSize = true;
            labelScale.ForeColor = SystemColors.Control;
            labelScale.Location = new Point(178, 0);
            labelScale.Name = "labelScale";
            labelScale.Size = new Size(44, 20);
            labelScale.TabIndex = 67;
            labelScale.Text = "Scale";
            // 
            // zRot
            // 
            zRot.Location = new Point(102, 89);
            zRot.Name = "zRot";
            zRot.Size = new Size(70, 27);
            zRot.TabIndex = 58;
            zRot.TextChanged += OnNodeDataChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(3, 59);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 63;
            label5.Text = "Y";
            // 
            // xScale
            // 
            xScale.Location = new Point(178, 23);
            xScale.Name = "xScale";
            xScale.Size = new Size(70, 27);
            xScale.TabIndex = 59;
            xScale.TextChanged += OnNodeDataChanged;
            // 
            // labelPos
            // 
            labelPos.AutoSize = true;
            labelPos.ForeColor = SystemColors.Control;
            labelPos.Location = new Point(26, 0);
            labelPos.Name = "labelPos";
            labelPos.Size = new Size(61, 20);
            labelPos.TabIndex = 65;
            labelPos.Text = "Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(3, 26);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 62;
            label3.Text = "X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(3, 92);
            label6.Name = "label6";
            label6.Size = new Size(18, 20);
            label6.TabIndex = 64;
            label6.Text = "Z";
            // 
            // labelRot
            // 
            labelRot.AutoSize = true;
            labelRot.ForeColor = SystemColors.Control;
            labelRot.Location = new Point(102, 0);
            labelRot.Name = "labelRot";
            labelRot.Size = new Size(66, 20);
            labelRot.TabIndex = 66;
            labelRot.Text = "Rotation";
            // 
            // zPos
            // 
            zPos.Location = new Point(26, 89);
            zPos.Name = "zPos";
            zPos.Size = new Size(70, 27);
            zPos.TabIndex = 55;
            zPos.TextChanged += OnNodeDataChanged;
            // 
            // yPos
            // 
            yPos.Location = new Point(26, 56);
            yPos.Name = "yPos";
            yPos.Size = new Size(70, 27);
            yPos.TabIndex = 54;
            yPos.TextChanged += OnNodeDataChanged;
            // 
            // xRot
            // 
            xRot.Location = new Point(102, 23);
            xRot.Name = "xRot";
            xRot.Size = new Size(70, 27);
            xRot.TabIndex = 56;
            xRot.TextChanged += OnNodeDataChanged;
            // 
            // yRot
            // 
            yRot.Location = new Point(102, 56);
            yRot.Name = "yRot";
            yRot.Size = new Size(70, 27);
            yRot.TabIndex = 57;
            yRot.TextChanged += OnNodeDataChanged;
            // 
            // secondaryPoints
            // 
            secondaryPoints.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            secondaryPoints.BackColor = Color.FromArgb(32, 32, 50);
            secondaryPoints.ForeColor = SystemColors.Control;
            secondaryPoints.FormattingEnabled = true;
            secondaryPoints.ItemHeight = 20;
            secondaryPoints.Location = new Point(254, 3);
            secondaryPoints.Name = "secondaryPoints";
            secondaryPoints.Size = new Size(142, 124);
            secondaryPoints.TabIndex = 38;
            secondaryPoints.SelectedIndexChanged += secondaryPoints_SelectedIndexChanged;
            // 
            // xPos2
            // 
            xPos2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            xPos2.BackColor = Color.FromArgb(200, 200, 255);
            xPos2.Location = new Point(316, 168);
            xPos2.Name = "xPos2";
            xPos2.Size = new Size(80, 27);
            xPos2.TabIndex = 68;
            xPos2.TextChanged += OnSecondaryDataChanged;
            // 
            // zPos2
            // 
            zPos2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            zPos2.BackColor = Color.FromArgb(200, 200, 255);
            zPos2.Location = new Point(316, 234);
            zPos2.Name = "zPos2";
            zPos2.Size = new Size(80, 27);
            zPos2.TabIndex = 70;
            zPos2.TextChanged += OnSecondaryDataChanged;
            // 
            // yPos2
            // 
            yPos2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            yPos2.BackColor = Color.FromArgb(200, 200, 255);
            yPos2.Location = new Point(316, 201);
            yPos2.Name = "yPos2";
            yPos2.Size = new Size(80, 27);
            yPos2.TabIndex = 69;
            yPos2.TextChanged += OnSecondaryDataChanged;
            // 
            // weight
            // 
            weight.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            weight.BackColor = Color.FromArgb(200, 200, 255);
            weight.Location = new Point(316, 135);
            weight.Name = "weight";
            weight.Size = new Size(80, 27);
            weight.TabIndex = 71;
            weight.TextChanged += OnSecondaryDataChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(254, 138);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 72;
            label1.Text = "Weight";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(267, 204);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 74;
            label2.Text = "Y Pos";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(266, 171);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 73;
            label4.Text = "X Pos";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(266, 237);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 75;
            label7.Text = "Z Pos";
            // 
            // Unk1
            // 
            Unk1.Location = new Point(26, 158);
            Unk1.Name = "Unk1";
            Unk1.Size = new Size(108, 27);
            Unk1.TabIndex = 76;
            Unk1.TextChanged += OnNodeDataChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(26, 135);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 77;
            label8.Text = "Unknown 1";
            // 
            // Unk2
            // 
            Unk2.Location = new Point(140, 158);
            Unk2.Name = "Unk2";
            Unk2.Size = new Size(108, 27);
            Unk2.TabIndex = 78;
            Unk2.TextChanged += OnNodeDataChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(140, 135);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 79;
            label9.Text = "Unknown 2";
            // 
            // Unk3
            // 
            Unk3.Location = new Point(26, 215);
            Unk3.Name = "Unk3";
            Unk3.Size = new Size(70, 27);
            Unk3.TabIndex = 80;
            Unk3.TextChanged += OnNodeDataChanged;
            // 
            // Unk5
            // 
            Unk5.Location = new Point(178, 215);
            Unk5.Name = "Unk5";
            Unk5.Size = new Size(70, 27);
            Unk5.TabIndex = 82;
            Unk5.TextChanged += OnNodeDataChanged;
            // 
            // Unk4
            // 
            Unk4.Location = new Point(102, 215);
            Unk4.Name = "Unk4";
            Unk4.Size = new Size(70, 27);
            Unk4.TabIndex = 81;
            Unk4.TextChanged += OnNodeDataChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(178, 192);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 85;
            label10.Text = "Unk. 5";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(26, 192);
            label11.Name = "label11";
            label11.Size = new Size(49, 20);
            label11.TabIndex = 83;
            label11.Text = "Unk. 3";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(102, 192);
            label12.Name = "label12";
            label12.Size = new Size(49, 20);
            label12.TabIndex = 84;
            label12.Text = "Unk. 4";
            // 
            // knot
            // 
            knot.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            knot.BackColor = Color.FromArgb(200, 200, 255);
            knot.Location = new Point(316, 267);
            knot.Name = "knot";
            knot.Size = new Size(80, 27);
            knot.TabIndex = 86;
            knot.TextChanged += OnSecondaryDataChanged;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(270, 270);
            label13.Name = "label13";
            label13.Size = new Size(40, 20);
            label13.TabIndex = 87;
            label13.Text = "Knot";
            // 
            // SetupNurbs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 68);
            Controls.Add(label13);
            Controls.Add(knot);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(Unk3);
            Controls.Add(Unk5);
            Controls.Add(Unk4);
            Controls.Add(label9);
            Controls.Add(Unk2);
            Controls.Add(label8);
            Controls.Add(Unk1);
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
            ForeColor = SystemColors.ControlText;
            Name = "SetupNurbs";
            Size = new Size(400, 300);
            Load += SetupNurbs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private ListBox secondaryPoints;
        private TextBox xPos2;
        private TextBox zPos2;
        private TextBox yPos2;
        private TextBox weight;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label7;
        private TextBox Unk1;
        private Label label8;
        private TextBox Unk2;
        private Label label9;
        private TextBox Unk3;
        private TextBox Unk5;
        private TextBox Unk4;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox knot;
        private Label label13;
    }
}

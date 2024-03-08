namespace ChainPellet.panels.sf
{
    partial class BoundsEditor
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
            wMax = new TextBox();
            wMin = new TextBox();
            label10 = new Label();
            xMin = new TextBox();
            zMax = new TextBox();
            label7 = new Label();
            labelMin = new Label();
            label8 = new Label();
            label9 = new Label();
            labelMax = new Label();
            zMin = new TextBox();
            yMin = new TextBox();
            xMax = new TextBox();
            yMax = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // wMax
            // 
            wMax.Location = new Point(198, 147);
            wMax.Name = "wMax";
            wMax.Size = new Size(140, 27);
            wMax.TabIndex = 84;
            wMax.TextChanged += BoundDataEdited;
            // 
            // wMin
            // 
            wMin.Location = new Point(52, 147);
            wMin.Name = "wMin";
            wMin.Size = new Size(140, 27);
            wMin.TabIndex = 83;
            wMin.TextChanged += BoundDataEdited;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(28, 150);
            label10.Name = "label10";
            label10.Size = new Size(23, 20);
            label10.TabIndex = 82;
            label10.Text = "W";
            // 
            // xMin
            // 
            xMin.Location = new Point(52, 48);
            xMin.Name = "xMin";
            xMin.Size = new Size(140, 27);
            xMin.TabIndex = 71;
            xMin.TextChanged += BoundDataEdited;
            // 
            // zMax
            // 
            zMax.Location = new Point(198, 114);
            zMax.Name = "zMax";
            zMax.Size = new Size(140, 27);
            zMax.TabIndex = 76;
            zMax.TextChanged += BoundDataEdited;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(28, 84);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 78;
            label7.Text = "Y";
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.ForeColor = SystemColors.Control;
            labelMin.Location = new Point(52, 25);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(72, 20);
            labelMin.TabIndex = 80;
            labelMin.Text = "Minimum";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(28, 51);
            label8.Name = "label8";
            label8.Size = new Size(18, 20);
            label8.TabIndex = 77;
            label8.Text = "X";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(28, 117);
            label9.Name = "label9";
            label9.Size = new Size(18, 20);
            label9.TabIndex = 79;
            label9.Text = "Z";
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.ForeColor = SystemColors.Control;
            labelMax.Location = new Point(198, 25);
            labelMax.Name = "labelMax";
            labelMax.Size = new Size(75, 20);
            labelMax.TabIndex = 81;
            labelMax.Text = "Maximum";
            // 
            // zMin
            // 
            zMin.Location = new Point(52, 114);
            zMin.Name = "zMin";
            zMin.Size = new Size(140, 27);
            zMin.TabIndex = 73;
            zMin.TextChanged += BoundDataEdited;
            // 
            // yMin
            // 
            yMin.Location = new Point(52, 81);
            yMin.Name = "yMin";
            yMin.Size = new Size(140, 27);
            yMin.TabIndex = 72;
            yMin.TextChanged += BoundDataEdited;
            // 
            // xMax
            // 
            xMax.Location = new Point(198, 48);
            xMax.Name = "xMax";
            xMax.Size = new Size(140, 27);
            xMax.TabIndex = 74;
            xMax.TextChanged += BoundDataEdited;
            // 
            // yMax
            // 
            yMax.Location = new Point(198, 81);
            yMax.Name = "yMax";
            yMax.Size = new Size(140, 27);
            yMax.TabIndex = 75;
            yMax.TextChanged += BoundDataEdited;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(23, 225);
            label1.Name = "label1";
            label1.Size = new Size(349, 75);
            label1.TabIndex = 85;
            label1.Text = "Edit the coordinates of the corners of this boundary box.\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BoundsEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 68);
            Controls.Add(label1);
            Controls.Add(wMax);
            Controls.Add(wMin);
            Controls.Add(label10);
            Controls.Add(xMin);
            Controls.Add(zMax);
            Controls.Add(label7);
            Controls.Add(labelMin);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(labelMax);
            Controls.Add(zMin);
            Controls.Add(yMin);
            Controls.Add(xMax);
            Controls.Add(yMax);
            Name = "BoundsEditor";
            Size = new Size(395, 300);
            Load += BoundsEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox wMax;
        private TextBox wMin;
        private Label label10;
        private TextBox xMin;
        private TextBox zMax;
        private Label label7;
        private Label labelMin;
        private Label label8;
        private Label label9;
        private Label labelMax;
        private TextBox zMin;
        private TextBox yMin;
        private TextBox xMax;
        private TextBox yMax;
        private Label label1;
    }
}

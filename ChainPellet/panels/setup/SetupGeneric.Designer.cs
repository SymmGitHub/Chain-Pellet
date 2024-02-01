namespace ChainPellet.panels.setup
{
    partial class SetupGeneric
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
            SuspendLayout();
            // 
            // zScale
            // 
            zScale.Location = new Point(246, 89);
            zScale.Name = "zScale";
            zScale.Size = new Size(80, 27);
            zScale.TabIndex = 46;
            zScale.TextChanged += OnNodeDataChanged;
            // 
            // xPos
            // 
            xPos.Location = new Point(74, 23);
            xPos.Name = "xPos";
            xPos.Size = new Size(80, 27);
            xPos.TabIndex = 38;
            xPos.TextChanged += OnNodeDataChanged;
            // 
            // yScale
            // 
            yScale.Location = new Point(246, 56);
            yScale.Name = "yScale";
            yScale.Size = new Size(80, 27);
            yScale.TabIndex = 45;
            yScale.TextChanged += OnNodeDataChanged;
            // 
            // labelScale
            // 
            labelScale.AutoSize = true;
            labelScale.ForeColor = SystemColors.Control;
            labelScale.Location = new Point(246, 0);
            labelScale.Name = "labelScale";
            labelScale.Size = new Size(44, 20);
            labelScale.TabIndex = 52;
            labelScale.Text = "Scale";
            // 
            // zRot
            // 
            zRot.Location = new Point(160, 89);
            zRot.Name = "zRot";
            zRot.Size = new Size(80, 27);
            zRot.TabIndex = 43;
            zRot.TextChanged += OnNodeDataChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(51, 59);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 48;
            label5.Text = "Y";
            // 
            // xScale
            // 
            xScale.Location = new Point(246, 23);
            xScale.Name = "xScale";
            xScale.Size = new Size(80, 27);
            xScale.TabIndex = 44;
            xScale.TextChanged += OnNodeDataChanged;
            // 
            // labelPos
            // 
            labelPos.AutoSize = true;
            labelPos.ForeColor = SystemColors.Control;
            labelPos.Location = new Point(74, 0);
            labelPos.Name = "labelPos";
            labelPos.Size = new Size(61, 20);
            labelPos.TabIndex = 50;
            labelPos.Text = "Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(51, 26);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 47;
            label3.Text = "X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(51, 92);
            label6.Name = "label6";
            label6.Size = new Size(18, 20);
            label6.TabIndex = 49;
            label6.Text = "Z";
            // 
            // labelRot
            // 
            labelRot.AutoSize = true;
            labelRot.ForeColor = SystemColors.Control;
            labelRot.Location = new Point(160, 0);
            labelRot.Name = "labelRot";
            labelRot.Size = new Size(66, 20);
            labelRot.TabIndex = 51;
            labelRot.Text = "Rotation";
            // 
            // zPos
            // 
            zPos.Location = new Point(74, 89);
            zPos.Name = "zPos";
            zPos.Size = new Size(80, 27);
            zPos.TabIndex = 40;
            zPos.TextChanged += OnNodeDataChanged;
            // 
            // yPos
            // 
            yPos.Location = new Point(74, 56);
            yPos.Name = "yPos";
            yPos.Size = new Size(80, 27);
            yPos.TabIndex = 39;
            yPos.TextChanged += OnNodeDataChanged;
            // 
            // xRot
            // 
            xRot.Location = new Point(160, 23);
            xRot.Name = "xRot";
            xRot.Size = new Size(80, 27);
            xRot.TabIndex = 41;
            xRot.TextChanged += OnNodeDataChanged;
            // 
            // yRot
            // 
            yRot.Location = new Point(160, 56);
            yRot.Name = "yRot";
            yRot.Size = new Size(80, 27);
            yRot.TabIndex = 42;
            yRot.TextChanged += OnNodeDataChanged;
            // 
            // SetupGeneric
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 68);
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
            Name = "SetupGeneric";
            Size = new Size(400, 300);
            Load += SetupGeneric_Load;
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
        private ComboBox comboBox1;
        private Label label1;
    }
}

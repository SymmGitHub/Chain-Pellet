namespace ChainPellet.panels.sf
{
    partial class CameraEditor
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
            label1 = new Label();
            xIn = new TextBox();
            yIn = new TextBox();
            zIn = new TextBox();
            label2 = new Label();
            fovBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(25, 35);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Interest";
            // 
            // xIn
            // 
            xIn.Location = new Point(89, 32);
            xIn.Name = "xIn";
            xIn.Size = new Size(78, 27);
            xIn.TabIndex = 1;
            xIn.TextChanged += CameraDataChanged;
            // 
            // yIn
            // 
            yIn.Location = new Point(173, 32);
            yIn.Name = "yIn";
            yIn.Size = new Size(78, 27);
            yIn.TabIndex = 2;
            yIn.TextChanged += CameraDataChanged;
            // 
            // zIn
            // 
            zIn.Location = new Point(257, 32);
            zIn.Name = "zIn";
            zIn.Size = new Size(78, 27);
            zIn.TabIndex = 3;
            zIn.TextChanged += CameraDataChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(25, 68);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 4;
            label2.Text = "FOV";
            // 
            // fovBox
            // 
            fovBox.Location = new Point(89, 65);
            fovBox.Name = "fovBox";
            fovBox.Size = new Size(78, 27);
            fovBox.TabIndex = 5;
            fovBox.TextChanged += CameraDataChanged;
            // 
            // CameraEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 68);
            Controls.Add(fovBox);
            Controls.Add(label2);
            Controls.Add(zIn);
            Controls.Add(yIn);
            Controls.Add(xIn);
            Controls.Add(label1);
            Name = "CameraEditor";
            Size = new Size(395, 300);
            Load += CameraEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox xIn;
        private TextBox yIn;
        private TextBox zIn;
        private Label label2;
        private TextBox fovBox;
    }
}

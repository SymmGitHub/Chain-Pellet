namespace ChainPellet.panels.sf
{
    partial class LightEditor
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
            colorBox = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            rBox = new TextBox();
            gBox = new TextBox();
            bBox = new TextBox();
            SuspendLayout();
            // 
            // colorBox
            // 
            colorBox.ForeColor = SystemColors.ControlText;
            colorBox.Location = new Point(40, 20);
            colorBox.Name = "colorBox";
            colorBox.Size = new Size(125, 125);
            colorBox.TabIndex = 0;
            colorBox.UseVisualStyleBackColor = true;
            colorBox.Click += colorBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 23);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 2;
            label1.Text = "Red";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 89);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 3;
            label2.Text = "Blue";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 56);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 4;
            label3.Text = "Green";
            // 
            // rBox
            // 
            rBox.Location = new Point(229, 20);
            rBox.Name = "rBox";
            rBox.Size = new Size(125, 27);
            rBox.TabIndex = 8;
            rBox.TextChanged += colorBoxesChanged;
            // 
            // gBox
            // 
            gBox.Location = new Point(229, 53);
            gBox.Name = "gBox";
            gBox.Size = new Size(125, 27);
            gBox.TabIndex = 9;
            gBox.TextChanged += colorBoxesChanged;
            // 
            // bBox
            // 
            bBox.Location = new Point(229, 86);
            bBox.Name = "bBox";
            bBox.Size = new Size(125, 27);
            bBox.TabIndex = 10;
            bBox.TextChanged += colorBoxesChanged;
            // 
            // LightEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 68);
            Controls.Add(bBox);
            Controls.Add(gBox);
            Controls.Add(rBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(colorBox);
            ForeColor = SystemColors.Control;
            Name = "LightEditor";
            Size = new Size(395, 300);
            Load += LightEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button colorBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox rBox;
        private TextBox gBox;
        private TextBox bBox;
    }
}

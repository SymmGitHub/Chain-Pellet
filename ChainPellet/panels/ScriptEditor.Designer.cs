namespace ChainPellet
{
    partial class ScriptEditor
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
            saveScript = new Button();
            TempRTB = new RichTextBox();
            ScriptRTB = new RichTextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 21;
            label1.Text = "Script Editor";
            // 
            // saveScript
            // 
            saveScript.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveScript.Location = new Point(454, 591);
            saveScript.Name = "saveScript";
            saveScript.Size = new Size(121, 36);
            saveScript.TabIndex = 20;
            saveScript.Text = "Save Script";
            saveScript.UseVisualStyleBackColor = true;
            saveScript.Click += saveScript_Click;
            // 
            // TempRTB
            // 
            TempRTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TempRTB.BackColor = Color.FromArgb(32, 32, 35);
            TempRTB.ForeColor = Color.White;
            TempRTB.Location = new Point(12, 596);
            TempRTB.Name = "TempRTB";
            TempRTB.Size = new Size(10, 10);
            TempRTB.TabIndex = 19;
            TempRTB.Text = "";
            TempRTB.Visible = false;
            TempRTB.WordWrap = false;
            // 
            // ScriptRTB
            // 
            ScriptRTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ScriptRTB.BackColor = Color.FromArgb(32, 32, 35);
            ScriptRTB.ForeColor = Color.White;
            ScriptRTB.Location = new Point(3, 24);
            ScriptRTB.Name = "ScriptRTB";
            ScriptRTB.Size = new Size(572, 561);
            ScriptRTB.TabIndex = 18;
            ScriptRTB.Text = "";
            ScriptRTB.WordWrap = false;
            ScriptRTB.TextChanged += UpdateRTBText;
            // 
            // ScriptEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 68);
            Controls.Add(label1);
            Controls.Add(saveScript);
            Controls.Add(TempRTB);
            Controls.Add(ScriptRTB);
            Name = "ScriptEditor";
            Size = new Size(578, 630);
            Load += ScriptEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button saveScript;
        private RichTextBox TempRTB;
        private RichTextBox ScriptRTB;
        private ToolTip toolTip1;
    }
}

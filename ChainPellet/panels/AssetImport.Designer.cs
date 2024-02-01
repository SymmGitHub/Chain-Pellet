namespace ChainPellet
{
    partial class AssetImport
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
            AssetHierarchy = new TreeView();
            label2 = new Label();
            ImportBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Import Objects";
            // 
            // AssetHierarchy
            // 
            AssetHierarchy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AssetHierarchy.BackColor = Color.FromArgb(32, 32, 35);
            AssetHierarchy.Location = new Point(3, 23);
            AssetHierarchy.Name = "AssetHierarchy";
            AssetHierarchy.Size = new Size(575, 558);
            AssetHierarchy.TabIndex = 1;
            AssetHierarchy.NodeMouseClick += AssetHierarchy_NodeMouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(3, 589);
            label2.Name = "label2";
            label2.Size = new Size(332, 20);
            label2.TabIndex = 2;
            label2.Text = "Shift + Left Click assets to select which to import.";
            // 
            // ImportBtn
            // 
            ImportBtn.Location = new Point(436, 584);
            ImportBtn.Name = "ImportBtn";
            ImportBtn.Size = new Size(139, 31);
            ImportBtn.TabIndex = 3;
            ImportBtn.Text = "Import";
            ImportBtn.UseVisualStyleBackColor = true;
            ImportBtn.Click += ImportBtn_Click;
            // 
            // AssetImport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 68);
            Controls.Add(ImportBtn);
            Controls.Add(label2);
            Controls.Add(AssetHierarchy);
            Controls.Add(label1);
            Name = "AssetImport";
            Size = new Size(578, 630);
            Load += AssetImport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TreeView AssetHierarchy;
        private Label label2;
        private Button ImportBtn;
    }
}

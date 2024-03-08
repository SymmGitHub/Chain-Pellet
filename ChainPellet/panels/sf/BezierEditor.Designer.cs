namespace ChainPellet.panels.sf
{
    partial class BezierEditor
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
            label2 = new Label();
            addPointBtn = new Button();
            controlPointList = new ListBox();
            label1 = new Label();
            knotList = new ListBox();
            xPos = new TextBox();
            addKnotBtn = new Button();
            label3 = new Label();
            yPos = new TextBox();
            zPos = new TextBox();
            wPos = new TextBox();
            knotBox = new TextBox();
            lengthBox = new TextBox();
            degreeBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            checkBox1 = new CheckBox();
            label10 = new Label();
            unkBox = new TextBox();
            controlPointListContext = new ContextMenuStrip(components);
            duplicateControlPointToolStripMenuItem = new ToolStripMenuItem();
            deleteControlPointToolStripMenuItem = new ToolStripMenuItem();
            reversePointOrderToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            copyPointPositionToolStripMenuItem = new ToolStripMenuItem();
            pastePointPositionToolStripMenuItem = new ToolStripMenuItem();
            knotListContext = new ContextMenuStrip(components);
            duplicateKnotToolStripMenuItem = new ToolStripMenuItem();
            deleteKnotToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            copyKnotToolStripMenuItem = new ToolStripMenuItem();
            pasteKnotToolStripMenuItem = new ToolStripMenuItem();
            controlPointListContext.SuspendLayout();
            knotListContext.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 8;
            label2.Text = "Control Points";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addPointBtn
            // 
            addPointBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addPointBtn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            addPointBtn.ForeColor = SystemColors.ControlText;
            addPointBtn.Location = new Point(3, 251);
            addPointBtn.Name = "addPointBtn";
            addPointBtn.Size = new Size(125, 30);
            addPointBtn.TabIndex = 6;
            addPointBtn.Text = "Add New Point";
            addPointBtn.UseVisualStyleBackColor = true;
            addPointBtn.Click += addPointBtn_Click;
            // 
            // controlPointList
            // 
            controlPointList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            controlPointList.BackColor = Color.FromArgb(32, 32, 35);
            controlPointList.ForeColor = SystemColors.Window;
            controlPointList.FormattingEnabled = true;
            controlPointList.ItemHeight = 20;
            controlPointList.Location = new Point(3, 21);
            controlPointList.Name = "controlPointList";
            controlPointList.Size = new Size(125, 224);
            controlPointList.TabIndex = 5;
            controlPointList.SelectedIndexChanged += controlPointList_SelectedIndexChanged;
            controlPointList.MouseDown += controlPointList_MouseDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(322, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 9;
            label1.Text = "Knots";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // knotList
            // 
            knotList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            knotList.BackColor = Color.FromArgb(32, 32, 50);
            knotList.ForeColor = SystemColors.Window;
            knotList.FormattingEnabled = true;
            knotList.ItemHeight = 20;
            knotList.Location = new Point(298, 21);
            knotList.Name = "knotList";
            knotList.Size = new Size(94, 224);
            knotList.TabIndex = 10;
            knotList.SelectedIndexChanged += knotList_SelectedIndexChanged;
            knotList.MouseDown += knotList_MouseDown;
            // 
            // xPos
            // 
            xPos.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            xPos.Location = new Point(179, 132);
            xPos.Name = "xPos";
            xPos.Size = new Size(113, 25);
            xPos.TabIndex = 11;
            xPos.TextChanged += controlPoint_TextChanged;
            // 
            // addKnotBtn
            // 
            addKnotBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addKnotBtn.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            addKnotBtn.ForeColor = SystemColors.ControlText;
            addKnotBtn.Location = new Point(298, 251);
            addKnotBtn.Name = "addKnotBtn";
            addKnotBtn.Size = new Size(94, 30);
            addKnotBtn.TabIndex = 12;
            addKnotBtn.Text = "Add Knot";
            addKnotBtn.UseVisualStyleBackColor = true;
            addKnotBtn.Click += addKnotBtn_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(135, 134);
            label3.Name = "label3";
            label3.Size = new Size(17, 19);
            label3.TabIndex = 14;
            label3.Text = "X";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yPos
            // 
            yPos.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            yPos.Location = new Point(179, 163);
            yPos.Name = "yPos";
            yPos.Size = new Size(113, 25);
            yPos.TabIndex = 16;
            yPos.TextChanged += controlPoint_TextChanged;
            // 
            // zPos
            // 
            zPos.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            zPos.Location = new Point(179, 194);
            zPos.Name = "zPos";
            zPos.Size = new Size(113, 25);
            zPos.TabIndex = 17;
            zPos.TextChanged += controlPoint_TextChanged;
            // 
            // wPos
            // 
            wPos.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            wPos.Location = new Point(179, 225);
            wPos.Name = "wPos";
            wPos.Size = new Size(113, 25);
            wPos.TabIndex = 18;
            wPos.TextChanged += controlPoint_TextChanged;
            // 
            // knotBox
            // 
            knotBox.BackColor = Color.FromArgb(200, 200, 255);
            knotBox.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            knotBox.Location = new Point(179, 256);
            knotBox.Name = "knotBox";
            knotBox.Size = new Size(113, 25);
            knotBox.TabIndex = 19;
            knotBox.TextChanged += knot_TextChanged;
            // 
            // lengthBox
            // 
            lengthBox.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lengthBox.Location = new Point(209, 9);
            lengthBox.Name = "lengthBox";
            lengthBox.Size = new Size(83, 25);
            lengthBox.TabIndex = 20;
            lengthBox.TextChanged += BezierDataChanged;
            // 
            // degreeBox
            // 
            degreeBox.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            degreeBox.Location = new Point(209, 40);
            degreeBox.Name = "degreeBox";
            degreeBox.Size = new Size(83, 25);
            degreeBox.TabIndex = 21;
            degreeBox.TextChanged += BezierDataChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(135, 165);
            label4.Name = "label4";
            label4.Size = new Size(17, 19);
            label4.TabIndex = 22;
            label4.Text = "Y";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(135, 196);
            label5.Name = "label5";
            label5.Size = new Size(17, 19);
            label5.TabIndex = 23;
            label5.Text = "Z";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(135, 227);
            label6.Name = "label6";
            label6.Size = new Size(22, 19);
            label6.TabIndex = 24;
            label6.Text = "W";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(135, 258);
            label7.Name = "label7";
            label7.Size = new Size(38, 19);
            label7.TabIndex = 25;
            label7.Text = "Knot";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(134, 11);
            label8.Name = "label8";
            label8.Size = new Size(52, 19);
            label8.TabIndex = 26;
            label8.Text = "Length";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(135, 42);
            label9.Name = "label9";
            label9.Size = new Size(53, 19);
            label9.TabIndex = 27;
            label9.Text = "Degree";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.Control;
            checkBox1.Location = new Point(166, 102);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(112, 23);
            checkBox1.TabIndex = 28;
            checkBox1.Text = "Closed Bezier";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += BezierDataChanged;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(135, 73);
            label10.Name = "label10";
            label10.Size = new Size(68, 19);
            label10.TabIndex = 30;
            label10.Text = "Unknown";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // unkBox
            // 
            unkBox.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            unkBox.Location = new Point(209, 71);
            unkBox.Name = "unkBox";
            unkBox.Size = new Size(83, 25);
            unkBox.TabIndex = 29;
            unkBox.TextChanged += BezierDataChanged;
            // 
            // controlPointListContext
            // 
            controlPointListContext.ImageScalingSize = new Size(20, 20);
            controlPointListContext.Items.AddRange(new ToolStripItem[] { duplicateControlPointToolStripMenuItem, deleteControlPointToolStripMenuItem, reversePointOrderToolStripMenuItem, toolStripSeparator1, copyPointPositionToolStripMenuItem, pastePointPositionToolStripMenuItem });
            controlPointListContext.Name = "contextControlPointList";
            controlPointListContext.Size = new Size(233, 158);
            // 
            // duplicateControlPointToolStripMenuItem
            // 
            duplicateControlPointToolStripMenuItem.Name = "duplicateControlPointToolStripMenuItem";
            duplicateControlPointToolStripMenuItem.Size = new Size(232, 24);
            duplicateControlPointToolStripMenuItem.Text = "Duplicate Control Point";
            duplicateControlPointToolStripMenuItem.Click += duplicateControlPointToolStripMenuItem_Click;
            // 
            // deleteControlPointToolStripMenuItem
            // 
            deleteControlPointToolStripMenuItem.Name = "deleteControlPointToolStripMenuItem";
            deleteControlPointToolStripMenuItem.Size = new Size(232, 24);
            deleteControlPointToolStripMenuItem.Text = "Delete Control Point";
            deleteControlPointToolStripMenuItem.Click += deleteControlPointToolStripMenuItem_Click;
            // 
            // reversePointOrderToolStripMenuItem
            // 
            reversePointOrderToolStripMenuItem.Name = "reversePointOrderToolStripMenuItem";
            reversePointOrderToolStripMenuItem.Size = new Size(232, 24);
            reversePointOrderToolStripMenuItem.Text = "Reverse Point Order";
            reversePointOrderToolStripMenuItem.Click += reversePointOrderToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(229, 6);
            // 
            // copyPointPositionToolStripMenuItem
            // 
            copyPointPositionToolStripMenuItem.Name = "copyPointPositionToolStripMenuItem";
            copyPointPositionToolStripMenuItem.Size = new Size(232, 24);
            copyPointPositionToolStripMenuItem.Text = "Copy Point Position";
            copyPointPositionToolStripMenuItem.Click += copyPointPositionToolStripMenuItem_Click;
            // 
            // pastePointPositionToolStripMenuItem
            // 
            pastePointPositionToolStripMenuItem.Name = "pastePointPositionToolStripMenuItem";
            pastePointPositionToolStripMenuItem.Size = new Size(232, 24);
            pastePointPositionToolStripMenuItem.Text = "Paste Point Position";
            pastePointPositionToolStripMenuItem.Click += pastePointPositionToolStripMenuItem_Click;
            // 
            // knotListContext
            // 
            knotListContext.ImageScalingSize = new Size(20, 20);
            knotListContext.Items.AddRange(new ToolStripItem[] { duplicateKnotToolStripMenuItem, deleteKnotToolStripMenuItem, toolStripSeparator2, copyKnotToolStripMenuItem, pasteKnotToolStripMenuItem });
            knotListContext.Name = "knotListContext";
            knotListContext.Size = new Size(178, 106);
            // 
            // duplicateKnotToolStripMenuItem
            // 
            duplicateKnotToolStripMenuItem.Name = "duplicateKnotToolStripMenuItem";
            duplicateKnotToolStripMenuItem.Size = new Size(177, 24);
            duplicateKnotToolStripMenuItem.Text = "Duplicate Knot";
            duplicateKnotToolStripMenuItem.Click += duplicateKnotToolStripMenuItem_Click;
            // 
            // deleteKnotToolStripMenuItem
            // 
            deleteKnotToolStripMenuItem.Name = "deleteKnotToolStripMenuItem";
            deleteKnotToolStripMenuItem.Size = new Size(177, 24);
            deleteKnotToolStripMenuItem.Text = "Delete Knot";
            deleteKnotToolStripMenuItem.Click += deleteKnotToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(174, 6);
            // 
            // copyKnotToolStripMenuItem
            // 
            copyKnotToolStripMenuItem.Name = "copyKnotToolStripMenuItem";
            copyKnotToolStripMenuItem.Size = new Size(177, 24);
            copyKnotToolStripMenuItem.Text = "Copy Knot";
            copyKnotToolStripMenuItem.Click += copyKnotToolStripMenuItem_Click;
            // 
            // pasteKnotToolStripMenuItem
            // 
            pasteKnotToolStripMenuItem.Name = "pasteKnotToolStripMenuItem";
            pasteKnotToolStripMenuItem.Size = new Size(177, 24);
            pasteKnotToolStripMenuItem.Text = "Paste Knot";
            pasteKnotToolStripMenuItem.Click += pasteKnotToolStripMenuItem_Click;
            // 
            // BezierEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 68);
            Controls.Add(label10);
            Controls.Add(unkBox);
            Controls.Add(checkBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(degreeBox);
            Controls.Add(lengthBox);
            Controls.Add(knotBox);
            Controls.Add(wPos);
            Controls.Add(zPos);
            Controls.Add(yPos);
            Controls.Add(label3);
            Controls.Add(addKnotBtn);
            Controls.Add(xPos);
            Controls.Add(knotList);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(addPointBtn);
            Controls.Add(controlPointList);
            Name = "BezierEditor";
            Size = new Size(395, 300);
            Load += BezierEditor_Load;
            controlPointListContext.ResumeLayout(false);
            knotListContext.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button addPointBtn;
        private ListBox controlPointList;
        private Label label1;
        private ListBox knotList;
        private TextBox xPos;
        private Button addKnotBtn;
        private Label label3;
        private TextBox yPos;
        private TextBox zPos;
        private TextBox wPos;
        private TextBox knotBox;
        private TextBox lengthBox;
        private TextBox degreeBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private CheckBox checkBox1;
        private Label label10;
        private TextBox unkBox;
        private ContextMenuStrip controlPointListContext;
        private ToolStripMenuItem copyPointPositionToolStripMenuItem;
        private ToolStripMenuItem pastePointPositionToolStripMenuItem;
        private ToolStripMenuItem reversePointOrderToolStripMenuItem;
        private ToolStripMenuItem deleteControlPointToolStripMenuItem;
        private ToolStripMenuItem duplicateControlPointToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ContextMenuStrip knotListContext;
        private ToolStripMenuItem duplicateKnotToolStripMenuItem;
        private ToolStripMenuItem deleteKnotToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem copyKnotToolStripMenuItem;
        private ToolStripMenuItem pasteKnotToolStripMenuItem;
    }
}

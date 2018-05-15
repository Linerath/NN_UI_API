namespace Neural_Network_WF__Graduate_Work_.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromDatabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTraining = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BViewEdit = new System.Windows.Forms.Button();
            this.BPractice = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LType1 = new System.Windows.Forms.Label();
            this.LCreationDate1 = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.LType0 = new System.Windows.Forms.Label();
            this.LCreationDate0 = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(830, 28);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadFromFileToolStripMenuItem,
            this.loadFromDatabToolStripMenuItem,
            this.saveToFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fileToolStripMenuItem.Text = "Net";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            this.loadFromFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadFromFileToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.loadFromFileToolStripMenuItem.Text = "Load from file";
            // 
            // loadFromDatabToolStripMenuItem
            // 
            this.loadFromDatabToolStripMenuItem.Name = "loadFromDatabToolStripMenuItem";
            this.loadFromDatabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.O)));
            this.loadFromDatabToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.loadFromDatabToolStripMenuItem.Text = "Load from database";
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.saveToFileToolStripMenuItem.Text = "Save to file";
            // 
            // BTraining
            // 
            this.BTraining.Enabled = false;
            this.BTraining.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTraining.Location = new System.Drawing.Point(493, 47);
            this.BTraining.Name = "BTraining";
            this.BTraining.Size = new System.Drawing.Size(148, 72);
            this.BTraining.TabIndex = 5;
            this.BTraining.Text = "Training";
            this.BTraining.UseVisualStyleBackColor = true;
            this.BTraining.Click += new System.EventHandler(this.BTraining_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.BViewEdit);
            this.groupBox3.Controls.Add(this.BPractice);
            this.groupBox3.Controls.Add(this.BTraining);
            this.groupBox3.Location = new System.Drawing.Point(12, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(806, 161);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // BViewEdit
            // 
            this.BViewEdit.Enabled = false;
            this.BViewEdit.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BViewEdit.Location = new System.Drawing.Point(155, 47);
            this.BViewEdit.Name = "BViewEdit";
            this.BViewEdit.Size = new System.Drawing.Size(148, 72);
            this.BViewEdit.TabIndex = 3;
            this.BViewEdit.Text = "View/Edit";
            this.BViewEdit.UseVisualStyleBackColor = true;
            this.BViewEdit.Click += new System.EventHandler(this.BViewEdit_Click);
            // 
            // BPractice
            // 
            this.BPractice.Enabled = false;
            this.BPractice.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPractice.Location = new System.Drawing.Point(324, 47);
            this.BPractice.Name = "BPractice";
            this.BPractice.Size = new System.Drawing.Size(148, 72);
            this.BPractice.TabIndex = 4;
            this.BPractice.Text = "Practice";
            this.BPractice.UseVisualStyleBackColor = true;
            this.BPractice.Click += new System.EventHandler(this.BPractice_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(420, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 185);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.LType1);
            this.groupBox1.Controls.Add(this.LCreationDate1);
            this.groupBox1.Controls.Add(this.TBName);
            this.groupBox1.Controls.Add(this.LType0);
            this.groupBox1.Controls.Add(this.LCreationDate0);
            this.groupBox1.Controls.Add(this.LName);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 185);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // LType1
            // 
            this.LType1.AutoSize = true;
            this.LType1.ForeColor = System.Drawing.Color.Red;
            this.LType1.Location = new System.Drawing.Point(66, 104);
            this.LType1.Name = "LType1";
            this.LType1.Size = new System.Drawing.Size(0, 20);
            this.LType1.TabIndex = 6;
            // 
            // LCreationDate1
            // 
            this.LCreationDate1.AutoSize = true;
            this.LCreationDate1.ForeColor = System.Drawing.Color.Red;
            this.LCreationDate1.Location = new System.Drawing.Point(161, 73);
            this.LCreationDate1.Name = "LCreationDate1";
            this.LCreationDate1.Size = new System.Drawing.Size(0, 20);
            this.LCreationDate1.TabIndex = 5;
            // 
            // TBName
            // 
            this.TBName.Enabled = false;
            this.TBName.ForeColor = System.Drawing.Color.Red;
            this.TBName.Location = new System.Drawing.Point(66, 40);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(202, 27);
            this.TBName.TabIndex = 4;
            // 
            // LType0
            // 
            this.LType0.AutoSize = true;
            this.LType0.Location = new System.Drawing.Point(6, 104);
            this.LType0.Name = "LType0";
            this.LType0.Size = new System.Drawing.Size(54, 20);
            this.LType0.TabIndex = 3;
            this.LType0.Text = "Type:";
            // 
            // LCreationDate0
            // 
            this.LCreationDate0.AutoSize = true;
            this.LCreationDate0.Location = new System.Drawing.Point(6, 73);
            this.LCreationDate0.Name = "LCreationDate0";
            this.LCreationDate0.Size = new System.Drawing.Size(135, 20);
            this.LCreationDate0.TabIndex = 2;
            this.LCreationDate0.Text = "Creation date:";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(6, 43);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(54, 20);
            this.LName.TabIndex = 1;
            this.LName.Text = "Name:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 407);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neural Network";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromDatabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.Button BTraining;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LType0;
        private System.Windows.Forms.Label LCreationDate0;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Button BPractice;
        private System.Windows.Forms.Button BViewEdit;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Label LType1;
        private System.Windows.Forms.Label LCreationDate1;
    }
}


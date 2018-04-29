namespace NeuralNetwork_UI.Forms
{
    partial class MainMenuForm
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
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BNew = new System.Windows.Forms.Button();
            this.GBFile = new System.Windows.Forms.GroupBox();
            this.BOpen = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.GBFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.AccessibleDescription = "";
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1255, 28);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // BNew
            // 
            this.BNew.Location = new System.Drawing.Point(6, 21);
            this.BNew.Name = "BNew";
            this.BNew.Size = new System.Drawing.Size(44, 38);
            this.BNew.TabIndex = 1;
            this.BNew.Text = "N";
            this.BNew.UseVisualStyleBackColor = true;
            this.BNew.Click += new System.EventHandler(this.BNew_Click);
            // 
            // GBFile
            // 
            this.GBFile.Controls.Add(this.button3);
            this.GBFile.Controls.Add(this.BOpen);
            this.GBFile.Controls.Add(this.BNew);
            this.GBFile.Location = new System.Drawing.Point(12, 31);
            this.GBFile.Name = "GBFile";
            this.GBFile.Size = new System.Drawing.Size(245, 72);
            this.GBFile.TabIndex = 2;
            this.GBFile.TabStop = false;
            // 
            // BOpen
            // 
            this.BOpen.Location = new System.Drawing.Point(56, 21);
            this.BOpen.Name = "BOpen";
            this.BOpen.Size = new System.Drawing.Size(44, 38);
            this.BOpen.TabIndex = 2;
            this.BOpen.Text = "O";
            this.BOpen.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(106, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "S";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 122);
            this.Controls.Add(this.GBFile);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.Click += new System.EventHandler(this.MainMenuForm_Click);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.GBFile.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.Button BNew;
        private System.Windows.Forms.GroupBox GBFile;
        private System.Windows.Forms.Button BOpen;
        private System.Windows.Forms.Button button3;
    }
}
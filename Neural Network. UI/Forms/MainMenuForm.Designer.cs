namespace Neural_Network.UI.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BNewNetwork = new System.Windows.Forms.Button();
            this.GBNetwork = new System.Windows.Forms.GroupBox();
            this.GBTraining = new System.Windows.Forms.GroupBox();
            this.BTraining = new System.Windows.Forms.Button();
            this.BProduction = new System.Windows.Forms.Button();
            this.GBProj = new System.Windows.Forms.GroupBox();
            this.BSaveProjAs = new System.Windows.Forms.Button();
            this.BSaveProj = new System.Windows.Forms.Button();
            this.BOpenProj = new System.Windows.Forms.Button();
            this.BNewProj = new System.Windows.Forms.Button();
            this.GBProduction = new System.Windows.Forms.GroupBox();
            this.MainMenu.SuspendLayout();
            this.GBNetwork.SuspendLayout();
            this.GBTraining.SuspendLayout();
            this.GBProj.SuspendLayout();
            this.GBProduction.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.AccessibleDescription = "";
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(428, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openProjToolStripMenuItem,
            this.saveProjToolStripMenuItem,
            this.saveProjAsToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // openProjToolStripMenuItem
            // 
            this.openProjToolStripMenuItem.Name = "openProjToolStripMenuItem";
            this.openProjToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openProjToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.openProjToolStripMenuItem.Text = "Open...";
            this.openProjToolStripMenuItem.Click += new System.EventHandler(this.openProjToolStripMenuItem_Click);
            // 
            // saveProjToolStripMenuItem
            // 
            this.saveProjToolStripMenuItem.Name = "saveProjToolStripMenuItem";
            this.saveProjToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveProjToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveProjToolStripMenuItem.Text = "Save";
            this.saveProjToolStripMenuItem.Click += new System.EventHandler(this.saveProjToolStripMenuItem_Click);
            // 
            // saveProjAsToolStripMenuItem
            // 
            this.saveProjAsToolStripMenuItem.Name = "saveProjAsToolStripMenuItem";
            this.saveProjAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveProjAsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveProjAsToolStripMenuItem.Text = "Save as...";
            this.saveProjAsToolStripMenuItem.Click += new System.EventHandler(this.saveProjAsToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.networkExplorerToolStripMenuItem,
            this.viewSettingsToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // networkExplorerToolStripMenuItem
            // 
            this.networkExplorerToolStripMenuItem.Name = "networkExplorerToolStripMenuItem";
            this.networkExplorerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.networkExplorerToolStripMenuItem.Text = "Network explorer";
            this.networkExplorerToolStripMenuItem.Click += new System.EventHandler(this.networkExplorerToolStripMenuItem_Click);
            // 
            // viewSettingsToolStripMenuItem
            // 
            this.viewSettingsToolStripMenuItem.Name = "viewSettingsToolStripMenuItem";
            this.viewSettingsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.viewSettingsToolStripMenuItem.Text = "View settings";
            this.viewSettingsToolStripMenuItem.Click += new System.EventHandler(this.viewSettingsToolStripMenuItem_Click);
            // 
            // BNewNetwork
            // 
            this.BNewNetwork.BackColor = System.Drawing.Color.Transparent;
            this.BNewNetwork.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BNewNetwork.BackgroundImage")));
            this.BNewNetwork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BNewNetwork.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.BNewNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.BNewNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNewNetwork.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNewNetwork.Location = new System.Drawing.Point(30, 20);
            this.BNewNetwork.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BNewNetwork.Name = "BNewNetwork";
            this.BNewNetwork.Size = new System.Drawing.Size(30, 28);
            this.BNewNetwork.TabIndex = 1;
            this.BNewNetwork.UseVisualStyleBackColor = false;
            this.BNewNetwork.Click += new System.EventHandler(this.BNewNetwork_Click);
            // 
            // GBNetwork
            // 
            this.GBNetwork.Controls.Add(this.BNewNetwork);
            this.GBNetwork.Location = new System.Drawing.Point(175, 25);
            this.GBNetwork.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBNetwork.Name = "GBNetwork";
            this.GBNetwork.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBNetwork.Size = new System.Drawing.Size(94, 58);
            this.GBNetwork.TabIndex = 2;
            this.GBNetwork.TabStop = false;
            this.GBNetwork.Text = "Neural network";
            // 
            // GBTraining
            // 
            this.GBTraining.Controls.Add(this.BTraining);
            this.GBTraining.Location = new System.Drawing.Point(349, 25);
            this.GBTraining.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBTraining.Name = "GBTraining";
            this.GBTraining.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBTraining.Size = new System.Drawing.Size(63, 58);
            this.GBTraining.TabIndex = 5;
            this.GBTraining.TabStop = false;
            this.GBTraining.Text = "Training";
            // 
            // BTraining
            // 
            this.BTraining.BackColor = System.Drawing.Color.Transparent;
            this.BTraining.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTraining.BackgroundImage")));
            this.BTraining.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTraining.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.BTraining.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.BTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTraining.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTraining.Location = new System.Drawing.Point(16, 20);
            this.BTraining.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTraining.Name = "BTraining";
            this.BTraining.Size = new System.Drawing.Size(30, 28);
            this.BTraining.TabIndex = 4;
            this.BTraining.UseVisualStyleBackColor = false;
            this.BTraining.Click += new System.EventHandler(this.BTraining_Click);
            // 
            // BProduction
            // 
            this.BProduction.BackColor = System.Drawing.Color.Transparent;
            this.BProduction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BProduction.BackgroundImage")));
            this.BProduction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BProduction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.BProduction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.BProduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BProduction.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BProduction.Location = new System.Drawing.Point(20, 20);
            this.BProduction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BProduction.Name = "BProduction";
            this.BProduction.Size = new System.Drawing.Size(30, 28);
            this.BProduction.TabIndex = 5;
            this.BProduction.UseVisualStyleBackColor = false;
            this.BProduction.Click += new System.EventHandler(this.BProduction_Click);
            // 
            // GBProj
            // 
            this.GBProj.Controls.Add(this.BSaveProjAs);
            this.GBProj.Controls.Add(this.BSaveProj);
            this.GBProj.Controls.Add(this.BOpenProj);
            this.GBProj.Controls.Add(this.BNewProj);
            this.GBProj.Location = new System.Drawing.Point(9, 25);
            this.GBProj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBProj.Name = "GBProj";
            this.GBProj.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBProj.Size = new System.Drawing.Size(161, 58);
            this.GBProj.TabIndex = 3;
            this.GBProj.TabStop = false;
            this.GBProj.Text = "Project";
            // 
            // BSaveProjAs
            // 
            this.BSaveProjAs.BackColor = System.Drawing.Color.Transparent;
            this.BSaveProjAs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BSaveProjAs.BackgroundImage")));
            this.BSaveProjAs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BSaveProjAs.FlatAppearance.BorderSize = 0;
            this.BSaveProjAs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.BSaveProjAs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.BSaveProjAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSaveProjAs.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.BSaveProjAs.Location = new System.Drawing.Point(115, 20);
            this.BSaveProjAs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BSaveProjAs.Name = "BSaveProjAs";
            this.BSaveProjAs.Size = new System.Drawing.Size(30, 28);
            this.BSaveProjAs.TabIndex = 4;
            this.BSaveProjAs.UseVisualStyleBackColor = false;
            this.BSaveProjAs.Click += new System.EventHandler(this.BSaveProjAs_Click);
            // 
            // BSaveProj
            // 
            this.BSaveProj.BackColor = System.Drawing.Color.Transparent;
            this.BSaveProj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BSaveProj.BackgroundImage")));
            this.BSaveProj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BSaveProj.FlatAppearance.BorderSize = 0;
            this.BSaveProj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.BSaveProj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.BSaveProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSaveProj.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.BSaveProj.Location = new System.Drawing.Point(80, 20);
            this.BSaveProj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BSaveProj.Name = "BSaveProj";
            this.BSaveProj.Size = new System.Drawing.Size(30, 28);
            this.BSaveProj.TabIndex = 3;
            this.BSaveProj.UseVisualStyleBackColor = false;
            this.BSaveProj.Click += new System.EventHandler(this.BSaveProj_Click);
            // 
            // BOpenProj
            // 
            this.BOpenProj.BackColor = System.Drawing.Color.Yellow;
            this.BOpenProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOpenProj.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.BOpenProj.Location = new System.Drawing.Point(46, 20);
            this.BOpenProj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BOpenProj.Name = "BOpenProj";
            this.BOpenProj.Size = new System.Drawing.Size(30, 28);
            this.BOpenProj.TabIndex = 2;
            this.BOpenProj.Text = "O";
            this.BOpenProj.UseVisualStyleBackColor = false;
            this.BOpenProj.Click += new System.EventHandler(this.BOpenProj_Click);
            // 
            // BNewProj
            // 
            this.BNewProj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BNewProj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BNewProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNewProj.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNewProj.Location = new System.Drawing.Point(11, 20);
            this.BNewProj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BNewProj.Name = "BNewProj";
            this.BNewProj.Size = new System.Drawing.Size(30, 28);
            this.BNewProj.TabIndex = 1;
            this.BNewProj.Text = "N";
            this.BNewProj.UseVisualStyleBackColor = false;
            this.BNewProj.Click += new System.EventHandler(this.BNewProj_Click);
            // 
            // GBProduction
            // 
            this.GBProduction.Controls.Add(this.BProduction);
            this.GBProduction.Location = new System.Drawing.Point(273, 25);
            this.GBProduction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBProduction.Name = "GBProduction";
            this.GBProduction.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBProduction.Size = new System.Drawing.Size(72, 58);
            this.GBProduction.TabIndex = 6;
            this.GBProduction.TabStop = false;
            this.GBProduction.Text = "Production";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 99);
            this.Controls.Add(this.GBProduction);
            this.Controls.Add(this.GBProj);
            this.Controls.Add(this.GBTraining);
            this.Controls.Add(this.GBNetwork);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.GBNetwork.ResumeLayout(false);
            this.GBTraining.ResumeLayout(false);
            this.GBProj.ResumeLayout(false);
            this.GBProduction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.GroupBox GBNetwork;
        private System.Windows.Forms.Button BNewNetwork;
        private System.Windows.Forms.ToolStripMenuItem openProjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjAsToolStripMenuItem;
        private System.Windows.Forms.GroupBox GBTraining;
        private System.Windows.Forms.GroupBox GBProj;
        private System.Windows.Forms.Button BOpenProj;
        private System.Windows.Forms.Button BNewProj;
        private System.Windows.Forms.Button BSaveProjAs;
        private System.Windows.Forms.Button BSaveProj;
        private System.Windows.Forms.ToolStripMenuItem networkExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSettingsToolStripMenuItem;
        private System.Windows.Forms.Button BProduction;
        private System.Windows.Forms.Button BTraining;
        private System.Windows.Forms.GroupBox GBProduction;
    }
}
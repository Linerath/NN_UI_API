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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BNewNetwork = new System.Windows.Forms.Button();
            this.GBNetwork = new System.Windows.Forms.GroupBox();
            this.BOpenNetwork = new System.Windows.Forms.Button();
            this.BGetResponse = new System.Windows.Forms.Button();
            this.GBInputProj = new System.Windows.Forms.GroupBox();
            this.BOpenInputProj = new System.Windows.Forms.Button();
            this.BNewInputProj = new System.Windows.Forms.Button();
            this.BTrainingMode = new System.Windows.Forms.Button();
            this.GBActions = new System.Windows.Forms.GroupBox();
            this.GBProj = new System.Windows.Forms.GroupBox();
            this.BSaveProjAs = new System.Windows.Forms.Button();
            this.BSaveProj = new System.Windows.Forms.Button();
            this.BOpenProj = new System.Windows.Forms.Button();
            this.BNewProj = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.GBNetwork.SuspendLayout();
            this.GBInputProj.SuspendLayout();
            this.GBActions.SuspendLayout();
            this.GBProj.SuspendLayout();
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
            this.MainMenu.Size = new System.Drawing.Size(1348, 28);
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
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openProjToolStripMenuItem,
            this.saveProjToolStripMenuItem,
            this.saveProjAsToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // openProjToolStripMenuItem
            // 
            this.openProjToolStripMenuItem.Name = "openProjToolStripMenuItem";
            this.openProjToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openProjToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.openProjToolStripMenuItem.Text = "Open...";
            this.openProjToolStripMenuItem.Click += new System.EventHandler(this.openProjToolStripMenuItem_Click);
            // 
            // saveProjToolStripMenuItem
            // 
            this.saveProjToolStripMenuItem.Name = "saveProjToolStripMenuItem";
            this.saveProjToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveProjToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.saveProjToolStripMenuItem.Text = "Save";
            this.saveProjToolStripMenuItem.Click += new System.EventHandler(this.saveProjToolStripMenuItem_Click);
            // 
            // saveProjAsToolStripMenuItem
            // 
            this.saveProjAsToolStripMenuItem.Name = "saveProjAsToolStripMenuItem";
            this.saveProjAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveProjAsToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.saveProjAsToolStripMenuItem.Text = "Save as...";
            this.saveProjAsToolStripMenuItem.Click += new System.EventHandler(this.saveProjAsToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // BNewNetwork
            // 
            this.BNewNetwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BNewNetwork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BNewNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNewNetwork.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNewNetwork.Location = new System.Drawing.Point(15, 24);
            this.BNewNetwork.Name = "BNewNetwork";
            this.BNewNetwork.Size = new System.Drawing.Size(40, 35);
            this.BNewNetwork.TabIndex = 1;
            this.BNewNetwork.Text = "N";
            this.BNewNetwork.UseVisualStyleBackColor = false;
            this.BNewNetwork.Click += new System.EventHandler(this.BNewNetwork_Click);
            // 
            // GBNetwork
            // 
            this.GBNetwork.Controls.Add(this.BOpenNetwork);
            this.GBNetwork.Controls.Add(this.BNewNetwork);
            this.GBNetwork.Location = new System.Drawing.Point(233, 31);
            this.GBNetwork.Name = "GBNetwork";
            this.GBNetwork.Size = new System.Drawing.Size(125, 72);
            this.GBNetwork.TabIndex = 2;
            this.GBNetwork.TabStop = false;
            this.GBNetwork.Text = "Neural network";
            // 
            // BOpenNetwork
            // 
            this.BOpenNetwork.BackColor = System.Drawing.Color.Yellow;
            this.BOpenNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOpenNetwork.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.BOpenNetwork.Location = new System.Drawing.Point(61, 24);
            this.BOpenNetwork.Name = "BOpenNetwork";
            this.BOpenNetwork.Size = new System.Drawing.Size(40, 35);
            this.BOpenNetwork.TabIndex = 2;
            this.BOpenNetwork.Text = "O";
            this.BOpenNetwork.UseVisualStyleBackColor = false;
            this.BOpenNetwork.Click += new System.EventHandler(this.BOpen_Click);
            // 
            // BGetResponse
            // 
            this.BGetResponse.BackColor = System.Drawing.Color.Aquamarine;
            this.BGetResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGetResponse.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGetResponse.Location = new System.Drawing.Point(15, 24);
            this.BGetResponse.Name = "BGetResponse";
            this.BGetResponse.Size = new System.Drawing.Size(40, 35);
            this.BGetResponse.TabIndex = 3;
            this.BGetResponse.Text = "R";
            this.BGetResponse.UseVisualStyleBackColor = false;
            this.BGetResponse.Click += new System.EventHandler(this.BGetResponse_Click);
            // 
            // GBInputProj
            // 
            this.GBInputProj.Controls.Add(this.BOpenInputProj);
            this.GBInputProj.Controls.Add(this.BNewInputProj);
            this.GBInputProj.Location = new System.Drawing.Point(364, 31);
            this.GBInputProj.Name = "GBInputProj";
            this.GBInputProj.Size = new System.Drawing.Size(125, 72);
            this.GBInputProj.TabIndex = 4;
            this.GBInputProj.TabStop = false;
            this.GBInputProj.Text = "Input project";
            // 
            // BOpenInputProj
            // 
            this.BOpenInputProj.BackColor = System.Drawing.Color.Yellow;
            this.BOpenInputProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOpenInputProj.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.BOpenInputProj.Location = new System.Drawing.Point(61, 24);
            this.BOpenInputProj.Name = "BOpenInputProj";
            this.BOpenInputProj.Size = new System.Drawing.Size(40, 35);
            this.BOpenInputProj.TabIndex = 3;
            this.BOpenInputProj.Text = "O";
            this.BOpenInputProj.UseVisualStyleBackColor = false;
            this.BOpenInputProj.Click += new System.EventHandler(this.BOpenInputProj_Click);
            // 
            // BNewInputProj
            // 
            this.BNewInputProj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BNewInputProj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BNewInputProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNewInputProj.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.BNewInputProj.Location = new System.Drawing.Point(15, 24);
            this.BNewInputProj.Name = "BNewInputProj";
            this.BNewInputProj.Size = new System.Drawing.Size(40, 35);
            this.BNewInputProj.TabIndex = 1;
            this.BNewInputProj.Text = "N";
            this.BNewInputProj.UseVisualStyleBackColor = false;
            this.BNewInputProj.Click += new System.EventHandler(this.BNewInputProj_Click);
            // 
            // BTrainingMode
            // 
            this.BTrainingMode.BackColor = System.Drawing.SystemColors.Control;
            this.BTrainingMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTrainingMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTrainingMode.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTrainingMode.Location = new System.Drawing.Point(581, 31);
            this.BTrainingMode.Name = "BTrainingMode";
            this.BTrainingMode.Size = new System.Drawing.Size(130, 72);
            this.BTrainingMode.TabIndex = 2;
            this.BTrainingMode.Text = "Training mode";
            this.BTrainingMode.UseVisualStyleBackColor = false;
            // 
            // GBActions
            // 
            this.GBActions.Controls.Add(this.BGetResponse);
            this.GBActions.Location = new System.Drawing.Point(495, 31);
            this.GBActions.Name = "GBActions";
            this.GBActions.Size = new System.Drawing.Size(80, 72);
            this.GBActions.TabIndex = 5;
            this.GBActions.TabStop = false;
            this.GBActions.Text = "Actions";
            // 
            // GBProj
            // 
            this.GBProj.Controls.Add(this.BSaveProjAs);
            this.GBProj.Controls.Add(this.BSaveProj);
            this.GBProj.Controls.Add(this.BOpenProj);
            this.GBProj.Controls.Add(this.BNewProj);
            this.GBProj.Location = new System.Drawing.Point(12, 31);
            this.GBProj.Name = "GBProj";
            this.GBProj.Size = new System.Drawing.Size(215, 72);
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
            this.BSaveProjAs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BSaveProjAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSaveProjAs.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.BSaveProjAs.Location = new System.Drawing.Point(153, 24);
            this.BSaveProjAs.Name = "BSaveProjAs";
            this.BSaveProjAs.Size = new System.Drawing.Size(40, 35);
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
            this.BSaveProj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BSaveProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSaveProj.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.BSaveProj.Location = new System.Drawing.Point(107, 24);
            this.BSaveProj.Name = "BSaveProj";
            this.BSaveProj.Size = new System.Drawing.Size(40, 35);
            this.BSaveProj.TabIndex = 3;
            this.BSaveProj.UseVisualStyleBackColor = false;
            this.BSaveProj.Click += new System.EventHandler(this.BSaveProj_Click);
            // 
            // BOpenProj
            // 
            this.BOpenProj.BackColor = System.Drawing.Color.Yellow;
            this.BOpenProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOpenProj.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.BOpenProj.Location = new System.Drawing.Point(61, 24);
            this.BOpenProj.Name = "BOpenProj";
            this.BOpenProj.Size = new System.Drawing.Size(40, 35);
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
            this.BNewProj.Location = new System.Drawing.Point(15, 24);
            this.BNewProj.Name = "BNewProj";
            this.BNewProj.Size = new System.Drawing.Size(40, 35);
            this.BNewProj.TabIndex = 1;
            this.BNewProj.Text = "N";
            this.BNewProj.UseVisualStyleBackColor = false;
            this.BNewProj.Click += new System.EventHandler(this.BNewProj_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 122);
            this.Controls.Add(this.GBProj);
            this.Controls.Add(this.GBActions);
            this.Controls.Add(this.BTrainingMode);
            this.Controls.Add(this.GBInputProj);
            this.Controls.Add(this.GBNetwork);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.GBNetwork.ResumeLayout(false);
            this.GBInputProj.ResumeLayout(false);
            this.GBActions.ResumeLayout(false);
            this.GBProj.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.GroupBox GBNetwork;
        private System.Windows.Forms.Button BOpenNetwork;
        private System.Windows.Forms.Button BGetResponse;
        private System.Windows.Forms.GroupBox GBInputProj;
        private System.Windows.Forms.Button BNewInputProj;
        private System.Windows.Forms.Button BNewNetwork;
        private System.Windows.Forms.Button BTrainingMode;
        private System.Windows.Forms.ToolStripMenuItem openProjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjAsToolStripMenuItem;
        private System.Windows.Forms.Button BOpenInputProj;
        private System.Windows.Forms.GroupBox GBActions;
        private System.Windows.Forms.GroupBox GBProj;
        private System.Windows.Forms.Button BOpenProj;
        private System.Windows.Forms.Button BNewProj;
        private System.Windows.Forms.Button BSaveProj;
        private System.Windows.Forms.Button BSaveProjAs;
    }
}
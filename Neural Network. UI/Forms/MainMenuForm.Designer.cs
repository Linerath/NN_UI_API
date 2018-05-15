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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.MainMenu.SuspendLayout();
            this.GBNetwork.SuspendLayout();
            this.GBInputProj.SuspendLayout();
            this.GBActions.SuspendLayout();
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
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
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
            this.GBNetwork.Location = new System.Drawing.Point(12, 31);
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
            this.GBInputProj.Location = new System.Drawing.Point(143, 31);
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
            this.BTrainingMode.Location = new System.Drawing.Point(360, 31);
            this.BTrainingMode.Name = "BTrainingMode";
            this.BTrainingMode.Size = new System.Drawing.Size(130, 72);
            this.BTrainingMode.TabIndex = 2;
            this.BTrainingMode.Text = "Training mode";
            this.BTrainingMode.UseVisualStyleBackColor = false;
            // 
            // GBActions
            // 
            this.GBActions.Controls.Add(this.BGetResponse);
            this.GBActions.Location = new System.Drawing.Point(274, 31);
            this.GBActions.Name = "GBActions";
            this.GBActions.Size = new System.Drawing.Size(80, 72);
            this.GBActions.TabIndex = 5;
            this.GBActions.TabStop = false;
            this.GBActions.Text = "Actions";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 122);
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
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Button BOpenInputProj;
        private System.Windows.Forms.GroupBox GBActions;
    }
}
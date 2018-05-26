namespace Neural_Network.UI.Forms
{
    partial class NetworkExplorerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkExplorerForm));
            this.TVNetworks = new System.Windows.Forms.TreeView();
            this.NFBRemove = new Neural_Network.UI.Shared.Controls.NonFocusButton();
            this.NFBView = new Neural_Network.UI.Shared.Controls.NonFocusButton();
            this.SuspendLayout();
            // 
            // TVNetworks
            // 
            this.TVNetworks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TVNetworks.HideSelection = false;
            this.TVNetworks.Location = new System.Drawing.Point(0, 40);
            this.TVNetworks.Name = "TVNetworks";
            this.TVNetworks.Size = new System.Drawing.Size(282, 237);
            this.TVNetworks.TabIndex = 0;
            this.TVNetworks.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TVNetworks_NodeMouseDoubleClick);
            // 
            // NFBRemove
            // 
            this.NFBRemove.BackColor = System.Drawing.Color.Transparent;
            this.NFBRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NFBRemove.BackgroundImage")));
            this.NFBRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NFBRemove.FlatAppearance.BorderSize = 0;
            this.NFBRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.NFBRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.NFBRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NFBRemove.Location = new System.Drawing.Point(45, 5);
            this.NFBRemove.Name = "NFBRemove";
            this.NFBRemove.Size = new System.Drawing.Size(34, 30);
            this.NFBRemove.TabIndex = 3;
            this.NFBRemove.UseVisualStyleBackColor = false;
            this.NFBRemove.Click += new System.EventHandler(this.BRemove_Click);
            // 
            // NFBView
            // 
            this.NFBView.BackColor = System.Drawing.Color.Transparent;
            this.NFBView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NFBView.BackgroundImage")));
            this.NFBView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NFBView.FlatAppearance.BorderSize = 0;
            this.NFBView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.NFBView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.NFBView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NFBView.Location = new System.Drawing.Point(5, 5);
            this.NFBView.Name = "NFBView";
            this.NFBView.Size = new System.Drawing.Size(34, 30);
            this.NFBView.TabIndex = 4;
            this.NFBView.UseVisualStyleBackColor = false;
            this.NFBView.Click += new System.EventHandler(this.NFBView_Click);
            // 
            // NetworkExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 277);
            this.Controls.Add(this.NFBView);
            this.Controls.Add(this.NFBRemove);
            this.Controls.Add(this.TVNetworks);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NetworkExplorerForm";
            this.ShowIcon = false;
            this.Text = "Network Explorer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NetworkExplorerForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView TVNetworks;
        private Shared.Controls.NonFocusButton NFBRemove;
        private Shared.Controls.NonFocusButton NFBView;
    }
}
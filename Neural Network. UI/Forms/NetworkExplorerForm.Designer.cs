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
            this.BRemove = new System.Windows.Forms.Button();
            this.TVNetworks = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // BRemove
            // 
            this.BRemove.BackColor = System.Drawing.Color.Transparent;
            this.BRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BRemove.BackgroundImage")));
            this.BRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BRemove.FlatAppearance.BorderSize = 0;
            this.BRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRemove.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRemove.Location = new System.Drawing.Point(5, 5);
            this.BRemove.Name = "BRemove";
            this.BRemove.Size = new System.Drawing.Size(34, 30);
            this.BRemove.TabIndex = 2;
            this.BRemove.UseVisualStyleBackColor = false;
            this.BRemove.Click += new System.EventHandler(this.BRemove_Click);
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
            // NetworkExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 277);
            this.Controls.Add(this.BRemove);
            this.Controls.Add(this.TVNetworks);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NetworkExplorerForm";
            this.ShowIcon = false;
            this.Text = "Network Explorer";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BRemove;
        private System.Windows.Forms.TreeView TVNetworks;
    }
}
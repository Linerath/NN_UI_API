namespace NeuralNetwork_UI.Forms
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
            this.TVNetworks = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // TVNetworks
            // 
            this.TVNetworks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TVNetworks.Location = new System.Drawing.Point(0, 23);
            this.TVNetworks.Name = "TVNetworks";
            this.TVNetworks.Size = new System.Drawing.Size(282, 230);
            this.TVNetworks.TabIndex = 0;
            this.TVNetworks.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TVNetworks_NodeMouseDoubleClick);
            // 
            // NetworkExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.TVNetworks);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NetworkExplorerForm";
            this.ShowIcon = false;
            this.Text = "NetworkExplorerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TVNetworks;
    }
}
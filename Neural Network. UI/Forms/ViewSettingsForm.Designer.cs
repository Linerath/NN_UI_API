namespace Neural_Network.UI.Forms
{
    partial class ViewSettingsForm
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
            this.PLayers = new System.Windows.Forms.Panel();
            this.PGProperties = new System.Windows.Forms.PropertyGrid();
            this.PLayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // PLayers
            // 
            this.PLayers.Controls.Add(this.PGProperties);
            this.PLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PLayers.Location = new System.Drawing.Point(0, 0);
            this.PLayers.Name = "PLayers";
            this.PLayers.Size = new System.Drawing.Size(282, 303);
            this.PLayers.TabIndex = 1;
            // 
            // PGProperties
            // 
            this.PGProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PGProperties.Location = new System.Drawing.Point(0, 0);
            this.PGProperties.Name = "PGProperties";
            this.PGProperties.Size = new System.Drawing.Size(282, 303);
            this.PGProperties.TabIndex = 2;
            // 
            // ViewSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 303);
            this.Controls.Add(this.PLayers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewSettingsForm";
            this.ShowIcon = false;
            this.Text = "View Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewSettingsForm_FormClosing);
            this.PLayers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PLayers;
        public System.Windows.Forms.PropertyGrid PGProperties;
    }
}
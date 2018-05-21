namespace Neural_Network.UI.Forms
{
    partial class NetworkForm
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
            this.TLPPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // TLPPanel
            // 
            this.TLPPanel.ColumnCount = 1;
            this.TLPPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPPanel.Location = new System.Drawing.Point(0, 0);
            this.TLPPanel.Name = "TLPPanel";
            this.TLPPanel.RowCount = 1;
            this.TLPPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPPanel.Size = new System.Drawing.Size(435, 206);
            this.TLPPanel.TabIndex = 3;
            // 
            // NetworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 206);
            this.Controls.Add(this.TLPPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NetworkForm";
            this.ShowIcon = false;
            this.Text = "Network Form";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel TLPPanel;
    }
}
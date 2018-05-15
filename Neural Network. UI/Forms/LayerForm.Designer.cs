namespace Neural_Network.UI.Forms
{
    partial class LayerForm
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
            this.DGVLayer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLayer)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVLayer
            // 
            this.DGVLayer.AllowUserToAddRows = false;
            this.DGVLayer.AllowUserToDeleteRows = false;
            this.DGVLayer.AllowUserToOrderColumns = true;
            this.DGVLayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLayer.ColumnHeadersVisible = false;
            this.DGVLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVLayer.Location = new System.Drawing.Point(0, 0);
            this.DGVLayer.Name = "DGVLayer";
            this.DGVLayer.RowHeadersVisible = false;
            this.DGVLayer.RowTemplate.Height = 24;
            this.DGVLayer.Size = new System.Drawing.Size(282, 253);
            this.DGVLayer.TabIndex = 1;
            // 
            // LayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.DGVLayer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LayerForm";
            this.ShowIcon = false;
            this.Text = "LayerForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVLayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVLayer;
    }
}
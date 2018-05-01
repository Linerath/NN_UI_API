namespace NeuralNetwork_UI.Forms
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PLayers = new System.Windows.Forms.Panel();
            this.PGLayers = new System.Windows.Forms.PropertyGrid();
            this.PLayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(282, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // PLayers
            // 
            this.PLayers.Controls.Add(this.PGLayers);
            this.PLayers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PLayers.Location = new System.Drawing.Point(0, 30);
            this.PLayers.Name = "PLayers";
            this.PLayers.Size = new System.Drawing.Size(282, 452);
            this.PLayers.TabIndex = 1;
            // 
            // PGLayers
            // 
            this.PGLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PGLayers.Location = new System.Drawing.Point(0, 0);
            this.PGLayers.Name = "PGLayers";
            this.PGLayers.Size = new System.Drawing.Size(282, 452);
            this.PGLayers.TabIndex = 2;
            // 
            // ViewSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 482);
            this.Controls.Add(this.PLayers);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewSettingsForm";
            this.ShowIcon = false;
            this.Text = "View Settings";
            this.PLayers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel PLayers;
        public System.Windows.Forms.PropertyGrid PGLayers;
    }
}
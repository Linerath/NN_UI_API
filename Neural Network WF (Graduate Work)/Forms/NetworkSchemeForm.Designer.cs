namespace Neural_Network_WF__Graduate_Work_.Forms
{
    partial class NetworkSchemeForm
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
            this.PCanvas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PCanvas
            // 
            this.PCanvas.BackColor = System.Drawing.Color.White;
            this.PCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCanvas.Location = new System.Drawing.Point(0, 0);
            this.PCanvas.Name = "PCanvas";
            this.PCanvas.Size = new System.Drawing.Size(839, 354);
            this.PCanvas.TabIndex = 0;
            // 
            // NetworkSchemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 354);
            this.Controls.Add(this.PCanvas);
            this.Name = "NetworkSchemeForm";
            this.Text = "NetworkSchemeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PCanvas;
    }
}
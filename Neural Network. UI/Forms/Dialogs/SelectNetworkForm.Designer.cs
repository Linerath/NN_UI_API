namespace Neural_Network.UI.Forms.Dialogs
{
    partial class SelectNetworkForm
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
            this.BCancel = new System.Windows.Forms.Button();
            this.LBNetworks = new System.Windows.Forms.ListBox();
            this.BOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BCancel
            // 
            this.BCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BCancel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancel.Location = new System.Drawing.Point(226, 48);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(63, 31);
            this.BCancel.TabIndex = 14;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // LBNetworks
            // 
            this.LBNetworks.FormattingEnabled = true;
            this.LBNetworks.ItemHeight = 20;
            this.LBNetworks.Location = new System.Drawing.Point(12, 12);
            this.LBNetworks.Name = "LBNetworks";
            this.LBNetworks.Size = new System.Drawing.Size(208, 204);
            this.LBNetworks.TabIndex = 12;
            // 
            // BOk
            // 
            this.BOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BOk.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOk.Location = new System.Drawing.Point(226, 12);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(63, 30);
            this.BOk.TabIndex = 13;
            this.BOk.Text = "OK";
            this.BOk.UseVisualStyleBackColor = true;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // SelectNetworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 221);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.LBNetworks);
            this.Controls.Add(this.BOk);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectNetworkForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select network";
            this.Load += new System.EventHandler(this.SelectNetworkForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.ListBox LBNetworks;
        private System.Windows.Forms.Button BOk;
    }
}
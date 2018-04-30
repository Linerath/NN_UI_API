namespace NeuralNetwork_UI.Forms.Dialogs
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
            this.LSelect = new System.Windows.Forms.Label();
            this.BOk = new System.Windows.Forms.Button();
            this.LBNetworks = new System.Windows.Forms.ListBox();
            this.LName = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.BCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LSelect
            // 
            this.LSelect.AutoSize = true;
            this.LSelect.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSelect.Location = new System.Drawing.Point(12, 70);
            this.LSelect.Name = "LSelect";
            this.LSelect.Size = new System.Drawing.Size(135, 20);
            this.LSelect.TabIndex = 10;
            this.LSelect.Text = "Select network";
            // 
            // BOk
            // 
            this.BOk.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOk.Location = new System.Drawing.Point(226, 93);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(63, 30);
            this.BOk.TabIndex = 2;
            this.BOk.Text = "OK";
            this.BOk.UseVisualStyleBackColor = true;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // LBNetworks
            // 
            this.LBNetworks.FormattingEnabled = true;
            this.LBNetworks.ItemHeight = 20;
            this.LBNetworks.Location = new System.Drawing.Point(12, 93);
            this.LBNetworks.Name = "LBNetworks";
            this.LBNetworks.Size = new System.Drawing.Size(208, 204);
            this.LBNetworks.TabIndex = 1;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(12, 9);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(99, 20);
            this.LName.TabIndex = 9;
            this.LName.Text = "Enter name";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(12, 32);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(208, 27);
            this.TBName.TabIndex = 0;
            // 
            // BCancel
            // 
            this.BCancel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancel.Location = new System.Drawing.Point(226, 129);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(63, 31);
            this.BCancel.TabIndex = 11;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // SelectNetworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 309);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.LBNetworks);
            this.Controls.Add(this.BOk);
            this.Controls.Add(this.LSelect);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectNetworkForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New input project";
            this.Load += new System.EventHandler(this.SelectNetworkForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LSelect;
        private System.Windows.Forms.Button BOk;
        private System.Windows.Forms.ListBox LBNetworks;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Button BCancel;
    }
}
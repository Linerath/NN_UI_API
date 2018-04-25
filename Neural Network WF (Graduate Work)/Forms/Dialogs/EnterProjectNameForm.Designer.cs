namespace Neural_Network_WF__Graduate_Work_.Forms.Dialogs
{
    partial class EnterProjectNameForm
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
            this.TBProjectName = new System.Windows.Forms.TextBox();
            this.LEnterProjectName = new System.Windows.Forms.Label();
            this.BOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBProjectName
            // 
            this.TBProjectName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBProjectName.Location = new System.Drawing.Point(235, 38);
            this.TBProjectName.Name = "TBProjectName";
            this.TBProjectName.Size = new System.Drawing.Size(193, 27);
            this.TBProjectName.TabIndex = 0;
            // 
            // LEnterProjectName
            // 
            this.LEnterProjectName.AutoSize = true;
            this.LEnterProjectName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEnterProjectName.Location = new System.Drawing.Point(12, 41);
            this.LEnterProjectName.Name = "LEnterProjectName";
            this.LEnterProjectName.Size = new System.Drawing.Size(180, 20);
            this.LEnterProjectName.TabIndex = 1;
            this.LEnterProjectName.Text = "Enter project name:";
            // 
            // BOk
            // 
            this.BOk.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOk.Location = new System.Drawing.Point(356, 78);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(72, 33);
            this.BOk.TabIndex = 3;
            this.BOk.Text = "OK";
            this.BOk.UseVisualStyleBackColor = true;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // EnterProjectNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 123);
            this.Controls.Add(this.BOk);
            this.Controls.Add(this.LEnterProjectName);
            this.Controls.Add(this.TBProjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterProjectNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBProjectName;
        private System.Windows.Forms.Label LEnterProjectName;
        private System.Windows.Forms.Button BOk;
    }
}
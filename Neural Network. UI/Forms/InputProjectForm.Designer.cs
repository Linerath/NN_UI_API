namespace Neural_Network.UI.Forms
{
    partial class InputProjectForm
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
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVInputFields = new System.Windows.Forms.DataGridView();
            this.LInput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInputFields)).BeginInit();
            this.SuspendLayout();
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Field type";
            this.Column2.Items.AddRange(new object[] {
            "Number",
            "Boolean"});
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Field name";
            this.Column1.Name = "Column1";
            // 
            // DGVInputFields
            // 
            this.DGVInputFields.AllowUserToAddRows = false;
            this.DGVInputFields.AllowUserToDeleteRows = false;
            this.DGVInputFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInputFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DGVInputFields.Location = new System.Drawing.Point(12, 32);
            this.DGVInputFields.Name = "DGVInputFields";
            this.DGVInputFields.RowTemplate.Height = 24;
            this.DGVInputFields.Size = new System.Drawing.Size(452, 150);
            this.DGVInputFields.TabIndex = 0;
            // 
            // LInput
            // 
            this.LInput.AutoSize = true;
            this.LInput.Location = new System.Drawing.Point(12, 9);
            this.LInput.Name = "LInput";
            this.LInput.Size = new System.Drawing.Size(189, 20);
            this.LInput.TabIndex = 1;
            this.LInput.Text = "Network input fields";
            // 
            // InputProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 336);
            this.Controls.Add(this.LInput);
            this.Controls.Add(this.DGVInputFields);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputProjectForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Input Projects";
            ((System.ComponentModel.ISupportInitialize)(this.DGVInputFields)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView DGVInputFields;
        private System.Windows.Forms.Label LInput;
    }
}
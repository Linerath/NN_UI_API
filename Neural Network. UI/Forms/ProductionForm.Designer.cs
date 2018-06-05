namespace Neural_Network.UI.Forms
{
    partial class ProductionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GBFields = new System.Windows.Forms.GroupBox();
            this.LField0 = new System.Windows.Forms.Label();
            this.NUDField0 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTraining = new System.Windows.Forms.Button();
            this.LTrainingInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.GBFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDField0)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.Controls.Add(this.GBFields, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1140, 669);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GBFields
            // 
            this.GBFields.Controls.Add(this.LField0);
            this.GBFields.Controls.Add(this.NUDField0);
            this.GBFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBFields.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBFields.Location = new System.Drawing.Point(3, 2);
            this.GBFields.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBFields.Name = "GBFields";
            this.GBFields.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBFields.Size = new System.Drawing.Size(421, 665);
            this.GBFields.TabIndex = 7;
            this.GBFields.TabStop = false;
            this.GBFields.Text = "Current production state";
            // 
            // LField0
            // 
            this.LField0.AutoSize = true;
            this.LField0.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LField0.Location = new System.Drawing.Point(128, 47);
            this.LField0.Name = "LField0";
            this.LField0.Size = new System.Drawing.Size(18, 20);
            this.LField0.TabIndex = 1;
            this.LField0.Text = "0";
            // 
            // NUDField0
            // 
            this.NUDField0.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDField0.Location = new System.Drawing.Point(17, 45);
            this.NUDField0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NUDField0.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDField0.Name = "NUDField0";
            this.NUDField0.Size = new System.Drawing.Size(105, 27);
            this.NUDField0.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.BTraining);
            this.groupBox2.Controls.Add(this.LTrainingInfo);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(430, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 663);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "First things first";
            // 
            // BTraining
            // 
            this.BTraining.Location = new System.Drawing.Point(236, 166);
            this.BTraining.Name = "BTraining";
            this.BTraining.Size = new System.Drawing.Size(193, 56);
            this.BTraining.TabIndex = 5;
            this.BTraining.Text = "Перейти к обучению";
            this.BTraining.UseVisualStyleBackColor = true;
            // 
            // LTrainingInfo
            // 
            this.LTrainingInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LTrainingInfo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTrainingInfo.Location = new System.Drawing.Point(3, 23);
            this.LTrainingInfo.Name = "LTrainingInfo";
            this.LTrainingInfo.Size = new System.Drawing.Size(701, 132);
            this.LTrainingInfo.TabIndex = 4;
            this.LTrainingInfo.Text = resources.GetString("LTrainingInfo.Text");
            this.LTrainingInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 669);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production";
            this.Load += new System.EventHandler(this.ProductionForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GBFields.ResumeLayout(false);
            this.GBFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDField0)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox GBFields;
        private System.Windows.Forms.Label LField0;
        private System.Windows.Forms.NumericUpDown NUDField0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTraining;
        private System.Windows.Forms.Label LTrainingInfo;
    }
}
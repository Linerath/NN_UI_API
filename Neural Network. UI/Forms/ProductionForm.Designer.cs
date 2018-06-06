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
            this.GBBody = new System.Windows.Forms.GroupBox();
            this.NUDField0 = new System.Windows.Forms.NumericUpDown();
            this.GBSections = new System.Windows.Forms.GroupBox();
            this.LFunction0 = new System.Windows.Forms.Label();
            this.PNotTrained = new System.Windows.Forms.Panel();
            this.BTraining = new System.Windows.Forms.Button();
            this.LTrainingInfo = new System.Windows.Forms.Label();
            this.PFailureChange = new System.Windows.Forms.Panel();
            this.PBFailureChance = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.GBFields.SuspendLayout();
            this.GBBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDField0)).BeginInit();
            this.GBSections.SuspendLayout();
            this.PNotTrained.SuspendLayout();
            this.PFailureChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.Controls.Add(this.GBFields, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GBBody, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GBSections, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1356, 669);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GBFields
            // 
            this.GBFields.Controls.Add(this.LField0);
            this.GBFields.Controls.Add(this.PNotTrained);
            this.GBFields.Controls.Add(this.NUDField0);
            this.GBFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBFields.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBFields.Location = new System.Drawing.Point(3, 2);
            this.GBFields.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBFields.Name = "GBFields";
            this.GBFields.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBFields.Size = new System.Drawing.Size(446, 665);
            this.GBFields.TabIndex = 11;
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
            // GBBody
            // 
            this.GBBody.Controls.Add(this.PFailureChange);
            this.GBBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBBody.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBBody.Location = new System.Drawing.Point(455, 3);
            this.GBBody.Name = "GBBody";
            this.GBBody.Size = new System.Drawing.Size(547, 663);
            this.GBBody.TabIndex = 11;
            this.GBBody.TabStop = false;
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
            // GBSections
            // 
            this.GBSections.Controls.Add(this.LFunction0);
            this.GBSections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBSections.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSections.Location = new System.Drawing.Point(1008, 3);
            this.GBSections.Name = "GBSections";
            this.GBSections.Size = new System.Drawing.Size(345, 663);
            this.GBSections.TabIndex = 12;
            this.GBSections.TabStop = false;
            // 
            // LFunction0
            // 
            this.LFunction0.BackColor = System.Drawing.SystemColors.Control;
            this.LFunction0.Dock = System.Windows.Forms.DockStyle.Top;
            this.LFunction0.Location = new System.Drawing.Point(3, 23);
            this.LFunction0.Name = "LFunction0";
            this.LFunction0.Size = new System.Drawing.Size(339, 30);
            this.LFunction0.TabIndex = 0;
            this.LFunction0.Text = "<- Function0";
            this.LFunction0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PNotTrained
            // 
            this.PNotTrained.Controls.Add(this.BTraining);
            this.PNotTrained.Controls.Add(this.LTrainingInfo);
            this.PNotTrained.Location = new System.Drawing.Point(40, 439);
            this.PNotTrained.Name = "PNotTrained";
            this.PNotTrained.Size = new System.Drawing.Size(82, 59);
            this.PNotTrained.TabIndex = 0;
            // 
            // BTraining
            // 
            this.BTraining.Location = new System.Drawing.Point(179, 188);
            this.BTraining.Name = "BTraining";
            this.BTraining.Size = new System.Drawing.Size(193, 56);
            this.BTraining.TabIndex = 7;
            this.BTraining.Text = "Перейти к обучению";
            this.BTraining.UseVisualStyleBackColor = true;
            // 
            // LTrainingInfo
            // 
            this.LTrainingInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LTrainingInfo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTrainingInfo.Location = new System.Drawing.Point(0, 0);
            this.LTrainingInfo.Name = "LTrainingInfo";
            this.LTrainingInfo.Size = new System.Drawing.Size(82, 132);
            this.LTrainingInfo.TabIndex = 6;
            this.LTrainingInfo.Text = resources.GetString("LTrainingInfo.Text");
            this.LTrainingInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PFailureChange
            // 
            this.PFailureChange.Controls.Add(this.PBFailureChance);
            this.PFailureChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PFailureChange.Location = new System.Drawing.Point(3, 23);
            this.PFailureChange.Name = "PFailureChange";
            this.PFailureChange.Size = new System.Drawing.Size(541, 637);
            this.PFailureChange.TabIndex = 8;
            // 
            // PBFailureChance
            // 
            this.PBFailureChance.Location = new System.Drawing.Point(40, 161);
            this.PBFailureChance.Name = "PBFailureChance";
            this.PBFailureChance.Size = new System.Drawing.Size(468, 45);
            this.PBFailureChance.TabIndex = 0;
            // 
            // ProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 669);
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
            this.GBBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUDField0)).EndInit();
            this.GBSections.ResumeLayout(false);
            this.PNotTrained.ResumeLayout(false);
            this.PFailureChange.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox GBFields;
        private System.Windows.Forms.Label LField0;
        private System.Windows.Forms.NumericUpDown NUDField0;
        private System.Windows.Forms.GroupBox GBBody;
        private System.Windows.Forms.GroupBox GBSections;
        private System.Windows.Forms.Label LFunction0;
        private System.Windows.Forms.Panel PNotTrained;
        private System.Windows.Forms.Button BTraining;
        private System.Windows.Forms.Label LTrainingInfo;
        private System.Windows.Forms.Panel PFailureChange;
        private System.Windows.Forms.ProgressBar PBFailureChance;
    }
}
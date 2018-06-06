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
            this.GBBody = new System.Windows.Forms.GroupBox();
            this.PNotTrained = new System.Windows.Forms.Panel();
            this.BTraining = new System.Windows.Forms.Button();
            this.LTrainingInfo = new System.Windows.Forms.Label();
            this.PFailureChance = new System.Windows.Forms.Panel();
            this.LFailureStatus = new System.Windows.Forms.Label();
            this.LFailureChance = new System.Windows.Forms.Label();
            this.PBFailureChance = new System.Windows.Forms.ProgressBar();
            this.PAssessmentOfCompleting = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LEvaluation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NUDSupposedTime = new System.Windows.Forms.NumericUpDown();
            this.BEvaluate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NUDSupposedCount = new System.Windows.Forms.NumericUpDown();
            this.GBSections = new System.Windows.Forms.GroupBox();
            this.LFunction0 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.GBFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDField0)).BeginInit();
            this.GBBody.SuspendLayout();
            this.PNotTrained.SuspendLayout();
            this.PFailureChance.SuspendLayout();
            this.PAssessmentOfCompleting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSupposedTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSupposedCount)).BeginInit();
            this.GBSections.SuspendLayout();
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
            this.NUDField0.ValueChanged += new System.EventHandler(this.NUDField_ValueChanged);
            // 
            // GBBody
            // 
            this.GBBody.Controls.Add(this.PNotTrained);
            this.GBBody.Controls.Add(this.PFailureChance);
            this.GBBody.Controls.Add(this.PAssessmentOfCompleting);
            this.GBBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBBody.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBBody.Location = new System.Drawing.Point(455, 3);
            this.GBBody.Name = "GBBody";
            this.GBBody.Size = new System.Drawing.Size(547, 663);
            this.GBBody.TabIndex = 11;
            this.GBBody.TabStop = false;
            // 
            // PNotTrained
            // 
            this.PNotTrained.Controls.Add(this.BTraining);
            this.PNotTrained.Controls.Add(this.LTrainingInfo);
            this.PNotTrained.Location = new System.Drawing.Point(483, 355);
            this.PNotTrained.Name = "PNotTrained";
            this.PNotTrained.Size = new System.Drawing.Size(215, 232);
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
            this.BTraining.Click += new System.EventHandler(this.BTraining_Click);
            // 
            // LTrainingInfo
            // 
            this.LTrainingInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LTrainingInfo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTrainingInfo.Location = new System.Drawing.Point(0, 0);
            this.LTrainingInfo.Name = "LTrainingInfo";
            this.LTrainingInfo.Size = new System.Drawing.Size(215, 132);
            this.LTrainingInfo.TabIndex = 6;
            this.LTrainingInfo.Text = resources.GetString("LTrainingInfo.Text");
            this.LTrainingInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PFailureChance
            // 
            this.PFailureChance.Controls.Add(this.LFailureStatus);
            this.PFailureChance.Controls.Add(this.LFailureChance);
            this.PFailureChance.Controls.Add(this.PBFailureChance);
            this.PFailureChance.Location = new System.Drawing.Point(24, 535);
            this.PFailureChance.Name = "PFailureChance";
            this.PFailureChance.Size = new System.Drawing.Size(419, 243);
            this.PFailureChance.TabIndex = 8;
            // 
            // LFailureStatus
            // 
            this.LFailureStatus.AutoSize = true;
            this.LFailureStatus.Location = new System.Drawing.Point(3, 10);
            this.LFailureStatus.Name = "LFailureStatus";
            this.LFailureStatus.Size = new System.Drawing.Size(243, 20);
            this.LFailureStatus.TabIndex = 2;
            this.LFailureStatus.Text = "Current production status:";
            // 
            // LFailureChance
            // 
            this.LFailureChance.AutoSize = true;
            this.LFailureChance.Location = new System.Drawing.Point(3, 46);
            this.LFailureChance.Name = "LFailureChance";
            this.LFailureChance.Size = new System.Drawing.Size(144, 20);
            this.LFailureChance.TabIndex = 1;
            this.LFailureChance.Text = "Failure chance:";
            // 
            // PBFailureChance
            // 
            this.PBFailureChance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PBFailureChance.Location = new System.Drawing.Point(3, 69);
            this.PBFailureChance.Name = "PBFailureChance";
            this.PBFailureChance.Size = new System.Drawing.Size(535, 45);
            this.PBFailureChance.TabIndex = 0;
            // 
            // PAssessmentOfCompleting
            // 
            this.PAssessmentOfCompleting.Controls.Add(this.progressBar1);
            this.PAssessmentOfCompleting.Controls.Add(this.LEvaluation);
            this.PAssessmentOfCompleting.Controls.Add(this.label2);
            this.PAssessmentOfCompleting.Controls.Add(this.NUDSupposedTime);
            this.PAssessmentOfCompleting.Controls.Add(this.BEvaluate);
            this.PAssessmentOfCompleting.Controls.Add(this.label1);
            this.PAssessmentOfCompleting.Controls.Add(this.NUDSupposedCount);
            this.PAssessmentOfCompleting.Location = new System.Drawing.Point(66, 44);
            this.PAssessmentOfCompleting.Name = "PAssessmentOfCompleting";
            this.PAssessmentOfCompleting.Size = new System.Drawing.Size(419, 243);
            this.PAssessmentOfCompleting.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(3, 216);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(535, 45);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 100;
            // 
            // LEvaluation
            // 
            this.LEvaluation.AutoSize = true;
            this.LEvaluation.Location = new System.Drawing.Point(3, 190);
            this.LEvaluation.Name = "LEvaluation";
            this.LEvaluation.Size = new System.Drawing.Size(216, 20);
            this.LEvaluation.TabIndex = 5;
            this.LEvaluation.Text = "Вероятность выполнения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Время:";
            // 
            // NUDSupposedTime
            // 
            this.NUDSupposedTime.Location = new System.Drawing.Point(308, 59);
            this.NUDSupposedTime.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDSupposedTime.Name = "NUDSupposedTime";
            this.NUDSupposedTime.Size = new System.Drawing.Size(94, 27);
            this.NUDSupposedTime.TabIndex = 3;
            // 
            // BEvaluate
            // 
            this.BEvaluate.Location = new System.Drawing.Point(208, 109);
            this.BEvaluate.Name = "BEvaluate";
            this.BEvaluate.Size = new System.Drawing.Size(128, 45);
            this.BEvaluate.TabIndex = 2;
            this.BEvaluate.Text = "Оценить";
            this.BEvaluate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Предполагаемый выпуск:";
            // 
            // NUDSupposedCount
            // 
            this.NUDSupposedCount.Location = new System.Drawing.Point(308, 26);
            this.NUDSupposedCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDSupposedCount.Name = "NUDSupposedCount";
            this.NUDSupposedCount.Size = new System.Drawing.Size(94, 27);
            this.NUDSupposedCount.TabIndex = 0;
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
            this.LFunction0.Click += new System.EventHandler(this.LSection_Click);
            // 
            // ProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 669);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.GBBody.ResumeLayout(false);
            this.PNotTrained.ResumeLayout(false);
            this.PFailureChance.ResumeLayout(false);
            this.PFailureChance.PerformLayout();
            this.PAssessmentOfCompleting.ResumeLayout(false);
            this.PAssessmentOfCompleting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSupposedTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSupposedCount)).EndInit();
            this.GBSections.ResumeLayout(false);
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
        private System.Windows.Forms.Panel PFailureChance;
        private System.Windows.Forms.ProgressBar PBFailureChance;
        private System.Windows.Forms.Label LFailureStatus;
        private System.Windows.Forms.Label LFailureChance;
        private System.Windows.Forms.Panel PAssessmentOfCompleting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUDSupposedCount;
        private System.Windows.Forms.Button BEvaluate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUDSupposedTime;
        private System.Windows.Forms.Label LEvaluation;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
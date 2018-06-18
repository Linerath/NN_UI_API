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
            this.LFailureChance1 = new System.Windows.Forms.Label();
            this.BEvaluateFailure = new System.Windows.Forms.Button();
            this.LFailureChance0 = new System.Windows.Forms.Label();
            this.PAssessmentOfCompleting = new System.Windows.Forms.Panel();
            this.LCompletingChance1 = new System.Windows.Forms.Label();
            this.LCompletingChance0 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NUDSupposedTime0 = new System.Windows.Forms.NumericUpDown();
            this.BEvaluateCompleting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NUDSupposedCount0 = new System.Windows.Forms.NumericUpDown();
            this.PSaleChance = new System.Windows.Forms.Panel();
            this.LSaleChance1 = new System.Windows.Forms.Label();
            this.LSaleChance0 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NUDSupposedTime1 = new System.Windows.Forms.NumericUpDown();
            this.BEvaluateSale = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NUDSupposedCount1 = new System.Windows.Forms.NumericUpDown();
            this.GBSections = new System.Windows.Forms.GroupBox();
            this.LFunction0 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.GBFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDField0)).BeginInit();
            this.GBBody.SuspendLayout();
            this.PNotTrained.SuspendLayout();
            this.PFailureChance.SuspendLayout();
            this.PAssessmentOfCompleting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSupposedTime0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSupposedCount0)).BeginInit();
            this.PSaleChance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSupposedTime1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSupposedCount1)).BeginInit();
            this.GBSections.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 401F));
            this.tableLayoutPanel1.Controls.Add(this.GBFields, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GBBody, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GBSections, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1523, 509);
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
            this.GBFields.Size = new System.Drawing.Size(498, 505);
            this.GBFields.TabIndex = 11;
            this.GBFields.TabStop = false;
            this.GBFields.Text = "Current production state";
            // 
            // LField0
            // 
            this.LField0.AutoSize = true;
            this.LField0.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LField0.Location = new System.Drawing.Point(156, 48);
            this.LField0.Name = "LField0";
            this.LField0.Size = new System.Drawing.Size(18, 20);
            this.LField0.TabIndex = 1;
            this.LField0.Text = "0";
            // 
            // NUDField0
            // 
            this.NUDField0.DecimalPlaces = 2;
            this.NUDField0.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDField0.Location = new System.Drawing.Point(17, 46);
            this.NUDField0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NUDField0.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDField0.Name = "NUDField0";
            this.NUDField0.Size = new System.Drawing.Size(133, 27);
            this.NUDField0.TabIndex = 0;
            this.NUDField0.ValueChanged += new System.EventHandler(this.NUDField_ValueChanged);
            // 
            // GBBody
            // 
            this.GBBody.Controls.Add(this.PNotTrained);
            this.GBBody.Controls.Add(this.PFailureChance);
            this.GBBody.Controls.Add(this.PAssessmentOfCompleting);
            this.GBBody.Controls.Add(this.PSaleChance);
            this.GBBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBBody.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBBody.Location = new System.Drawing.Point(507, 2);
            this.GBBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBBody.Name = "GBBody";
            this.GBBody.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBBody.Size = new System.Drawing.Size(611, 505);
            this.GBBody.TabIndex = 11;
            this.GBBody.TabStop = false;
            // 
            // PNotTrained
            // 
            this.PNotTrained.Controls.Add(this.BTraining);
            this.PNotTrained.Controls.Add(this.LTrainingInfo);
            this.PNotTrained.Location = new System.Drawing.Point(432, 443);
            this.PNotTrained.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PNotTrained.Name = "PNotTrained";
            this.PNotTrained.Size = new System.Drawing.Size(215, 231);
            this.PNotTrained.TabIndex = 0;
            // 
            // BTraining
            // 
            this.BTraining.Location = new System.Drawing.Point(179, 188);
            this.BTraining.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTraining.Name = "BTraining";
            this.BTraining.Size = new System.Drawing.Size(193, 57);
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
            this.LTrainingInfo.Size = new System.Drawing.Size(215, 194);
            this.LTrainingInfo.TabIndex = 6;
            this.LTrainingInfo.Text = resources.GetString("LTrainingInfo.Text");
            this.LTrainingInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PFailureChance
            // 
            this.PFailureChance.Controls.Add(this.LFailureChance1);
            this.PFailureChance.Controls.Add(this.BEvaluateFailure);
            this.PFailureChance.Controls.Add(this.LFailureChance0);
            this.PFailureChance.Location = new System.Drawing.Point(307, 309);
            this.PFailureChance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PFailureChance.Name = "PFailureChance";
            this.PFailureChance.Size = new System.Drawing.Size(259, 111);
            this.PFailureChance.TabIndex = 8;
            // 
            // LFailureChance1
            // 
            this.LFailureChance1.AutoSize = true;
            this.LFailureChance1.Location = new System.Drawing.Point(173, 8);
            this.LFailureChance1.Name = "LFailureChance1";
            this.LFailureChance1.Size = new System.Drawing.Size(0, 20);
            this.LFailureChance1.TabIndex = 7;
            // 
            // BEvaluateFailure
            // 
            this.BEvaluateFailure.Location = new System.Drawing.Point(7, 42);
            this.BEvaluateFailure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BEvaluateFailure.Name = "BEvaluateFailure";
            this.BEvaluateFailure.Size = new System.Drawing.Size(128, 46);
            this.BEvaluateFailure.TabIndex = 6;
            this.BEvaluateFailure.Text = "Оценить";
            this.BEvaluateFailure.UseVisualStyleBackColor = true;
            this.BEvaluateFailure.Click += new System.EventHandler(this.BEvaluateFailure_Click);
            // 
            // LFailureChance0
            // 
            this.LFailureChance0.AutoSize = true;
            this.LFailureChance0.Location = new System.Drawing.Point(3, 8);
            this.LFailureChance0.Name = "LFailureChance0";
            this.LFailureChance0.Size = new System.Drawing.Size(144, 20);
            this.LFailureChance0.TabIndex = 1;
            this.LFailureChance0.Text = "Failure chance:";
            // 
            // PAssessmentOfCompleting
            // 
            this.PAssessmentOfCompleting.Controls.Add(this.LCompletingChance1);
            this.PAssessmentOfCompleting.Controls.Add(this.LCompletingChance0);
            this.PAssessmentOfCompleting.Controls.Add(this.label2);
            this.PAssessmentOfCompleting.Controls.Add(this.NUDSupposedTime0);
            this.PAssessmentOfCompleting.Controls.Add(this.BEvaluateCompleting);
            this.PAssessmentOfCompleting.Controls.Add(this.label1);
            this.PAssessmentOfCompleting.Controls.Add(this.NUDSupposedCount0);
            this.PAssessmentOfCompleting.Location = new System.Drawing.Point(119, 73);
            this.PAssessmentOfCompleting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PAssessmentOfCompleting.Name = "PAssessmentOfCompleting";
            this.PAssessmentOfCompleting.Size = new System.Drawing.Size(419, 242);
            this.PAssessmentOfCompleting.TabIndex = 9;
            // 
            // LCompletingChance1
            // 
            this.LCompletingChance1.AutoSize = true;
            this.LCompletingChance1.Location = new System.Drawing.Point(245, 174);
            this.LCompletingChance1.Name = "LCompletingChance1";
            this.LCompletingChance1.Size = new System.Drawing.Size(0, 20);
            this.LCompletingChance1.TabIndex = 6;
            // 
            // LCompletingChance0
            // 
            this.LCompletingChance0.AutoSize = true;
            this.LCompletingChance0.Location = new System.Drawing.Point(3, 174);
            this.LCompletingChance0.Name = "LCompletingChance0";
            this.LCompletingChance0.Size = new System.Drawing.Size(216, 20);
            this.LCompletingChance0.TabIndex = 5;
            this.LCompletingChance0.Text = "Вероятность выполнения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Время:";
            // 
            // NUDSupposedTime0
            // 
            this.NUDSupposedTime0.Location = new System.Drawing.Point(251, 62);
            this.NUDSupposedTime0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NUDSupposedTime0.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDSupposedTime0.Name = "NUDSupposedTime0";
            this.NUDSupposedTime0.Size = new System.Drawing.Size(105, 27);
            this.NUDSupposedTime0.TabIndex = 2;
            this.NUDSupposedTime0.Value = new decimal(new int[] {
            110,
            0,
            0,
            0});
            // 
            // BEvaluateCompleting
            // 
            this.BEvaluateCompleting.Location = new System.Drawing.Point(7, 116);
            this.BEvaluateCompleting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BEvaluateCompleting.Name = "BEvaluateCompleting";
            this.BEvaluateCompleting.Size = new System.Drawing.Size(128, 46);
            this.BEvaluateCompleting.TabIndex = 4;
            this.BEvaluateCompleting.Text = "Оценить";
            this.BEvaluateCompleting.UseVisualStyleBackColor = true;
            this.BEvaluateCompleting.Click += new System.EventHandler(this.BEvaluateCompleting_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Предполагаемый выпуск:";
            // 
            // NUDSupposedCount0
            // 
            this.NUDSupposedCount0.Location = new System.Drawing.Point(251, 26);
            this.NUDSupposedCount0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NUDSupposedCount0.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDSupposedCount0.Name = "NUDSupposedCount0";
            this.NUDSupposedCount0.Size = new System.Drawing.Size(105, 27);
            this.NUDSupposedCount0.TabIndex = 0;
            this.NUDSupposedCount0.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // PSaleChance
            // 
            this.PSaleChance.Controls.Add(this.LSaleChance1);
            this.PSaleChance.Controls.Add(this.LSaleChance0);
            this.PSaleChance.Controls.Add(this.label4);
            this.PSaleChance.Controls.Add(this.NUDSupposedTime1);
            this.PSaleChance.Controls.Add(this.BEvaluateSale);
            this.PSaleChance.Controls.Add(this.label5);
            this.PSaleChance.Controls.Add(this.NUDSupposedCount1);
            this.PSaleChance.Location = new System.Drawing.Point(6, 269);
            this.PSaleChance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PSaleChance.Name = "PSaleChance";
            this.PSaleChance.Size = new System.Drawing.Size(275, 214);
            this.PSaleChance.TabIndex = 10;
            // 
            // LSaleChance1
            // 
            this.LSaleChance1.AutoSize = true;
            this.LSaleChance1.Location = new System.Drawing.Point(200, 174);
            this.LSaleChance1.Name = "LSaleChance1";
            this.LSaleChance1.Size = new System.Drawing.Size(0, 20);
            this.LSaleChance1.TabIndex = 8;
            // 
            // LSaleChance0
            // 
            this.LSaleChance0.AutoSize = true;
            this.LSaleChance0.Location = new System.Drawing.Point(3, 174);
            this.LSaleChance0.Name = "LSaleChance0";
            this.LSaleChance0.Size = new System.Drawing.Size(171, 20);
            this.LSaleChance0.TabIndex = 5;
            this.LSaleChance0.Text = "Вероятность сбыта:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Время:";
            // 
            // NUDSupposedTime1
            // 
            this.NUDSupposedTime1.Location = new System.Drawing.Point(251, 62);
            this.NUDSupposedTime1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NUDSupposedTime1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDSupposedTime1.Name = "NUDSupposedTime1";
            this.NUDSupposedTime1.Size = new System.Drawing.Size(105, 27);
            this.NUDSupposedTime1.TabIndex = 2;
            // 
            // BEvaluateSale
            // 
            this.BEvaluateSale.Location = new System.Drawing.Point(7, 116);
            this.BEvaluateSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BEvaluateSale.Name = "BEvaluateSale";
            this.BEvaluateSale.Size = new System.Drawing.Size(128, 46);
            this.BEvaluateSale.TabIndex = 3;
            this.BEvaluateSale.Text = "Оценить";
            this.BEvaluateSale.UseVisualStyleBackColor = true;
            this.BEvaluateSale.Click += new System.EventHandler(this.BEvaluateSale_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Предполагаемый выпуск:";
            // 
            // NUDSupposedCount1
            // 
            this.NUDSupposedCount1.Location = new System.Drawing.Point(251, 26);
            this.NUDSupposedCount1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NUDSupposedCount1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDSupposedCount1.Name = "NUDSupposedCount1";
            this.NUDSupposedCount1.Size = new System.Drawing.Size(105, 27);
            this.NUDSupposedCount1.TabIndex = 0;
            // 
            // GBSections
            // 
            this.GBSections.Controls.Add(this.LFunction0);
            this.GBSections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBSections.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSections.Location = new System.Drawing.Point(1124, 2);
            this.GBSections.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBSections.Name = "GBSections";
            this.GBSections.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBSections.Size = new System.Drawing.Size(396, 505);
            this.GBSections.TabIndex = 12;
            this.GBSections.TabStop = false;
            // 
            // LFunction0
            // 
            this.LFunction0.BackColor = System.Drawing.SystemColors.Control;
            this.LFunction0.Dock = System.Windows.Forms.DockStyle.Top;
            this.LFunction0.Location = new System.Drawing.Point(3, 22);
            this.LFunction0.Name = "LFunction0";
            this.LFunction0.Size = new System.Drawing.Size(390, 30);
            this.LFunction0.TabIndex = 0;
            this.LFunction0.Text = "<- Function0";
            this.LFunction0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LFunction0.Click += new System.EventHandler(this.LSection_Click);
            // 
            // ProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 509);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "ProductionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductionForm_FormClosing);
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
            ((System.ComponentModel.ISupportInitialize)(this.NUDSupposedTime0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSupposedCount0)).EndInit();
            this.PSaleChance.ResumeLayout(false);
            this.PSaleChance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSupposedTime1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSupposedCount1)).EndInit();
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
        private System.Windows.Forms.Label LFailureChance0;
        private System.Windows.Forms.Panel PAssessmentOfCompleting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUDSupposedCount0;
        private System.Windows.Forms.Button BEvaluateCompleting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUDSupposedTime0;
        private System.Windows.Forms.Label LCompletingChance0;
        private System.Windows.Forms.Panel PSaleChance;
        private System.Windows.Forms.Label LSaleChance0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUDSupposedTime1;
        private System.Windows.Forms.Button BEvaluateSale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NUDSupposedCount1;
        private System.Windows.Forms.Button BEvaluateFailure;
        private System.Windows.Forms.Label LCompletingChance1;
        private System.Windows.Forms.Label LFailureChance1;
        private System.Windows.Forms.Label LSaleChance1;
    }
}
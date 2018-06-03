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
            this.NUDDetails = new System.Windows.Forms.NumericUpDown();
            this.LDetails = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LSpeed = new System.Windows.Forms.Label();
            this.NUDSpeed = new System.Windows.Forms.NumericUpDown();
            this.LEmployees = new System.Windows.Forms.Label();
            this.NUDEmployeees = new System.Windows.Forms.NumericUpDown();
            this.LRhythm = new System.Windows.Forms.Label();
            this.NUDRhythm = new System.Windows.Forms.NumericUpDown();
            this.LTact = new System.Windows.Forms.Label();
            this.NUDTact = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEmployeees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRhythm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTact)).BeginInit();
            this.SuspendLayout();
            // 
            // NUDDetails
            // 
            this.NUDDetails.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDDetails.Location = new System.Drawing.Point(6, 34);
            this.NUDDetails.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDDetails.Name = "NUDDetails";
            this.NUDDetails.Size = new System.Drawing.Size(105, 27);
            this.NUDDetails.TabIndex = 0;
            // 
            // LDetails
            // 
            this.LDetails.AutoSize = true;
            this.LDetails.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetails.Location = new System.Drawing.Point(117, 36);
            this.LDetails.Name = "LDetails";
            this.LDetails.Size = new System.Drawing.Size(63, 20);
            this.LDetails.TabIndex = 1;
            this.LDetails.Text = "Детали";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LTact);
            this.groupBox1.Controls.Add(this.NUDTact);
            this.groupBox1.Controls.Add(this.LRhythm);
            this.groupBox1.Controls.Add(this.NUDRhythm);
            this.groupBox1.Controls.Add(this.LEmployees);
            this.groupBox1.Controls.Add(this.NUDEmployeees);
            this.groupBox1.Controls.Add(this.LSpeed);
            this.groupBox1.Controls.Add(this.NUDSpeed);
            this.groupBox1.Controls.Add(this.LDetails);
            this.groupBox1.Controls.Add(this.NUDDetails);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 213);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current production state";
            // 
            // LSpeed
            // 
            this.LSpeed.AutoSize = true;
            this.LSpeed.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSpeed.Location = new System.Drawing.Point(117, 69);
            this.LSpeed.Name = "LSpeed";
            this.LSpeed.Size = new System.Drawing.Size(261, 20);
            this.LSpeed.TabIndex = 3;
            this.LSpeed.Text = "Скорость потребления деталей";
            // 
            // NUDSpeed
            // 
            this.NUDSpeed.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDSpeed.Location = new System.Drawing.Point(6, 67);
            this.NUDSpeed.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDSpeed.Name = "NUDSpeed";
            this.NUDSpeed.Size = new System.Drawing.Size(105, 27);
            this.NUDSpeed.TabIndex = 2;
            // 
            // LEmployees
            // 
            this.LEmployees.AutoSize = true;
            this.LEmployees.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmployees.Location = new System.Drawing.Point(117, 102);
            this.LEmployees.Name = "LEmployees";
            this.LEmployees.Size = new System.Drawing.Size(198, 20);
            this.LEmployees.TabIndex = 5;
            this.LEmployees.Text = "Количество работников";
            // 
            // NUDEmployeees
            // 
            this.NUDEmployeees.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDEmployeees.Location = new System.Drawing.Point(6, 100);
            this.NUDEmployeees.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDEmployeees.Name = "NUDEmployeees";
            this.NUDEmployeees.Size = new System.Drawing.Size(105, 27);
            this.NUDEmployeees.TabIndex = 4;
            // 
            // LRhythm
            // 
            this.LRhythm.AutoSize = true;
            this.LRhythm.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRhythm.Location = new System.Drawing.Point(117, 135);
            this.LRhythm.Name = "LRhythm";
            this.LRhythm.Size = new System.Drawing.Size(162, 20);
            this.LRhythm.TabIndex = 7;
            this.LRhythm.Text = "Ритм производства";
            // 
            // NUDRhythm
            // 
            this.NUDRhythm.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDRhythm.Location = new System.Drawing.Point(6, 133);
            this.NUDRhythm.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDRhythm.Name = "NUDRhythm";
            this.NUDRhythm.Size = new System.Drawing.Size(105, 27);
            this.NUDRhythm.TabIndex = 6;
            // 
            // LTact
            // 
            this.LTact.AutoSize = true;
            this.LTact.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTact.Location = new System.Drawing.Point(117, 168);
            this.LTact.Name = "LTact";
            this.LTact.Size = new System.Drawing.Size(162, 20);
            this.LTact.TabIndex = 9;
            this.LTact.Text = "Такт производства";
            // 
            // NUDTact
            // 
            this.NUDTact.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDTact.Location = new System.Drawing.Point(6, 166);
            this.NUDTact.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDTact.Name = "NUDTact";
            this.NUDTact.Size = new System.Drawing.Size(105, 27);
            this.NUDTact.TabIndex = 8;
            // 
            // ProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 447);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production";
            ((System.ComponentModel.ISupportInitialize)(this.NUDDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEmployeees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRhythm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUDDetails;
        private System.Windows.Forms.Label LDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LSpeed;
        private System.Windows.Forms.NumericUpDown NUDSpeed;
        private System.Windows.Forms.Label LEmployees;
        private System.Windows.Forms.NumericUpDown NUDEmployeees;
        private System.Windows.Forms.Label LTact;
        private System.Windows.Forms.NumericUpDown NUDTact;
        private System.Windows.Forms.Label LRhythm;
        private System.Windows.Forms.NumericUpDown NUDRhythm;
    }
}
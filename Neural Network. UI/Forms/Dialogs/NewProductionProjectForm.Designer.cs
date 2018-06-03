namespace Neural_Network.UI.Forms
{
    partial class NewProductionProjectForm
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
            this.CBDetails = new System.Windows.Forms.CheckBox();
            this.CBEmployees = new System.Windows.Forms.CheckBox();
            this.CBSpeed = new System.Windows.Forms.CheckBox();
            this.CBRhythm = new System.Windows.Forms.CheckBox();
            this.CBTact = new System.Windows.Forms.CheckBox();
            this.BOk = new System.Windows.Forms.Button();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBOrdering = new System.Windows.Forms.CheckBox();
            this.CBForecasting = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBDetails
            // 
            this.CBDetails.AutoSize = true;
            this.CBDetails.Checked = true;
            this.CBDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBDetails.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBDetails.Location = new System.Drawing.Point(19, 26);
            this.CBDetails.Name = "CBDetails";
            this.CBDetails.Size = new System.Drawing.Size(85, 24);
            this.CBDetails.TabIndex = 0;
            this.CBDetails.Text = "Детали";
            this.CBDetails.UseVisualStyleBackColor = true;
            // 
            // CBEmployees
            // 
            this.CBEmployees.AutoSize = true;
            this.CBEmployees.Checked = true;
            this.CBEmployees.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBEmployees.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEmployees.Location = new System.Drawing.Point(19, 86);
            this.CBEmployees.Name = "CBEmployees";
            this.CBEmployees.Size = new System.Drawing.Size(220, 24);
            this.CBEmployees.TabIndex = 2;
            this.CBEmployees.Text = "Количество работников";
            this.CBEmployees.UseVisualStyleBackColor = true;
            // 
            // CBSpeed
            // 
            this.CBSpeed.AutoSize = true;
            this.CBSpeed.Checked = true;
            this.CBSpeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBSpeed.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBSpeed.Location = new System.Drawing.Point(19, 56);
            this.CBSpeed.Name = "CBSpeed";
            this.CBSpeed.Size = new System.Drawing.Size(283, 24);
            this.CBSpeed.TabIndex = 3;
            this.CBSpeed.Text = "Скорость потребления деталей";
            this.CBSpeed.UseVisualStyleBackColor = true;
            // 
            // CBRhythm
            // 
            this.CBRhythm.AutoSize = true;
            this.CBRhythm.Checked = true;
            this.CBRhythm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBRhythm.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBRhythm.Location = new System.Drawing.Point(19, 116);
            this.CBRhythm.Name = "CBRhythm";
            this.CBRhythm.Size = new System.Drawing.Size(184, 24);
            this.CBRhythm.TabIndex = 4;
            this.CBRhythm.Text = "Ритм производства";
            this.CBRhythm.UseVisualStyleBackColor = true;
            // 
            // CBTact
            // 
            this.CBTact.AutoSize = true;
            this.CBTact.Checked = true;
            this.CBTact.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBTact.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTact.Location = new System.Drawing.Point(19, 146);
            this.CBTact.Name = "CBTact";
            this.CBTact.Size = new System.Drawing.Size(184, 24);
            this.CBTact.TabIndex = 5;
            this.CBTact.Text = "Такт производства";
            this.CBTact.UseVisualStyleBackColor = true;
            // 
            // BOk
            // 
            this.BOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BOk.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOk.Location = new System.Drawing.Point(293, 384);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(89, 31);
            this.BOk.TabIndex = 6;
            this.BOk.Text = "OK";
            this.BOk.UseVisualStyleBackColor = true;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // TBName
            // 
            this.TBName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBName.Location = new System.Drawing.Point(12, 35);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(370, 27);
            this.TBName.TabIndex = 7;
            this.TBName.Text = "Производство холодильников";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // CBOrdering
            // 
            this.CBOrdering.AutoSize = true;
            this.CBOrdering.Checked = true;
            this.CBOrdering.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBOrdering.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOrdering.Location = new System.Drawing.Point(19, 26);
            this.CBOrdering.Name = "CBOrdering";
            this.CBOrdering.Size = new System.Drawing.Size(265, 24);
            this.CBOrdering.TabIndex = 9;
            this.CBOrdering.Text = "Создание заказов на детали";
            this.CBOrdering.UseVisualStyleBackColor = true;
            // 
            // CBForecasting
            // 
            this.CBForecasting.AutoSize = true;
            this.CBForecasting.Checked = true;
            this.CBForecasting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBForecasting.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBForecasting.Location = new System.Drawing.Point(19, 56);
            this.CBForecasting.Name = "CBForecasting";
            this.CBForecasting.Size = new System.Drawing.Size(265, 24);
            this.CBForecasting.TabIndex = 11;
            this.CBForecasting.Text = "Прогнозирование выполнения";
            this.CBForecasting.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBDetails);
            this.groupBox1.Controls.Add(this.CBEmployees);
            this.groupBox1.Controls.Add(this.CBSpeed);
            this.groupBox1.Controls.Add(this.CBRhythm);
            this.groupBox1.Controls.Add(this.CBTact);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 189);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input parameters";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CBOrdering);
            this.groupBox2.Controls.Add(this.CBForecasting);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abilities";
            // 
            // NewProductionProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 427);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.BOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProductionProjectForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parameters";
            this.Load += new System.EventHandler(this.NewProductionProjectForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CBDetails;
        private System.Windows.Forms.CheckBox CBEmployees;
        private System.Windows.Forms.CheckBox CBSpeed;
        private System.Windows.Forms.CheckBox CBRhythm;
        private System.Windows.Forms.CheckBox CBTact;
        private System.Windows.Forms.Button BOk;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CBOrdering;
        private System.Windows.Forms.CheckBox CBForecasting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
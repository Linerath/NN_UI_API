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
            this.CBFirstField = new System.Windows.Forms.CheckBox();
            this.BOk = new System.Windows.Forms.Button();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBFirstAbility = new System.Windows.Forms.CheckBox();
            this.GBFields = new System.Windows.Forms.GroupBox();
            this.GBAbilities = new System.Windows.Forms.GroupBox();
            this.GBFields.SuspendLayout();
            this.GBAbilities.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBFirstField
            // 
            this.CBFirstField.AutoSize = true;
            this.CBFirstField.Checked = true;
            this.CBFirstField.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBFirstField.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFirstField.Location = new System.Drawing.Point(16, 27);
            this.CBFirstField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBFirstField.Name = "CBFirstField";
            this.CBFirstField.Size = new System.Drawing.Size(35, 21);
            this.CBFirstField.TabIndex = 0;
            this.CBFirstField.Text = "0";
            this.CBFirstField.UseVisualStyleBackColor = true;
            // 
            // BOk
            // 
            this.BOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BOk.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOk.Location = new System.Drawing.Point(573, 102);
            this.BOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(67, 25);
            this.BOk.TabIndex = 6;
            this.BOk.Text = "OK";
            this.BOk.UseVisualStyleBackColor = true;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // TBName
            // 
            this.TBName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBName.Location = new System.Drawing.Point(9, 28);
            this.TBName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(278, 23);
            this.TBName.TabIndex = 7;
            this.TBName.Text = "Производство холодильников";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // CBFirstAbility
            // 
            this.CBFirstAbility.AutoSize = true;
            this.CBFirstAbility.Checked = true;
            this.CBFirstAbility.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBFirstAbility.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFirstAbility.Location = new System.Drawing.Point(14, 21);
            this.CBFirstAbility.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBFirstAbility.Name = "CBFirstAbility";
            this.CBFirstAbility.Size = new System.Drawing.Size(35, 21);
            this.CBFirstAbility.TabIndex = 9;
            this.CBFirstAbility.Text = "0";
            this.CBFirstAbility.UseVisualStyleBackColor = true;
            // 
            // GBFields
            // 
            this.GBFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBFields.AutoSize = true;
            this.GBFields.Controls.Add(this.CBFirstField);
            this.GBFields.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBFields.Location = new System.Drawing.Point(291, 28);
            this.GBFields.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBFields.Name = "GBFields";
            this.GBFields.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBFields.Size = new System.Drawing.Size(278, 98);
            this.GBFields.TabIndex = 12;
            this.GBFields.TabStop = false;
            this.GBFields.Text = "Input parameters";
            // 
            // GBAbilities
            // 
            this.GBAbilities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GBAbilities.AutoSize = true;
            this.GBAbilities.Controls.Add(this.CBFirstAbility);
            this.GBAbilities.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBAbilities.Location = new System.Drawing.Point(9, 65);
            this.GBAbilities.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBAbilities.Name = "GBAbilities";
            this.GBAbilities.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBAbilities.Size = new System.Drawing.Size(278, 62);
            this.GBAbilities.TabIndex = 13;
            this.GBAbilities.TabStop = false;
            this.GBAbilities.Text = "Abilities";
            // 
            // NewProductionProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 136);
            this.Controls.Add(this.GBAbilities);
            this.Controls.Add(this.GBFields);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.BOk);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProductionProjectForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parameters";
            this.Load += new System.EventHandler(this.NewProductionProjectForm_Load);
            this.GBFields.ResumeLayout(false);
            this.GBFields.PerformLayout();
            this.GBAbilities.ResumeLayout(false);
            this.GBAbilities.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CBFirstField;
        private System.Windows.Forms.Button BOk;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CBFirstAbility;
        private System.Windows.Forms.GroupBox GBFields;
        private System.Windows.Forms.GroupBox GBAbilities;
    }
}
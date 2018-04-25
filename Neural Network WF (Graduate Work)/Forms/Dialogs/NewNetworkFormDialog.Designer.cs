namespace Neural_Network_WF__Graduate_Work_.Forms.Dialogs
{
    partial class NewNetworkFormDialog
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.BOK = new System.Windows.Forms.Button();
            this.NUDInput = new System.Windows.Forms.NumericUpDown();
            this.LInputLayer = new System.Windows.Forms.Label();
            this.LHiddenLayer = new System.Windows.Forms.Label();
            this.NUDHidden = new System.Windows.Forms.NumericUpDown();
            this.LOutputLayer = new System.Windows.Forms.Label();
            this.NUDOutput = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHidden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(246, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Feedforward (Perceptron)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(21, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(147, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Not supported";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network type";
            // 
            // TBName
            // 
            this.TBName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBName.Location = new System.Drawing.Point(96, 21);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(215, 27);
            this.TBName.TabIndex = 3;
            this.TBName.Text = "Perceptron";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(25, 24);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(54, 20);
            this.LName.TabIndex = 4;
            this.LName.Text = "Name:";
            // 
            // BOK
            // 
            this.BOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOK.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOK.Location = new System.Drawing.Point(261, 340);
            this.BOK.Name = "BOK";
            this.BOK.Size = new System.Drawing.Size(75, 31);
            this.BOK.TabIndex = 5;
            this.BOK.Text = "OK";
            this.BOK.UseVisualStyleBackColor = true;
            this.BOK.Click += new System.EventHandler(this.BOK_Click);
            // 
            // NUDInput
            // 
            this.NUDInput.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDInput.Location = new System.Drawing.Point(165, 207);
            this.NUDInput.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NUDInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDInput.Name = "NUDInput";
            this.NUDInput.Size = new System.Drawing.Size(65, 27);
            this.NUDInput.TabIndex = 6;
            this.NUDInput.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // LInputLayer
            // 
            this.LInputLayer.AutoSize = true;
            this.LInputLayer.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInputLayer.Location = new System.Drawing.Point(21, 209);
            this.LInputLayer.Name = "LInputLayer";
            this.LInputLayer.Size = new System.Drawing.Size(117, 20);
            this.LInputLayer.TabIndex = 7;
            this.LInputLayer.Text = "Input layer:";
            // 
            // LHiddenLayer
            // 
            this.LHiddenLayer.AutoSize = true;
            this.LHiddenLayer.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHiddenLayer.Location = new System.Drawing.Point(13, 252);
            this.LHiddenLayer.Name = "LHiddenLayer";
            this.LHiddenLayer.Size = new System.Drawing.Size(126, 20);
            this.LHiddenLayer.TabIndex = 9;
            this.LHiddenLayer.Text = "Hidden layer:";
            // 
            // NUDHidden
            // 
            this.NUDHidden.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDHidden.Location = new System.Drawing.Point(165, 250);
            this.NUDHidden.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NUDHidden.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDHidden.Name = "NUDHidden";
            this.NUDHidden.Size = new System.Drawing.Size(65, 27);
            this.NUDHidden.TabIndex = 8;
            this.NUDHidden.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // LOutputLayer
            // 
            this.LOutputLayer.AutoSize = true;
            this.LOutputLayer.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOutputLayer.Location = new System.Drawing.Point(12, 295);
            this.LOutputLayer.Name = "LOutputLayer";
            this.LOutputLayer.Size = new System.Drawing.Size(126, 20);
            this.LOutputLayer.TabIndex = 11;
            this.LOutputLayer.Text = "Output layer:";
            // 
            // NUDOutput
            // 
            this.NUDOutput.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDOutput.Location = new System.Drawing.Point(165, 293);
            this.NUDOutput.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NUDOutput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDOutput.Name = "NUDOutput";
            this.NUDOutput.Size = new System.Drawing.Size(65, 27);
            this.NUDOutput.TabIndex = 10;
            this.NUDOutput.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // NewNetworkFormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 383);
            this.Controls.Add(this.LOutputLayer);
            this.Controls.Add(this.NUDOutput);
            this.Controls.Add(this.LHiddenLayer);
            this.Controls.Add(this.NUDHidden);
            this.Controls.Add(this.LInputLayer);
            this.Controls.Add(this.NUDInput);
            this.Controls.Add(this.BOK);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewNetworkFormDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewNetworkFormDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHidden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Button BOK;
        private System.Windows.Forms.NumericUpDown NUDInput;
        private System.Windows.Forms.Label LInputLayer;
        private System.Windows.Forms.Label LHiddenLayer;
        private System.Windows.Forms.NumericUpDown NUDHidden;
        private System.Windows.Forms.Label LOutputLayer;
        private System.Windows.Forms.NumericUpDown NUDOutput;
    }
}
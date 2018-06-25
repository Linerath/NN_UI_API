namespace Neural_Network.UI.Forms.Dialogs
{
    partial class NewNetworkForm
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
            this.LOutputLayer = new System.Windows.Forms.Label();
            this.NUDOutput = new System.Windows.Forms.NumericUpDown();
            this.LHiddenLayer = new System.Windows.Forms.Label();
            this.NUDHidden = new System.Windows.Forms.NumericUpDown();
            this.LInputLayer = new System.Windows.Forms.Label();
            this.NUDInput = new System.Windows.Forms.NumericUpDown();
            this.BOk = new System.Windows.Forms.Button();
            this.LName = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBFeedforward = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CBRandomWeights = new System.Windows.Forms.CheckBox();
            this.CBCreateAnother = new System.Windows.Forms.CheckBox();
            this.BCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHidden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LOutputLayer
            // 
            this.LOutputLayer.AutoSize = true;
            this.LOutputLayer.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOutputLayer.Location = new System.Drawing.Point(4, 198);
            this.LOutputLayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LOutputLayer.Name = "LOutputLayer";
            this.LOutputLayer.Size = new System.Drawing.Size(112, 17);
            this.LOutputLayer.TabIndex = 21;
            this.LOutputLayer.Text = "Output layer:";
            // 
            // NUDOutput
            // 
            this.NUDOutput.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDOutput.Location = new System.Drawing.Point(116, 197);
            this.NUDOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.NUDOutput.Size = new System.Drawing.Size(44, 23);
            this.NUDOutput.TabIndex = 20;
            this.NUDOutput.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // LHiddenLayer
            // 
            this.LHiddenLayer.AutoSize = true;
            this.LHiddenLayer.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHiddenLayer.Location = new System.Drawing.Point(4, 173);
            this.LHiddenLayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LHiddenLayer.Name = "LHiddenLayer";
            this.LHiddenLayer.Size = new System.Drawing.Size(112, 17);
            this.LHiddenLayer.TabIndex = 19;
            this.LHiddenLayer.Text = "Hidden layer:";
            // 
            // NUDHidden
            // 
            this.NUDHidden.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDHidden.Location = new System.Drawing.Point(116, 171);
            this.NUDHidden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.NUDHidden.Size = new System.Drawing.Size(44, 23);
            this.NUDHidden.TabIndex = 18;
            this.NUDHidden.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // LInputLayer
            // 
            this.LInputLayer.AutoSize = true;
            this.LInputLayer.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInputLayer.Location = new System.Drawing.Point(4, 148);
            this.LInputLayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LInputLayer.Name = "LInputLayer";
            this.LInputLayer.Size = new System.Drawing.Size(104, 17);
            this.LInputLayer.TabIndex = 17;
            this.LInputLayer.Text = "Input layer:";
            // 
            // NUDInput
            // 
            this.NUDInput.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDInput.Location = new System.Drawing.Point(116, 146);
            this.NUDInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.NUDInput.Size = new System.Drawing.Size(44, 23);
            this.NUDInput.TabIndex = 16;
            this.NUDInput.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // BOk
            // 
            this.BOk.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOk.Location = new System.Drawing.Point(252, 292);
            this.BOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(58, 26);
            this.BOk.TabIndex = 15;
            this.BOk.Text = "OK";
            this.BOk.UseVisualStyleBackColor = true;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(4, 24);
            this.LName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(48, 17);
            this.LName.TabIndex = 14;
            this.LName.Text = "Name:";
            // 
            // TBName
            // 
            this.TBName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBName.Location = new System.Drawing.Point(52, 22);
            this.TBName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(145, 23);
            this.TBName.TabIndex = 13;
            this.TBName.Text = "Net";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBFeedforward);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(283, 80);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network type";
            // 
            // RBFeedforward
            // 
            this.RBFeedforward.AutoSize = true;
            this.RBFeedforward.Checked = true;
            this.RBFeedforward.Location = new System.Drawing.Point(14, 24);
            this.RBFeedforward.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RBFeedforward.Name = "RBFeedforward";
            this.RBFeedforward.Size = new System.Drawing.Size(218, 21);
            this.RBFeedforward.TabIndex = 0;
            this.RBFeedforward.TabStop = true;
            this.RBFeedforward.Text = "Feedforward (Perceptron)";
            this.RBFeedforward.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(14, 46);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(266, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Make your own (INeuralNetwork)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CBRandomWeights);
            this.groupBox3.Controls.Add(this.LName);
            this.groupBox3.Controls.Add(this.TBName);
            this.groupBox3.Controls.Add(this.LOutputLayer);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.LHiddenLayer);
            this.groupBox3.Controls.Add(this.NUDOutput);
            this.groupBox3.Controls.Add(this.LInputLayer);
            this.groupBox3.Controls.Add(this.NUDInput);
            this.groupBox3.Controls.Add(this.NUDHidden);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(299, 276);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manual";
            // 
            // CBRandomWeights
            // 
            this.CBRandomWeights.AutoSize = true;
            this.CBRandomWeights.Checked = true;
            this.CBRandomWeights.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBRandomWeights.Location = new System.Drawing.Point(8, 236);
            this.CBRandomWeights.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBRandomWeights.Name = "CBRandomWeights";
            this.CBRandomWeights.Size = new System.Drawing.Size(139, 21);
            this.CBRandomWeights.TabIndex = 22;
            this.CBRandomWeights.Text = "Random weights";
            this.CBRandomWeights.UseVisualStyleBackColor = true;
            // 
            // CBCreateAnother
            // 
            this.CBCreateAnother.AutoSize = true;
            this.CBCreateAnother.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCreateAnother.Location = new System.Drawing.Point(18, 297);
            this.CBCreateAnother.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBCreateAnother.Name = "CBCreateAnother";
            this.CBCreateAnother.Size = new System.Drawing.Size(152, 18);
            this.CBCreateAnother.TabIndex = 23;
            this.CBCreateAnother.Text = "Create another one";
            this.CBCreateAnother.UseVisualStyleBackColor = true;
            // 
            // BCancel
            // 
            this.BCancel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancel.Location = new System.Drawing.Point(190, 292);
            this.BCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(58, 26);
            this.BCancel.TabIndex = 25;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // NewNetworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 329);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.CBCreateAnother);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewNetworkForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Network";
            this.Load += new System.EventHandler(this.NewNetworkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHidden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LOutputLayer;
        private System.Windows.Forms.NumericUpDown NUDOutput;
        private System.Windows.Forms.Label LHiddenLayer;
        private System.Windows.Forms.NumericUpDown NUDHidden;
        private System.Windows.Forms.Label LInputLayer;
        private System.Windows.Forms.NumericUpDown NUDInput;
        private System.Windows.Forms.Button BOk;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBFeedforward;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox CBRandomWeights;
        public System.Windows.Forms.CheckBox CBCreateAnother;
        private System.Windows.Forms.Button BCancel;
    }
}
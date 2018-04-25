namespace Neural_Network_WF__Graduate_Work_.Forms
{
    partial class NetworkViewForm
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
            this.DGVInputLayer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVHiddenLayer = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DGVOutputLayer = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUDHiddenDecimalPlaces = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CBSync0 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NUDOutputDecimalPlaces = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CBOutputAdaptCellSize = new System.Windows.Forms.CheckBox();
            this.CBHiddenAdaptCellSize = new System.Windows.Forms.CheckBox();
            this.BDrawScheme = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CBSync1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NUDOutputFontSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NUDHiddenFontSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.NUDInputFontSize = new System.Windows.Forms.NumericUpDown();
            this.BDefaultSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInputLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHiddenLayer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOutputLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHiddenDecimalPlaces)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOutputDecimalPlaces)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOutputFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHiddenFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInputFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVInputLayer
            // 
            this.DGVInputLayer.AllowUserToAddRows = false;
            this.DGVInputLayer.AllowUserToDeleteRows = false;
            this.DGVInputLayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInputLayer.ColumnHeadersVisible = false;
            this.DGVInputLayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.DGVInputLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVInputLayer.Location = new System.Drawing.Point(3, 23);
            this.DGVInputLayer.Name = "DGVInputLayer";
            this.DGVInputLayer.ReadOnly = true;
            this.DGVInputLayer.RowHeadersVisible = false;
            this.DGVInputLayer.RowTemplate.Height = 24;
            this.DGVInputLayer.Size = new System.Drawing.Size(76, 214);
            this.DGVInputLayer.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // DGVHiddenLayer
            // 
            this.DGVHiddenLayer.AllowUserToAddRows = false;
            this.DGVHiddenLayer.AllowUserToDeleteRows = false;
            this.DGVHiddenLayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHiddenLayer.ColumnHeadersVisible = false;
            this.DGVHiddenLayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.DGVHiddenLayer.Location = new System.Drawing.Point(3, 23);
            this.DGVHiddenLayer.Name = "DGVHiddenLayer";
            this.DGVHiddenLayer.RowHeadersVisible = false;
            this.DGVHiddenLayer.RowTemplate.Height = 24;
            this.DGVHiddenLayer.Size = new System.Drawing.Size(542, 214);
            this.DGVHiddenLayer.TabIndex = 2;
            this.DGVHiddenLayer.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVHiddenLayer_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVInputLayer);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 240);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGVHiddenLayer);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(160, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 240);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hidden layer";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DGVOutputLayer);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(756, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 240);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output layer";
            // 
            // DGVOutputLayer
            // 
            this.DGVOutputLayer.AllowUserToAddRows = false;
            this.DGVOutputLayer.AllowUserToDeleteRows = false;
            this.DGVOutputLayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOutputLayer.ColumnHeadersVisible = false;
            this.DGVOutputLayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.DGVOutputLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVOutputLayer.Location = new System.Drawing.Point(3, 23);
            this.DGVOutputLayer.Name = "DGVOutputLayer";
            this.DGVOutputLayer.RowHeadersVisible = false;
            this.DGVOutputLayer.RowTemplate.Height = 24;
            this.DGVOutputLayer.Size = new System.Drawing.Size(379, 214);
            this.DGVOutputLayer.TabIndex = 2;
            this.DGVOutputLayer.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVOutputLayer_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // NUDHiddenDecimalPlaces
            // 
            this.NUDHiddenDecimalPlaces.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDHiddenDecimalPlaces.Location = new System.Drawing.Point(148, 43);
            this.NUDHiddenDecimalPlaces.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NUDHiddenDecimalPlaces.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDHiddenDecimalPlaces.Name = "NUDHiddenDecimalPlaces";
            this.NUDHiddenDecimalPlaces.Size = new System.Drawing.Size(58, 27);
            this.NUDHiddenDecimalPlaces.TabIndex = 7;
            this.NUDHiddenDecimalPlaces.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NUDHiddenDecimalPlaces.ValueChanged += new System.EventHandler(this.NUDHiddenDecimalPlaces_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CBSync0);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.NUDOutputDecimalPlaces);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.NUDHiddenDecimalPlaces);
            this.groupBox4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 165);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Decimal places";
            // 
            // CBSync0
            // 
            this.CBSync0.AutoSize = true;
            this.CBSync0.Checked = true;
            this.CBSync0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBSync0.Location = new System.Drawing.Point(85, 125);
            this.CBSync0.Name = "CBSync0";
            this.CBSync0.Size = new System.Drawing.Size(67, 24);
            this.CBSync0.TabIndex = 11;
            this.CBSync0.Text = "Sync";
            this.CBSync0.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Output layer";
            // 
            // NUDOutputDecimalPlaces
            // 
            this.NUDOutputDecimalPlaces.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDOutputDecimalPlaces.Location = new System.Drawing.Point(148, 86);
            this.NUDOutputDecimalPlaces.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NUDOutputDecimalPlaces.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDOutputDecimalPlaces.Name = "NUDOutputDecimalPlaces";
            this.NUDOutputDecimalPlaces.Size = new System.Drawing.Size(58, 27);
            this.NUDOutputDecimalPlaces.TabIndex = 9;
            this.NUDOutputDecimalPlaces.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NUDOutputDecimalPlaces.ValueChanged += new System.EventHandler(this.NUDOutputDecimalPlaces_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hidden layer";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CBOutputAdaptCellSize);
            this.groupBox5.Controls.Add(this.CBHiddenAdaptCellSize);
            this.groupBox5.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.groupBox5.Location = new System.Drawing.Point(496, 291);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 106);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Adapt cell size";
            // 
            // CBOutputAdaptCellSize
            // 
            this.CBOutputAdaptCellSize.AutoSize = true;
            this.CBOutputAdaptCellSize.Checked = true;
            this.CBOutputAdaptCellSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBOutputAdaptCellSize.Location = new System.Drawing.Point(26, 64);
            this.CBOutputAdaptCellSize.Name = "CBOutputAdaptCellSize";
            this.CBOutputAdaptCellSize.Size = new System.Drawing.Size(139, 24);
            this.CBOutputAdaptCellSize.TabIndex = 3;
            this.CBOutputAdaptCellSize.Text = "Output layer";
            this.CBOutputAdaptCellSize.UseVisualStyleBackColor = true;
            this.CBOutputAdaptCellSize.CheckedChanged += new System.EventHandler(this.CBOutputAdaptCellSize_CheckedChanged);
            // 
            // CBHiddenAdaptCellSize
            // 
            this.CBHiddenAdaptCellSize.AutoSize = true;
            this.CBHiddenAdaptCellSize.Checked = true;
            this.CBHiddenAdaptCellSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBHiddenAdaptCellSize.Location = new System.Drawing.Point(26, 34);
            this.CBHiddenAdaptCellSize.Name = "CBHiddenAdaptCellSize";
            this.CBHiddenAdaptCellSize.Size = new System.Drawing.Size(139, 24);
            this.CBHiddenAdaptCellSize.TabIndex = 2;
            this.CBHiddenAdaptCellSize.Text = "Hidden layer";
            this.CBHiddenAdaptCellSize.UseVisualStyleBackColor = true;
            this.CBHiddenAdaptCellSize.CheckedChanged += new System.EventHandler(this.CBHiddenAdaptCellSize_CheckedChanged);
            // 
            // BDrawScheme
            // 
            this.BDrawScheme.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDrawScheme.Location = new System.Drawing.Point(1026, 265);
            this.BDrawScheme.Name = "BDrawScheme";
            this.BDrawScheme.Size = new System.Drawing.Size(112, 53);
            this.BDrawScheme.TabIndex = 11;
            this.BDrawScheme.Text = "Draw scheme";
            this.BDrawScheme.UseVisualStyleBackColor = true;
            this.BDrawScheme.Click += new System.EventHandler(this.BDrawScheme_Click);
            // 
            // BBack
            // 
            this.BBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBack.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBack.Location = new System.Drawing.Point(12, 491);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(75, 33);
            this.BBack.TabIndex = 12;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = true;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.NUDInputFontSize);
            this.groupBox6.Controls.Add(this.CBSync1);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.NUDOutputFontSize);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.NUDHiddenFontSize);
            this.groupBox6.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(254, 284);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(236, 209);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Font size";
            // 
            // CBSync1
            // 
            this.CBSync1.AutoSize = true;
            this.CBSync1.Checked = true;
            this.CBSync1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBSync1.Location = new System.Drawing.Point(88, 168);
            this.CBSync1.Name = "CBSync1";
            this.CBSync1.Size = new System.Drawing.Size(67, 24);
            this.CBSync1.TabIndex = 11;
            this.CBSync1.Text = "Sync";
            this.CBSync1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Output layer";
            // 
            // NUDOutputFontSize
            // 
            this.NUDOutputFontSize.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDOutputFontSize.Location = new System.Drawing.Point(151, 129);
            this.NUDOutputFontSize.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.NUDOutputFontSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDOutputFontSize.Name = "NUDOutputFontSize";
            this.NUDOutputFontSize.Size = new System.Drawing.Size(58, 27);
            this.NUDOutputFontSize.TabIndex = 9;
            this.NUDOutputFontSize.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.NUDOutputFontSize.ValueChanged += new System.EventHandler(this.NUDOutputFontSize_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hidden layer";
            // 
            // NUDHiddenFontSize
            // 
            this.NUDHiddenFontSize.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDHiddenFontSize.Location = new System.Drawing.Point(151, 86);
            this.NUDHiddenFontSize.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.NUDHiddenFontSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDHiddenFontSize.Name = "NUDHiddenFontSize";
            this.NUDHiddenFontSize.Size = new System.Drawing.Size(58, 27);
            this.NUDHiddenFontSize.TabIndex = 7;
            this.NUDHiddenFontSize.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.NUDHiddenFontSize.ValueChanged += new System.EventHandler(this.NUDHiddenFontSize_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Input layer";
            // 
            // NUDInputFontSize
            // 
            this.NUDInputFontSize.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDInputFontSize.Location = new System.Drawing.Point(151, 43);
            this.NUDInputFontSize.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.NUDInputFontSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDInputFontSize.Name = "NUDInputFontSize";
            this.NUDInputFontSize.Size = new System.Drawing.Size(58, 27);
            this.NUDInputFontSize.TabIndex = 12;
            this.NUDInputFontSize.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.NUDInputFontSize.ValueChanged += new System.EventHandler(this.NUDInputFontSize_ValueChanged);
            // 
            // BDefaultSettings
            // 
            this.BDefaultSettings.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDefaultSettings.Location = new System.Drawing.Point(1053, 471);
            this.BDefaultSettings.Name = "BDefaultSettings";
            this.BDefaultSettings.Size = new System.Drawing.Size(112, 53);
            this.BDefaultSettings.TabIndex = 13;
            this.BDefaultSettings.Text = "Default settings";
            this.BDefaultSettings.UseVisualStyleBackColor = true;
            this.BDefaultSettings.Click += new System.EventHandler(this.BDefaultSettings_Click);
            // 
            // NetworkViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 536);
            this.Controls.Add(this.BDefaultSettings);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.BDrawScheme);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NetworkViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetworkViewForm";
            this.Load += new System.EventHandler(this.NetworkViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVInputLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHiddenLayer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVOutputLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHiddenDecimalPlaces)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOutputDecimalPlaces)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOutputFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHiddenFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInputFontSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVInputLayer;
        private System.Windows.Forms.DataGridView DGVHiddenLayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DGVOutputLayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.NumericUpDown NUDHiddenDecimalPlaces;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUDOutputDecimalPlaces;
        private System.Windows.Forms.CheckBox CBSync0;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox CBOutputAdaptCellSize;
        private System.Windows.Forms.CheckBox CBHiddenAdaptCellSize;
        private System.Windows.Forms.Button BDrawScheme;
        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox CBSync1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUDOutputFontSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUDHiddenFontSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NUDInputFontSize;
        private System.Windows.Forms.Button BDefaultSettings;
    }
}
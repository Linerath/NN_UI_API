namespace Neural_Network.UI.Forms
{
    partial class TrainingForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LCreationDate0 = new System.Windows.Forms.Label();
            this.LLearningEpochs1 = new System.Windows.Forms.Label();
            this.LLearningEpochs0 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DGVInputSignals = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PBLearningProgress = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.CLearningChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NUDEpochs = new System.Windows.Forms.NumericUpDown();
            this.LEpochs = new System.Windows.Forms.Label();
            this.LLearningRate = new System.Windows.Forms.Label();
            this.NUDLearningRate = new System.Windows.Forms.NumericUpDown();
            this.CBRandomize = new System.Windows.Forms.CheckBox();
            this.LCompleted = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LStartError0 = new System.Windows.Forms.Label();
            this.LEndError0 = new System.Windows.Forms.Label();
            this.LStartError1 = new System.Windows.Forms.Label();
            this.LEndError1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInputSignals)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLearningChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEpochs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLearningRate)).BeginInit();
            this.SuspendLayout();
            // 
            // LCreationDate0
            // 
            this.LCreationDate0.AutoSize = true;
            this.LCreationDate0.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCreationDate0.Location = new System.Drawing.Point(9, 9);
            this.LCreationDate0.Name = "LCreationDate0";
            this.LCreationDate0.Size = new System.Drawing.Size(120, 18);
            this.LCreationDate0.TabIndex = 2;
            this.LCreationDate0.Text = "Creation date:";
            this.LCreationDate0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LLearningEpochs1
            // 
            this.LLearningEpochs1.AutoSize = true;
            this.LLearningEpochs1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLearningEpochs1.ForeColor = System.Drawing.Color.Green;
            this.LLearningEpochs1.Location = new System.Drawing.Point(246, 538);
            this.LLearningEpochs1.Name = "LLearningEpochs1";
            this.LLearningEpochs1.Size = new System.Drawing.Size(18, 20);
            this.LLearningEpochs1.TabIndex = 5;
            this.LLearningEpochs1.Text = "0";
            this.LLearningEpochs1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LLearningEpochs0
            // 
            this.LLearningEpochs0.AutoSize = true;
            this.LLearningEpochs0.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLearningEpochs0.Location = new System.Drawing.Point(6, 538);
            this.LLearningEpochs0.Name = "LLearningEpochs0";
            this.LLearningEpochs0.Size = new System.Drawing.Size(207, 20);
            this.LLearningEpochs0.TabIndex = 4;
            this.LLearningEpochs0.Text = "Total learning epochs:";
            this.LLearningEpochs0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(180, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select file...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 156);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "You can load training data from file. Input signals and correct output signals mu" +
    "st correspond to the following format:\r\n{ x1,x2,x3:y1,y2,y3 }, where x - input s" +
    "ignal, y - correct output signal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Input signals and correct output signals";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LEndError1);
            this.groupBox1.Controls.Add(this.LStartError1);
            this.groupBox1.Controls.Add(this.LEndError0);
            this.groupBox1.Controls.Add(this.LLearningEpochs1);
            this.groupBox1.Controls.Add(this.LStartError0);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LLearningEpochs0);
            this.groupBox1.Controls.Add(this.LCompleted);
            this.groupBox1.Controls.Add(this.CBRandomize);
            this.groupBox1.Controls.Add(this.LLearningRate);
            this.groupBox1.Controls.Add(this.NUDLearningRate);
            this.groupBox1.Controls.Add(this.LEpochs);
            this.groupBox1.Controls.Add(this.NUDEpochs);
            this.groupBox1.Controls.Add(this.CLearningChart);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.PBLearningProgress);
            this.groupBox1.Location = new System.Drawing.Point(541, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 616);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(264, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(256, 367);
            this.dataGridView1.TabIndex = 10;
            // 
            // DGVInputSignals
            // 
            this.DGVInputSignals.AllowUserToAddRows = false;
            this.DGVInputSignals.AllowUserToDeleteRows = false;
            this.DGVInputSignals.AllowUserToOrderColumns = true;
            this.DGVInputSignals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVInputSignals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInputSignals.ColumnHeadersVisible = false;
            this.DGVInputSignals.Location = new System.Drawing.Point(3, 3);
            this.DGVInputSignals.Name = "DGVInputSignals";
            this.DGVInputSignals.RowHeadersVisible = false;
            this.DGVInputSignals.RowTemplate.Height = 24;
            this.DGVInputSignals.Size = new System.Drawing.Size(255, 367);
            this.DGVInputSignals.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DGVInputSignals, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 252);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(523, 373);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // PBLearningProgress
            // 
            this.PBLearningProgress.Location = new System.Drawing.Point(6, 573);
            this.PBLearningProgress.Name = "PBLearningProgress";
            this.PBLearningProgress.Size = new System.Drawing.Size(614, 37);
            this.PBLearningProgress.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(528, 529);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Learn";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CLearningChart
            // 
            this.CLearningChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.CLearningChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CLearningChart.Legends.Add(legend1);
            this.CLearningChart.Location = new System.Drawing.Point(6, 21);
            this.CLearningChart.Name = "CLearningChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Error";
            this.CLearningChart.Series.Add(series1);
            this.CLearningChart.Size = new System.Drawing.Size(614, 286);
            this.CLearningChart.TabIndex = 2;
            // 
            // NUDEpochs
            // 
            this.NUDEpochs.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDEpochs.Location = new System.Drawing.Point(168, 351);
            this.NUDEpochs.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUDEpochs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDEpochs.Name = "NUDEpochs";
            this.NUDEpochs.Size = new System.Drawing.Size(98, 27);
            this.NUDEpochs.TabIndex = 3;
            this.NUDEpochs.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // LEpochs
            // 
            this.LEpochs.AutoSize = true;
            this.LEpochs.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEpochs.Location = new System.Drawing.Point(178, 328);
            this.LEpochs.Name = "LEpochs";
            this.LEpochs.Size = new System.Drawing.Size(63, 20);
            this.LEpochs.TabIndex = 4;
            this.LEpochs.Text = "Epochs";
            // 
            // LLearningRate
            // 
            this.LLearningRate.AutoSize = true;
            this.LLearningRate.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLearningRate.Location = new System.Drawing.Point(6, 328);
            this.LLearningRate.Name = "LLearningRate";
            this.LLearningRate.Size = new System.Drawing.Size(126, 20);
            this.LLearningRate.TabIndex = 6;
            this.LLearningRate.Text = "Learning rate";
            // 
            // NUDLearningRate
            // 
            this.NUDLearningRate.DecimalPlaces = 3;
            this.NUDLearningRate.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDLearningRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.NUDLearningRate.Location = new System.Drawing.Point(33, 351);
            this.NUDLearningRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDLearningRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.NUDLearningRate.Name = "NUDLearningRate";
            this.NUDLearningRate.Size = new System.Drawing.Size(87, 27);
            this.NUDLearningRate.TabIndex = 5;
            this.NUDLearningRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // CBRandomize
            // 
            this.CBRandomize.AutoSize = true;
            this.CBRandomize.Checked = true;
            this.CBRandomize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBRandomize.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBRandomize.Location = new System.Drawing.Point(10, 412);
            this.CBRandomize.Name = "CBRandomize";
            this.CBRandomize.Size = new System.Drawing.Size(238, 44);
            this.CBRandomize.TabIndex = 7;
            this.CBRandomize.Text = "Randomize input signals\r\nat each epoch";
            this.CBRandomize.UseVisualStyleBackColor = true;
            // 
            // LCompleted
            // 
            this.LCompleted.AutoSize = true;
            this.LCompleted.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCompleted.Location = new System.Drawing.Point(6, 507);
            this.LCompleted.Name = "LCompleted";
            this.LCompleted.Size = new System.Drawing.Size(162, 20);
            this.LCompleted.TabIndex = 8;
            this.LCompleted.Text = "Completed epochs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(192, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "0";
            // 
            // LStartError0
            // 
            this.LStartError0.AutoSize = true;
            this.LStartError0.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStartError0.Location = new System.Drawing.Point(337, 328);
            this.LStartError0.Name = "LStartError0";
            this.LStartError0.Size = new System.Drawing.Size(117, 20);
            this.LStartError0.TabIndex = 10;
            this.LStartError0.Text = "Start error:";
            // 
            // LEndError0
            // 
            this.LEndError0.AutoSize = true;
            this.LEndError0.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEndError0.Location = new System.Drawing.Point(355, 358);
            this.LEndError0.Name = "LEndError0";
            this.LEndError0.Size = new System.Drawing.Size(99, 20);
            this.LEndError0.TabIndex = 11;
            this.LEndError0.Text = "End error:";
            // 
            // LStartError1
            // 
            this.LStartError1.AutoSize = true;
            this.LStartError1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStartError1.ForeColor = System.Drawing.Color.Red;
            this.LStartError1.Location = new System.Drawing.Point(471, 328);
            this.LStartError1.Name = "LStartError1";
            this.LStartError1.Size = new System.Drawing.Size(54, 20);
            this.LStartError1.TabIndex = 12;
            this.LStartError1.Text = "0.228";
            // 
            // LEndError1
            // 
            this.LEndError1.AutoSize = true;
            this.LEndError1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEndError1.ForeColor = System.Drawing.Color.Red;
            this.LEndError1.Location = new System.Drawing.Point(471, 358);
            this.LEndError1.Name = "LEndError1";
            this.LEndError1.Size = new System.Drawing.Size(54, 20);
            this.LEndError1.TabIndex = 13;
            this.LEndError1.Text = "0.228";
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 637);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LCreationDate0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrainingForm";
            this.ShowIcon = false;
            this.Text = "Training";
            this.Load += new System.EventHandler(this.TrainingForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInputSignals)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CLearningChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEpochs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLearningRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LCreationDate0;
        private System.Windows.Forms.Label LLearningEpochs1;
        private System.Windows.Forms.Label LLearningEpochs0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVInputSignals;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart CLearningChart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar PBLearningProgress;
        private System.Windows.Forms.Label LLearningRate;
        private System.Windows.Forms.NumericUpDown NUDLearningRate;
        private System.Windows.Forms.Label LEpochs;
        private System.Windows.Forms.NumericUpDown NUDEpochs;
        private System.Windows.Forms.CheckBox CBRandomize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LCompleted;
        private System.Windows.Forms.Label LEndError1;
        private System.Windows.Forms.Label LStartError1;
        private System.Windows.Forms.Label LEndError0;
        private System.Windows.Forms.Label LStartError0;
    }
}
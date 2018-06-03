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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingForm));
            this.LCreationDate0 = new System.Windows.Forms.Label();
            this.LLearningEpochs1 = new System.Windows.Forms.Label();
            this.LLearningEpochs0 = new System.Windows.Forms.Label();
            this.BSelectFile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LEndError1 = new System.Windows.Forms.Label();
            this.LStartError1 = new System.Windows.Forms.Label();
            this.LEndError0 = new System.Windows.Forms.Label();
            this.LStartError0 = new System.Windows.Forms.Label();
            this.LCompleted1 = new System.Windows.Forms.Label();
            this.LCompleted0 = new System.Windows.Forms.Label();
            this.CBRandomize = new System.Windows.Forms.CheckBox();
            this.LLearningRate = new System.Windows.Forms.Label();
            this.NUDLearningRate = new System.Windows.Forms.NumericUpDown();
            this.LEpochs = new System.Windows.Forms.Label();
            this.NUDEpochs = new System.Windows.Forms.NumericUpDown();
            this.CLearningChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BLearn = new System.Windows.Forms.Button();
            this.PBLearningProgress = new System.Windows.Forms.ProgressBar();
            this.DGVCorrectOutputSignals = new System.Windows.Forms.DataGridView();
            this.DGVInputSignals = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NFBRandomize1 = new Neural_Network.UI.Shared.Controls.NonFocusButton();
            this.NFBSave = new Neural_Network.UI.Shared.Controls.NonFocusButton();
            this.NFBRandomize0 = new Neural_Network.UI.Shared.Controls.NonFocusButton();
            this.NFBSaveAs = new Neural_Network.UI.Shared.Controls.NonFocusButton();
            this.NFBRemove = new Neural_Network.UI.Shared.Controls.NonFocusButton();
            this.NFBAdd = new Neural_Network.UI.Shared.Controls.NonFocusButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLearningRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEpochs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLearningChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCorrectOutputSignals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInputSignals)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.LLearningEpochs1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.LLearningEpochs0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LLearningEpochs0.AutoSize = true;
            this.LLearningEpochs0.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLearningEpochs0.Location = new System.Drawing.Point(6, 538);
            this.LLearningEpochs0.Name = "LLearningEpochs0";
            this.LLearningEpochs0.Size = new System.Drawing.Size(207, 20);
            this.LLearningEpochs0.TabIndex = 4;
            this.LLearningEpochs0.Text = "Total learning epochs:";
            this.LLearningEpochs0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BSelectFile
            // 
            this.BSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BSelectFile.Location = new System.Drawing.Point(182, 115);
            this.BSelectFile.Name = "BSelectFile";
            this.BSelectFile.Size = new System.Drawing.Size(143, 38);
            this.BSelectFile.TabIndex = 1;
            this.BSelectFile.Text = "Load file...";
            this.BSelectFile.UseVisualStyleBackColor = true;
            this.BSelectFile.Click += new System.EventHandler(this.BSelectFile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BSelectFile);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 163);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "You can load training data from file. Input signals and correct output signals mu" +
    "st correspond to the following format:\r\n{ x1,x2,x3:y1,y2,y3 }, where x - input s" +
    "ignal, y - correct output signal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.groupBox1.Controls.Add(this.LCompleted1);
            this.groupBox1.Controls.Add(this.LLearningEpochs0);
            this.groupBox1.Controls.Add(this.LCompleted0);
            this.groupBox1.Controls.Add(this.CBRandomize);
            this.groupBox1.Controls.Add(this.LLearningRate);
            this.groupBox1.Controls.Add(this.NUDLearningRate);
            this.groupBox1.Controls.Add(this.LEpochs);
            this.groupBox1.Controls.Add(this.NUDEpochs);
            this.groupBox1.Controls.Add(this.CLearningChart);
            this.groupBox1.Controls.Add(this.BLearn);
            this.groupBox1.Controls.Add(this.PBLearningProgress);
            this.groupBox1.Location = new System.Drawing.Point(541, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 616);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // LEndError1
            // 
            this.LEndError1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LEndError1.AutoSize = true;
            this.LEndError1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEndError1.ForeColor = System.Drawing.Color.Red;
            this.LEndError1.Location = new System.Drawing.Point(506, 358);
            this.LEndError1.Name = "LEndError1";
            this.LEndError1.Size = new System.Drawing.Size(18, 20);
            this.LEndError1.TabIndex = 13;
            this.LEndError1.Text = "0";
            // 
            // LStartError1
            // 
            this.LStartError1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LStartError1.AutoSize = true;
            this.LStartError1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStartError1.ForeColor = System.Drawing.Color.Red;
            this.LStartError1.Location = new System.Drawing.Point(506, 328);
            this.LStartError1.Name = "LStartError1";
            this.LStartError1.Size = new System.Drawing.Size(18, 20);
            this.LStartError1.TabIndex = 12;
            this.LStartError1.Text = "0";
            // 
            // LEndError0
            // 
            this.LEndError0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LEndError0.AutoSize = true;
            this.LEndError0.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEndError0.Location = new System.Drawing.Point(390, 358);
            this.LEndError0.Name = "LEndError0";
            this.LEndError0.Size = new System.Drawing.Size(99, 20);
            this.LEndError0.TabIndex = 11;
            this.LEndError0.Text = "End error:";
            // 
            // LStartError0
            // 
            this.LStartError0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LStartError0.AutoSize = true;
            this.LStartError0.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStartError0.Location = new System.Drawing.Point(372, 328);
            this.LStartError0.Name = "LStartError0";
            this.LStartError0.Size = new System.Drawing.Size(117, 20);
            this.LStartError0.TabIndex = 10;
            this.LStartError0.Text = "Start error:";
            // 
            // LCompleted1
            // 
            this.LCompleted1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LCompleted1.AutoSize = true;
            this.LCompleted1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCompleted1.ForeColor = System.Drawing.Color.Green;
            this.LCompleted1.Location = new System.Drawing.Point(192, 507);
            this.LCompleted1.Name = "LCompleted1";
            this.LCompleted1.Size = new System.Drawing.Size(18, 20);
            this.LCompleted1.TabIndex = 9;
            this.LCompleted1.Text = "0";
            // 
            // LCompleted0
            // 
            this.LCompleted0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LCompleted0.AutoSize = true;
            this.LCompleted0.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCompleted0.Location = new System.Drawing.Point(6, 507);
            this.LCompleted0.Name = "LCompleted0";
            this.LCompleted0.Size = new System.Drawing.Size(162, 20);
            this.LCompleted0.TabIndex = 8;
            this.LCompleted0.Text = "Completed epochs:";
            // 
            // CBRandomize
            // 
            this.CBRandomize.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CBRandomize.AutoSize = true;
            this.CBRandomize.Checked = true;
            this.CBRandomize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBRandomize.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBRandomize.Location = new System.Drawing.Point(10, 412);
            this.CBRandomize.Name = "CBRandomize";
            this.CBRandomize.Size = new System.Drawing.Size(238, 44);
            this.CBRandomize.TabIndex = 6;
            this.CBRandomize.Text = "Randomize input signals\r\nat each epoch";
            this.CBRandomize.UseVisualStyleBackColor = true;
            // 
            // LLearningRate
            // 
            this.LLearningRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.NUDLearningRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.NUDLearningRate.TabIndex = 4;
            this.NUDLearningRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // LEpochs
            // 
            this.LEpochs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LEpochs.AutoSize = true;
            this.LEpochs.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEpochs.Location = new System.Drawing.Point(178, 328);
            this.LEpochs.Name = "LEpochs";
            this.LEpochs.Size = new System.Drawing.Size(63, 20);
            this.LEpochs.TabIndex = 4;
            this.LEpochs.Text = "Epochs";
            // 
            // NUDEpochs
            // 
            this.NUDEpochs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.NUDEpochs.TabIndex = 5;
            this.NUDEpochs.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
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
            this.CLearningChart.Visible = false;
            // 
            // BLearn
            // 
            this.BLearn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BLearn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BLearn.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLearn.Location = new System.Drawing.Point(528, 529);
            this.BLearn.Name = "BLearn";
            this.BLearn.Size = new System.Drawing.Size(92, 38);
            this.BLearn.TabIndex = 7;
            this.BLearn.Text = "Learn";
            this.BLearn.UseVisualStyleBackColor = true;
            this.BLearn.Click += new System.EventHandler(this.BLearn_Click);
            // 
            // PBLearningProgress
            // 
            this.PBLearningProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PBLearningProgress.Location = new System.Drawing.Point(6, 573);
            this.PBLearningProgress.Name = "PBLearningProgress";
            this.PBLearningProgress.Size = new System.Drawing.Size(614, 37);
            this.PBLearningProgress.TabIndex = 0;
            // 
            // DGVCorrectOutputSignals
            // 
            this.DGVCorrectOutputSignals.AllowUserToAddRows = false;
            this.DGVCorrectOutputSignals.AllowUserToDeleteRows = false;
            this.DGVCorrectOutputSignals.AllowUserToOrderColumns = true;
            this.DGVCorrectOutputSignals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVCorrectOutputSignals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCorrectOutputSignals.ColumnHeadersVisible = false;
            this.DGVCorrectOutputSignals.Location = new System.Drawing.Point(264, 3);
            this.DGVCorrectOutputSignals.Name = "DGVCorrectOutputSignals";
            this.DGVCorrectOutputSignals.RowHeadersVisible = false;
            this.DGVCorrectOutputSignals.RowTemplate.Height = 24;
            this.DGVCorrectOutputSignals.Size = new System.Drawing.Size(256, 367);
            this.DGVCorrectOutputSignals.TabIndex = 10;
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
            this.tableLayoutPanel1.Controls.Add(this.DGVCorrectOutputSignals, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DGVInputSignals, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 252);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(523, 373);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // NFBRandomize1
            // 
            this.NFBRandomize1.BackColor = System.Drawing.Color.Transparent;
            this.NFBRandomize1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NFBRandomize1.BackgroundImage")));
            this.NFBRandomize1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NFBRandomize1.FlatAppearance.BorderSize = 0;
            this.NFBRandomize1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.NFBRandomize1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.NFBRandomize1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NFBRandomize1.Location = new System.Drawing.Point(163, 219);
            this.NFBRandomize1.Name = "NFBRandomize1";
            this.NFBRandomize1.Size = new System.Drawing.Size(34, 30);
            this.NFBRandomize1.TabIndex = 17;
            this.NFBRandomize1.UseVisualStyleBackColor = false;
            this.NFBRandomize1.Click += new System.EventHandler(this.NFBRandomize1_Click);
            // 
            // NFBSave
            // 
            this.NFBSave.BackColor = System.Drawing.Color.Transparent;
            this.NFBSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NFBSave.BackgroundImage")));
            this.NFBSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NFBSave.FlatAppearance.BorderSize = 0;
            this.NFBSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.NFBSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.NFBSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NFBSave.Location = new System.Drawing.Point(12, 219);
            this.NFBSave.Name = "NFBSave";
            this.NFBSave.Size = new System.Drawing.Size(34, 30);
            this.NFBSave.TabIndex = 16;
            this.NFBSave.UseVisualStyleBackColor = false;
            this.NFBSave.Click += new System.EventHandler(this.NFBSave_Click);
            // 
            // NFBRandomize0
            // 
            this.NFBRandomize0.BackColor = System.Drawing.Color.Transparent;
            this.NFBRandomize0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NFBRandomize0.BackgroundImage")));
            this.NFBRandomize0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NFBRandomize0.FlatAppearance.BorderSize = 0;
            this.NFBRandomize0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.NFBRandomize0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.NFBRandomize0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NFBRandomize0.Location = new System.Drawing.Point(123, 219);
            this.NFBRandomize0.Name = "NFBRandomize0";
            this.NFBRandomize0.Size = new System.Drawing.Size(34, 30);
            this.NFBRandomize0.TabIndex = 15;
            this.NFBRandomize0.UseVisualStyleBackColor = false;
            this.NFBRandomize0.Click += new System.EventHandler(this.NFBRandomize0_Click);
            // 
            // NFBSaveAs
            // 
            this.NFBSaveAs.BackColor = System.Drawing.Color.Transparent;
            this.NFBSaveAs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NFBSaveAs.BackgroundImage")));
            this.NFBSaveAs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NFBSaveAs.FlatAppearance.BorderSize = 0;
            this.NFBSaveAs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.NFBSaveAs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.NFBSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NFBSaveAs.Location = new System.Drawing.Point(52, 219);
            this.NFBSaveAs.Name = "NFBSaveAs";
            this.NFBSaveAs.Size = new System.Drawing.Size(34, 30);
            this.NFBSaveAs.TabIndex = 14;
            this.NFBSaveAs.UseVisualStyleBackColor = false;
            this.NFBSaveAs.Click += new System.EventHandler(this.NFBSaveAs_Click);
            // 
            // NFBRemove
            // 
            this.NFBRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NFBRemove.BackColor = System.Drawing.Color.Transparent;
            this.NFBRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NFBRemove.BackgroundImage")));
            this.NFBRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NFBRemove.FlatAppearance.BorderSize = 0;
            this.NFBRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.NFBRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.NFBRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NFBRemove.Location = new System.Drawing.Point(501, 219);
            this.NFBRemove.Name = "NFBRemove";
            this.NFBRemove.Size = new System.Drawing.Size(34, 30);
            this.NFBRemove.TabIndex = 13;
            this.NFBRemove.UseVisualStyleBackColor = false;
            this.NFBRemove.Click += new System.EventHandler(this.NFBRemove_Click);
            // 
            // NFBAdd
            // 
            this.NFBAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NFBAdd.BackColor = System.Drawing.Color.Transparent;
            this.NFBAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NFBAdd.BackgroundImage")));
            this.NFBAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NFBAdd.FlatAppearance.BorderSize = 0;
            this.NFBAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.NFBAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.NFBAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NFBAdd.Location = new System.Drawing.Point(461, 219);
            this.NFBAdd.Name = "NFBAdd";
            this.NFBAdd.Size = new System.Drawing.Size(34, 30);
            this.NFBAdd.TabIndex = 12;
            this.NFBAdd.UseVisualStyleBackColor = false;
            this.NFBAdd.Click += new System.EventHandler(this.NFBAdd_Click);
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 637);
            this.Controls.Add(this.NFBRandomize1);
            this.Controls.Add(this.NFBSave);
            this.Controls.Add(this.NFBRandomize0);
            this.Controls.Add(this.NFBSaveAs);
            this.Controls.Add(this.NFBRemove);
            this.Controls.Add(this.NFBAdd);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.NUDLearningRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEpochs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLearningChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCorrectOutputSignals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInputSignals)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LCreationDate0;
        private System.Windows.Forms.Label LLearningEpochs1;
        private System.Windows.Forms.Label LLearningEpochs0;
        private System.Windows.Forms.Button BSelectFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVInputSignals;
        private System.Windows.Forms.DataGridView DGVCorrectOutputSignals;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart CLearningChart;
        private System.Windows.Forms.Button BLearn;
        private System.Windows.Forms.ProgressBar PBLearningProgress;
        private System.Windows.Forms.Label LLearningRate;
        private System.Windows.Forms.NumericUpDown NUDLearningRate;
        private System.Windows.Forms.Label LEpochs;
        private System.Windows.Forms.NumericUpDown NUDEpochs;
        private System.Windows.Forms.CheckBox CBRandomize;
        private System.Windows.Forms.Label LCompleted1;
        private System.Windows.Forms.Label LCompleted0;
        private System.Windows.Forms.Label LEndError1;
        private System.Windows.Forms.Label LStartError1;
        private System.Windows.Forms.Label LEndError0;
        private System.Windows.Forms.Label LStartError0;
        private Shared.Controls.NonFocusButton NFBAdd;
        private Shared.Controls.NonFocusButton NFBRemove;
        private Shared.Controls.NonFocusButton NFBSaveAs;
        private Shared.Controls.NonFocusButton NFBRandomize0;
        private Shared.Controls.NonFocusButton NFBSave;
        private Shared.Controls.NonFocusButton NFBRandomize1;
    }
}
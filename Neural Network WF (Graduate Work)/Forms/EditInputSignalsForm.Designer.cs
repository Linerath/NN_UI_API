namespace Neural_Network_WF__Graduate_Work_.Forms
{
    partial class EditInputSignalsForm
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
            this.DGVInputSignals = new System.Windows.Forms.DataGridView();
            this.CBAdaptCellSize = new System.Windows.Forms.CheckBox();
            this.CBAdaptFormSize = new System.Windows.Forms.CheckBox();
            this.NUDFontSize = new System.Windows.Forms.NumericUpDown();
            this.LFontSize = new System.Windows.Forms.Label();
            this.BGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInputSignals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVInputSignals
            // 
            this.DGVInputSignals.AllowUserToAddRows = false;
            this.DGVInputSignals.AllowUserToDeleteRows = false;
            this.DGVInputSignals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInputSignals.ColumnHeadersVisible = false;
            this.DGVInputSignals.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGVInputSignals.Location = new System.Drawing.Point(0, 0);
            this.DGVInputSignals.Name = "DGVInputSignals";
            this.DGVInputSignals.RowHeadersVisible = false;
            this.DGVInputSignals.RowTemplate.Height = 24;
            this.DGVInputSignals.Size = new System.Drawing.Size(402, 147);
            this.DGVInputSignals.TabIndex = 0;
            this.DGVInputSignals.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVInputSignals_CellEndEdit);
            // 
            // CBAdaptCellSize
            // 
            this.CBAdaptCellSize.AutoSize = true;
            this.CBAdaptCellSize.Checked = true;
            this.CBAdaptCellSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBAdaptCellSize.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAdaptCellSize.Location = new System.Drawing.Point(12, 171);
            this.CBAdaptCellSize.Name = "CBAdaptCellSize";
            this.CBAdaptCellSize.Size = new System.Drawing.Size(150, 22);
            this.CBAdaptCellSize.TabIndex = 1;
            this.CBAdaptCellSize.Text = "Adapt cell size";
            this.CBAdaptCellSize.UseVisualStyleBackColor = true;
            this.CBAdaptCellSize.CheckedChanged += new System.EventHandler(this.CBAdaptCellSize_CheckedChanged);
            // 
            // CBAdaptFormSize
            // 
            this.CBAdaptFormSize.AutoSize = true;
            this.CBAdaptFormSize.Checked = true;
            this.CBAdaptFormSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBAdaptFormSize.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAdaptFormSize.Location = new System.Drawing.Point(12, 199);
            this.CBAdaptFormSize.Name = "CBAdaptFormSize";
            this.CBAdaptFormSize.Size = new System.Drawing.Size(150, 22);
            this.CBAdaptFormSize.TabIndex = 2;
            this.CBAdaptFormSize.Text = "Adapt form size";
            this.CBAdaptFormSize.UseVisualStyleBackColor = true;
            // 
            // NUDFontSize
            // 
            this.NUDFontSize.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDFontSize.Location = new System.Drawing.Point(225, 196);
            this.NUDFontSize.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.NUDFontSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDFontSize.Name = "NUDFontSize";
            this.NUDFontSize.Size = new System.Drawing.Size(50, 27);
            this.NUDFontSize.TabIndex = 3;
            this.NUDFontSize.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.NUDFontSize.ValueChanged += new System.EventHandler(this.NUDFontSize_ValueChanged);
            // 
            // LFontSize
            // 
            this.LFontSize.AutoSize = true;
            this.LFontSize.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFontSize.Location = new System.Drawing.Point(208, 171);
            this.LFontSize.Name = "LFontSize";
            this.LFontSize.Size = new System.Drawing.Size(88, 18);
            this.LFontSize.TabIndex = 4;
            this.LFontSize.Text = "Font size:";
            // 
            // BGo
            // 
            this.BGo.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGo.Location = new System.Drawing.Point(318, 191);
            this.BGo.Name = "BGo";
            this.BGo.Size = new System.Drawing.Size(72, 35);
            this.BGo.TabIndex = 5;
            this.BGo.Text = "GO";
            this.BGo.UseVisualStyleBackColor = true;
            this.BGo.Click += new System.EventHandler(this.BGo_Click);
            // 
            // EditInputSignalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.BGo);
            this.Controls.Add(this.LFontSize);
            this.Controls.Add(this.NUDFontSize);
            this.Controls.Add(this.CBAdaptFormSize);
            this.Controls.Add(this.CBAdaptCellSize);
            this.Controls.Add(this.DGVInputSignals);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 293);
            this.Name = "EditInputSignalsForm";
            this.Text = "EditInputSignalsForm";
            this.Load += new System.EventHandler(this.EditInputSignalsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVInputSignals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVInputSignals;
        private System.Windows.Forms.CheckBox CBAdaptCellSize;
        private System.Windows.Forms.CheckBox CBAdaptFormSize;
        private System.Windows.Forms.NumericUpDown NUDFontSize;
        private System.Windows.Forms.Label LFontSize;
        private System.Windows.Forms.Button BGo;
    }
}
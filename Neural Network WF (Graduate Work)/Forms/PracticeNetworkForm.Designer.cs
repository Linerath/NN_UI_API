namespace Neural_Network_WF__Graduate_Work_.Forms
{
    partial class PracticeNetworkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PracticeNetworkForm));
            this.BLoad = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LInfo1 = new System.Windows.Forms.Label();
            this.BInput = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            this.LFile = new System.Windows.Forms.Label();
            this.BCreateProject = new System.Windows.Forms.Button();
            this.BOpenProject = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BLoad
            // 
            this.BLoad.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLoad.Location = new System.Drawing.Point(207, 191);
            this.BLoad.Name = "BLoad";
            this.BLoad.Size = new System.Drawing.Size(150, 43);
            this.BLoad.TabIndex = 1;
            this.BLoad.Text = "Load file";
            this.BLoad.UseVisualStyleBackColor = true;
            this.BLoad.Click += new System.EventHandler(this.BLoad_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LInfo1);
            this.groupBox3.Controls.Add(this.BInput);
            this.groupBox3.Controls.Add(this.LFile);
            this.groupBox3.Controls.Add(this.BLoad);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 290);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // LInfo1
            // 
            this.LInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.LInfo1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInfo1.Location = new System.Drawing.Point(3, 23);
            this.LInfo1.Name = "LInfo1";
            this.LInfo1.Size = new System.Drawing.Size(554, 116);
            this.LInfo1.TabIndex = 3;
            this.LInfo1.Text = resources.GetString("LInfo1.Text");
            this.LInfo1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BInput
            // 
            this.BInput.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BInput.Location = new System.Drawing.Point(207, 142);
            this.BInput.Name = "BInput";
            this.BInput.Size = new System.Drawing.Size(150, 43);
            this.BInput.TabIndex = 0;
            this.BInput.Text = "Manual Input";
            this.BInput.UseVisualStyleBackColor = true;
            this.BInput.Click += new System.EventHandler(this.BInput_Click);
            // 
            // BBack
            // 
            this.BBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBack.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBack.Location = new System.Drawing.Point(12, 576);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(75, 33);
            this.BBack.TabIndex = 3;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = true;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // LFile
            // 
            this.LFile.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFile.ForeColor = System.Drawing.Color.Red;
            this.LFile.Location = new System.Drawing.Point(6, 250);
            this.LFile.Name = "LFile";
            this.LFile.Size = new System.Drawing.Size(548, 25);
            this.LFile.TabIndex = 5;
            this.LFile.Text = "asdasdasdasd";
            this.LFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BCreateProject
            // 
            this.BCreateProject.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCreateProject.Location = new System.Drawing.Point(106, 124);
            this.BCreateProject.Name = "BCreateProject";
            this.BCreateProject.Size = new System.Drawing.Size(170, 43);
            this.BCreateProject.TabIndex = 6;
            this.BCreateProject.Text = "Create project";
            this.BCreateProject.UseVisualStyleBackColor = true;
            this.BCreateProject.Click += new System.EventHandler(this.BCreateProject_Click);
            // 
            // BOpenProject
            // 
            this.BOpenProject.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOpenProject.Location = new System.Drawing.Point(106, 173);
            this.BOpenProject.Name = "BOpenProject";
            this.BOpenProject.Size = new System.Drawing.Size(170, 43);
            this.BOpenProject.TabIndex = 7;
            this.BOpenProject.Text = "Open project";
            this.BOpenProject.UseVisualStyleBackColor = true;
            this.BOpenProject.Click += new System.EventHandler(this.BOpenProject_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BCreateProject);
            this.groupBox1.Controls.Add(this.BOpenProject);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(93, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 244);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 85);
            this.label1.TabIndex = 8;
            this.label1.Text = "You can make your own project based on the current network. Through project your " +
    "can create names and manual titles. This is useful for abstraction from only dig" +
    "its.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PracticeNetworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 615);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PracticeNetworkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PracticeNetworkForm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BLoad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BInput;
        private System.Windows.Forms.Label LInfo1;
        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.Label LFile;
        private System.Windows.Forms.Button BCreateProject;
        private System.Windows.Forms.Button BOpenProject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}
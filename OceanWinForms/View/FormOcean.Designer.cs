namespace OceanWinForms.View
{
    partial class FormOcean
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOcean));
            this.tbPreyInput = new System.Windows.Forms.TextBox();
            this.tbPredInput = new System.Windows.Forms.TextBox();
            this.tbObstInput = new System.Windows.Forms.TextBox();
            this.tbIterInput = new System.Windows.Forms.TextBox();
            this.lbOceanField = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btCreate = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDemandInput = new System.Windows.Forms.Label();
            this.btStop = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbIterCounter = new System.Windows.Forms.Label();
            this.lbPredStats = new System.Windows.Forms.Label();
            this.lbPreyStats = new System.Windows.Forms.Label();
            this.tbIterCounter = new System.Windows.Forms.TextBox();
            this.tbPredStats = new System.Windows.Forms.TextBox();
            this.tbPreyStats = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPreyInput
            // 
            this.tbPreyInput.Location = new System.Drawing.Point(149, 485);
            this.tbPreyInput.Name = "tbPreyInput";
            this.tbPreyInput.Size = new System.Drawing.Size(100, 31);
            this.tbPreyInput.TabIndex = 0;
            // 
            // tbPredInput
            // 
            this.tbPredInput.Location = new System.Drawing.Point(149, 551);
            this.tbPredInput.Name = "tbPredInput";
            this.tbPredInput.Size = new System.Drawing.Size(100, 31);
            this.tbPredInput.TabIndex = 0;
            // 
            // tbObstInput
            // 
            this.tbObstInput.Location = new System.Drawing.Point(149, 618);
            this.tbObstInput.Name = "tbObstInput";
            this.tbObstInput.Size = new System.Drawing.Size(100, 31);
            this.tbObstInput.TabIndex = 0;
            // 
            // tbIterInput
            // 
            this.tbIterInput.Location = new System.Drawing.Point(149, 679);
            this.tbIterInput.Name = "tbIterInput";
            this.tbIterInput.Size = new System.Drawing.Size(100, 31);
            this.tbIterInput.TabIndex = 0;
            // 
            // lbOceanField
            // 
            this.lbOceanField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOceanField.AutoSize = true;
            this.lbOceanField.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOceanField.Location = new System.Drawing.Point(368, 177);
            this.lbOceanField.Name = "lbOceanField";
            this.lbOceanField.Size = new System.Drawing.Size(215, 37);
            this.lbOceanField.TabIndex = 1;
            this.lbOceanField.Text = "Ocean Field";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(43, 43);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(180, 65);
            this.btCreate.TabIndex = 2;
            this.btCreate.Text = "Create Ocean";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.CreateOcean_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(43, 114);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(180, 65);
            this.btStart.TabIndex = 3;
            this.btStart.Text = "Start ";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.StartProcess_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbDemandInput);
            this.panel1.Controls.Add(this.btStop);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.btCreate);
            this.panel1.Controls.Add(this.tbPreyInput);
            this.panel1.Controls.Add(this.tbPredInput);
            this.panel1.Controls.Add(this.tbObstInput);
            this.panel1.Controls.Add(this.tbIterInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1406, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 1094);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 685);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Iterations:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 624);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Obstacles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Predators:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prey:";
            // 
            // lbDemandInput
            // 
            this.lbDemandInput.AutoSize = true;
            this.lbDemandInput.Location = new System.Drawing.Point(34, 420);
            this.lbDemandInput.Name = "lbDemandInput";
            this.lbDemandInput.Size = new System.Drawing.Size(190, 25);
            this.lbDemandInput.TabIndex = 5;
            this.lbDemandInput.Text = "Input initial values:";
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(43, 185);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(180, 65);
            this.btStop.TabIndex = 4;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.StopProcess_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(656, 141);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbOceanField);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1406, 1094);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbIterCounter);
            this.panel3.Controls.Add(this.lbPredStats);
            this.panel3.Controls.Add(this.lbPreyStats);
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.tbIterCounter);
            this.panel3.Controls.Add(this.tbPredStats);
            this.panel3.Controls.Add(this.tbPreyStats);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 917);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1406, 177);
            this.panel3.TabIndex = 2;
            // 
            // lbIterCounter
            // 
            this.lbIterCounter.AutoSize = true;
            this.lbIterCounter.Location = new System.Drawing.Point(661, 56);
            this.lbIterCounter.Name = "lbIterCounter";
            this.lbIterCounter.Size = new System.Drawing.Size(95, 25);
            this.lbIterCounter.TabIndex = 3;
            this.lbIterCounter.Text = "Iteration:";
            // 
            // lbPredStats
            // 
            this.lbPredStats.AutoSize = true;
            this.lbPredStats.Location = new System.Drawing.Point(394, 56);
            this.lbPredStats.Name = "lbPredStats";
            this.lbPredStats.Size = new System.Drawing.Size(111, 25);
            this.lbPredStats.TabIndex = 3;
            this.lbPredStats.Text = "Predators:";
            // 
            // lbPreyStats
            // 
            this.lbPreyStats.AutoSize = true;
            this.lbPreyStats.Location = new System.Drawing.Point(142, 56);
            this.lbPreyStats.Name = "lbPreyStats";
            this.lbPreyStats.Size = new System.Drawing.Size(62, 25);
            this.lbPreyStats.TabIndex = 3;
            this.lbPreyStats.Text = "Prey:";
            // 
            // tbIterCounter
            // 
            this.tbIterCounter.Location = new System.Drawing.Point(656, 90);
            this.tbIterCounter.Name = "tbIterCounter";
            this.tbIterCounter.Size = new System.Drawing.Size(100, 31);
            this.tbIterCounter.TabIndex = 2;
            this.tbIterCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPredStats
            // 
            this.tbPredStats.Location = new System.Drawing.Point(399, 90);
            this.tbPredStats.Name = "tbPredStats";
            this.tbPredStats.Size = new System.Drawing.Size(100, 31);
            this.tbPredStats.TabIndex = 1;
            this.tbPredStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPreyStats
            // 
            this.tbPreyStats.Location = new System.Drawing.Point(131, 90);
            this.tbPreyStats.Name = "tbPreyStats";
            this.tbPreyStats.Size = new System.Drawing.Size(100, 31);
            this.tbPreyStats.TabIndex = 0;
            this.tbPreyStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormOcean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1668, 1094);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOcean";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOcean";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPreyInput;
        private System.Windows.Forms.TextBox tbPredInput;
        private System.Windows.Forms.TextBox tbObstInput;
        private System.Windows.Forms.TextBox tbIterInput;
        private System.Windows.Forms.Label lbOceanField;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbIterCounter;
        private System.Windows.Forms.TextBox tbPredStats;
        private System.Windows.Forms.TextBox tbPreyStats;
        private System.Windows.Forms.Label lbIterCounter;
        private System.Windows.Forms.Label lbPredStats;
        private System.Windows.Forms.Label lbPreyStats;
        private System.Windows.Forms.Label lbDemandInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
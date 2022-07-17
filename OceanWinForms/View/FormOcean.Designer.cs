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
            this.lbOceanField = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btCreate = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lbPreyStats = new System.Windows.Forms.Label();
            this.lbPredStats = new System.Windows.Forms.Label();
            this.tbPreyStats = new System.Windows.Forms.TextBox();
            this.lbIterCounter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPredStats = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIterCounter = new System.Windows.Forms.TextBox();
            this.lbDemandInput = new System.Windows.Forms.Label();
            this.btStop = new System.Windows.Forms.Button();
            this.panelOceanField = new System.Windows.Forms.Panel();
            this.lbStatsMessage = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelOceanField.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbOceanField
            // 
            this.lbOceanField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOceanField.AutoSize = true;
            this.lbOceanField.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOceanField.Location = new System.Drawing.Point(3, 9);
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
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.progressBar1);
            this.panelMenu.Controls.Add(this.tbIterCounter);
            this.panelMenu.Controls.Add(this.lbIterCounter);
            this.panelMenu.Controls.Add(this.tbPreyStats);
            this.panelMenu.Controls.Add(this.tbPredStats);
            this.panelMenu.Controls.Add(this.lbPreyStats);
            this.panelMenu.Controls.Add(this.lbStatsMessage);
            this.panelMenu.Controls.Add(this.maskedTextBox4);
            this.panelMenu.Controls.Add(this.lbPredStats);
            this.panelMenu.Controls.Add(this.maskedTextBox3);
            this.panelMenu.Controls.Add(this.maskedTextBox2);
            this.panelMenu.Controls.Add(this.maskedTextBox1);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.lbDemandInput);
            this.panelMenu.Controls.Add(this.btStop);
            this.panelMenu.Controls.Add(this.btStart);
            this.panelMenu.Controls.Add(this.btCreate);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(1312, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(262, 1129);
            this.panelMenu.TabIndex = 4;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.BeepOnError = true;
            this.maskedTextBox4.HidePromptOnLeave = true;
            this.maskedTextBox4.Location = new System.Drawing.Point(149, 679);
            this.maskedTextBox4.Mask = "000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 31);
            this.maskedTextBox4.TabIndex = 7;
            this.maskedTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox4.ValidatingType = typeof(int);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.BeepOnError = true;
            this.maskedTextBox3.HidePromptOnLeave = true;
            this.maskedTextBox3.Location = new System.Drawing.Point(149, 618);
            this.maskedTextBox3.Mask = "000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 31);
            this.maskedTextBox3.TabIndex = 7;
            this.maskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox3.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BeepOnError = true;
            this.maskedTextBox2.HidePromptOnLeave = true;
            this.maskedTextBox2.Location = new System.Drawing.Point(149, 551);
            this.maskedTextBox2.Mask = "000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 31);
            this.maskedTextBox2.TabIndex = 7;
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BeepOnError = true;
            this.maskedTextBox1.HidePromptOnLeave = true;
            this.maskedTextBox1.Location = new System.Drawing.Point(149, 485);
            this.maskedTextBox1.Mask = "000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 31);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // lbPreyStats
            // 
            this.lbPreyStats.AutoSize = true;
            this.lbPreyStats.Location = new System.Drawing.Point(25, 866);
            this.lbPreyStats.Name = "lbPreyStats";
            this.lbPreyStats.Size = new System.Drawing.Size(62, 25);
            this.lbPreyStats.TabIndex = 3;
            this.lbPreyStats.Text = "Prey:";
            // 
            // lbPredStats
            // 
            this.lbPredStats.AutoSize = true;
            this.lbPredStats.Location = new System.Drawing.Point(25, 935);
            this.lbPredStats.Name = "lbPredStats";
            this.lbPredStats.Size = new System.Drawing.Size(111, 25);
            this.lbPredStats.TabIndex = 3;
            this.lbPredStats.Text = "Predators:";
            // 
            // tbPreyStats
            // 
            this.tbPreyStats.Location = new System.Drawing.Point(149, 863);
            this.tbPreyStats.Name = "tbPreyStats";
            this.tbPreyStats.Size = new System.Drawing.Size(100, 31);
            this.tbPreyStats.TabIndex = 0;
            this.tbPreyStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbIterCounter
            // 
            this.lbIterCounter.AutoSize = true;
            this.lbIterCounter.Location = new System.Drawing.Point(25, 994);
            this.lbIterCounter.Name = "lbIterCounter";
            this.lbIterCounter.Size = new System.Drawing.Size(95, 25);
            this.lbIterCounter.TabIndex = 3;
            this.lbIterCounter.Text = "Iteration:";
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
            // tbPredStats
            // 
            this.tbPredStats.Location = new System.Drawing.Point(149, 932);
            this.tbPredStats.Name = "tbPredStats";
            this.tbPredStats.Size = new System.Drawing.Size(100, 31);
            this.tbPredStats.TabIndex = 1;
            this.tbPredStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(149, 1041);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 20);
            this.progressBar1.TabIndex = 2;
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
            // tbIterCounter
            // 
            this.tbIterCounter.Location = new System.Drawing.Point(149, 994);
            this.tbIterCounter.Name = "tbIterCounter";
            this.tbIterCounter.Size = new System.Drawing.Size(100, 31);
            this.tbIterCounter.TabIndex = 2;
            this.tbIterCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // panelOceanField
            // 
            this.panelOceanField.Controls.Add(this.lbOceanField);
            this.panelOceanField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOceanField.Location = new System.Drawing.Point(0, 0);
            this.panelOceanField.Name = "panelOceanField";
            this.panelOceanField.Size = new System.Drawing.Size(1312, 1129);
            this.panelOceanField.TabIndex = 5;
            // 
            // lbStatsMessage
            // 
            this.lbStatsMessage.AutoSize = true;
            this.lbStatsMessage.Location = new System.Drawing.Point(68, 816);
            this.lbStatsMessage.Name = "lbStatsMessage";
            this.lbStatsMessage.Size = new System.Drawing.Size(132, 25);
            this.lbStatsMessage.TabIndex = 0;
            this.lbStatsMessage.Text = "STATISTICS";
            // 
            // FormOcean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1574, 1129);
            this.Controls.Add(this.panelOceanField);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOcean";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOcean";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelOceanField.ResumeLayout(false);
            this.panelOceanField.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbOceanField;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelOceanField;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.ProgressBar progressBar1;
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
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label lbStatsMessage;
    }
}
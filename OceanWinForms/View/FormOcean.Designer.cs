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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btCreate = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.lbMenu = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.panelStats = new System.Windows.Forms.Panel();
            this.tbIterCounter = new System.Windows.Forms.TextBox();
            this.lbStatsMessage = new System.Windows.Forms.Label();
            this.tbPreyStats = new System.Windows.Forms.TextBox();
            this.lbPreyStats = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbPredStats = new System.Windows.Forms.Label();
            this.tbPredStats = new System.Windows.Forms.TextBox();
            this.lbIterCounter = new System.Windows.Forms.Label();
            this.tbInputIter = new System.Windows.Forms.MaskedTextBox();
            this.tbInputObst = new System.Windows.Forms.MaskedTextBox();
            this.tbInputPred = new System.Windows.Forms.MaskedTextBox();
            this.tbInputPrey = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDemandInput = new System.Windows.Forms.Label();
            this.panelOceanField = new System.Windows.Forms.Panel();
            this.LayoutOceanField = new System.Windows.Forms.TableLayoutPanel();
            this.panelMenu.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.panelOceanField.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btCreate
            // 
            this.btCreate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btCreate.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCreate.Location = new System.Drawing.Point(70, 85);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(192, 88);
            this.btCreate.TabIndex = 2;
            this.btCreate.Text = "Create Ocean";
            this.btCreate.UseVisualStyleBackColor = false;
            this.btCreate.Click += new System.EventHandler(this.CreateOcean_Click);
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btStart.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(70, 179);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(192, 88);
            this.btStart.TabIndex = 3;
            this.btStart.Text = "Start ";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.StartProcess_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.panelButtons);
            this.panelMenu.Controls.Add(this.panelStats);
            this.panelMenu.Controls.Add(this.tbInputIter);
            this.panelMenu.Controls.Add(this.tbInputObst);
            this.panelMenu.Controls.Add(this.tbInputPred);
            this.panelMenu.Controls.Add(this.tbInputPrey);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.lbDemandInput);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(1271, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(303, 1254);
            this.panelMenu.TabIndex = 4;
            // 
            // panelButtons
            // 
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.lbMenu);
            this.panelButtons.Controls.Add(this.btCreate);
            this.panelButtons.Controls.Add(this.btStart);
            this.panelButtons.Controls.Add(this.btExit);
            this.panelButtons.Controls.Add(this.btStop);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(301, 474);
            this.panelButtons.TabIndex = 9;
            // 
            // lbMenu
            // 
            this.lbMenu.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMenu.Location = new System.Drawing.Point(44, 17);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(239, 46);
            this.lbMenu.TabIndex = 5;
            this.lbMenu.Text = "MENU\r\n";
            this.lbMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btExit.Font = new System.Drawing.Font("Consolas", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.Location = new System.Drawing.Point(70, 367);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(192, 88);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btStop.Font = new System.Drawing.Font("Consolas", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStop.Location = new System.Drawing.Point(70, 273);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(192, 88);
            this.btStop.TabIndex = 4;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.StopProcess_Click);
            // 
            // panelStats
            // 
            this.panelStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStats.Controls.Add(this.tbIterCounter);
            this.panelStats.Controls.Add(this.lbStatsMessage);
            this.panelStats.Controls.Add(this.tbPreyStats);
            this.panelStats.Controls.Add(this.lbPreyStats);
            this.panelStats.Controls.Add(this.progressBar1);
            this.panelStats.Controls.Add(this.lbPredStats);
            this.panelStats.Controls.Add(this.tbPredStats);
            this.panelStats.Controls.Add(this.lbIterCounter);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStats.Location = new System.Drawing.Point(0, 870);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(301, 382);
            this.panelStats.TabIndex = 8;
            // 
            // tbIterCounter
            // 
            this.tbIterCounter.Location = new System.Drawing.Point(170, 214);
            this.tbIterCounter.Name = "tbIterCounter";
            this.tbIterCounter.Size = new System.Drawing.Size(100, 31);
            this.tbIterCounter.TabIndex = 2;
            this.tbIterCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbStatsMessage
            // 
            this.lbStatsMessage.AutoSize = true;
            this.lbStatsMessage.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStatsMessage.Location = new System.Drawing.Point(63, 26);
            this.lbStatsMessage.Name = "lbStatsMessage";
            this.lbStatsMessage.Size = new System.Drawing.Size(197, 37);
            this.lbStatsMessage.TabIndex = 0;
            this.lbStatsMessage.Text = "STATISTICS";
            // 
            // tbPreyStats
            // 
            this.tbPreyStats.Location = new System.Drawing.Point(170, 99);
            this.tbPreyStats.Name = "tbPreyStats";
            this.tbPreyStats.Size = new System.Drawing.Size(100, 31);
            this.tbPreyStats.TabIndex = 0;
            this.tbPreyStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbPreyStats
            // 
            this.lbPreyStats.AutoSize = true;
            this.lbPreyStats.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPreyStats.Location = new System.Drawing.Point(7, 102);
            this.lbPreyStats.Name = "lbPreyStats";
            this.lbPreyStats.Size = new System.Drawing.Size(77, 28);
            this.lbPreyStats.TabIndex = 3;
            this.lbPreyStats.Text = "Prey:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(170, 251);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 20);
            this.progressBar1.TabIndex = 2;
            // 
            // lbPredStats
            // 
            this.lbPredStats.AutoSize = true;
            this.lbPredStats.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPredStats.Location = new System.Drawing.Point(7, 155);
            this.lbPredStats.Name = "lbPredStats";
            this.lbPredStats.Size = new System.Drawing.Size(142, 28);
            this.lbPredStats.TabIndex = 3;
            this.lbPredStats.Text = "Predators:";
            // 
            // tbPredStats
            // 
            this.tbPredStats.Location = new System.Drawing.Point(170, 152);
            this.tbPredStats.Name = "tbPredStats";
            this.tbPredStats.Size = new System.Drawing.Size(100, 31);
            this.tbPredStats.TabIndex = 1;
            this.tbPredStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbIterCounter
            // 
            this.lbIterCounter.AutoSize = true;
            this.lbIterCounter.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIterCounter.Location = new System.Drawing.Point(7, 220);
            this.lbIterCounter.Name = "lbIterCounter";
            this.lbIterCounter.Size = new System.Drawing.Size(142, 28);
            this.lbIterCounter.TabIndex = 3;
            this.lbIterCounter.Text = "Iteration:";
            // 
            // tbInputIter
            // 
            this.tbInputIter.BeepOnError = true;
            this.tbInputIter.HidePromptOnLeave = true;
            this.tbInputIter.Location = new System.Drawing.Point(171, 815);
            this.tbInputIter.Mask = "000";
            this.tbInputIter.Name = "tbInputIter";
            this.tbInputIter.Size = new System.Drawing.Size(100, 31);
            this.tbInputIter.TabIndex = 7;
            this.tbInputIter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbInputIter.ValidatingType = typeof(int);
            // 
            // tbInputObst
            // 
            this.tbInputObst.BeepOnError = true;
            this.tbInputObst.HidePromptOnLeave = true;
            this.tbInputObst.Location = new System.Drawing.Point(171, 754);
            this.tbInputObst.Mask = "000";
            this.tbInputObst.Name = "tbInputObst";
            this.tbInputObst.Size = new System.Drawing.Size(100, 31);
            this.tbInputObst.TabIndex = 7;
            this.tbInputObst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbInputObst.ValidatingType = typeof(int);
            // 
            // tbInputPred
            // 
            this.tbInputPred.BeepOnError = true;
            this.tbInputPred.HidePromptOnLeave = true;
            this.tbInputPred.Location = new System.Drawing.Point(171, 687);
            this.tbInputPred.Mask = "000";
            this.tbInputPred.Name = "tbInputPred";
            this.tbInputPred.Size = new System.Drawing.Size(100, 31);
            this.tbInputPred.TabIndex = 7;
            this.tbInputPred.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbInputPred.ValidatingType = typeof(int);
            // 
            // tbInputPrey
            // 
            this.tbInputPrey.BeepOnError = true;
            this.tbInputPrey.HidePromptOnLeave = true;
            this.tbInputPrey.Location = new System.Drawing.Point(171, 621);
            this.tbInputPrey.Mask = "000";
            this.tbInputPrey.Name = "tbInputPrey";
            this.tbInputPrey.Size = new System.Drawing.Size(100, 31);
            this.tbInputPrey.TabIndex = 7;
            this.tbInputPrey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbInputPrey.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 818);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Iterations:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 760);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Obstacles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 693);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Predators:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prey:";
            // 
            // lbDemandInput
            // 
            this.lbDemandInput.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDemandInput.Location = new System.Drawing.Point(28, 492);
            this.lbDemandInput.Name = "lbDemandInput";
            this.lbDemandInput.Size = new System.Drawing.Size(256, 85);
            this.lbDemandInput.TabIndex = 5;
            this.lbDemandInput.Text = "Input initial values:";
            this.lbDemandInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelOceanField
            // 
            this.panelOceanField.Controls.Add(this.LayoutOceanField);
            this.panelOceanField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOceanField.Location = new System.Drawing.Point(0, 0);
            this.panelOceanField.Name = "panelOceanField";
            this.panelOceanField.Size = new System.Drawing.Size(1271, 1254);
            this.panelOceanField.TabIndex = 5;
            // 
            // LayoutOceanField
            // 
            this.LayoutOceanField.ColumnCount = 2;
            this.LayoutOceanField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutOceanField.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutOceanField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutOceanField.Location = new System.Drawing.Point(0, 0);
            this.LayoutOceanField.Name = "LayoutOceanField";
            this.LayoutOceanField.RowCount = 2;
            this.LayoutOceanField.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutOceanField.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutOceanField.Size = new System.Drawing.Size(1271, 1254);
            this.LayoutOceanField.TabIndex = 0;
            // 
            // FormOcean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1574, 1254);
            this.Controls.Add(this.panelOceanField);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOcean";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOcean";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.panelOceanField.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.MaskedTextBox tbInputPrey;
        private System.Windows.Forms.MaskedTextBox tbInputIter;
        private System.Windows.Forms.MaskedTextBox tbInputObst;
        private System.Windows.Forms.MaskedTextBox tbInputPred;
        private System.Windows.Forms.Label lbStatsMessage;
        private System.Windows.Forms.TableLayoutPanel LayoutOceanField;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btExit;
    }
}
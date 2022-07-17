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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btStop = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPreyInput
            // 
            this.tbPreyInput.Location = new System.Drawing.Point(52, 314);
            this.tbPreyInput.Name = "tbPreyInput";
            this.tbPreyInput.Size = new System.Drawing.Size(100, 31);
            this.tbPreyInput.TabIndex = 0;
            // 
            // tbPredInput
            // 
            this.tbPredInput.Location = new System.Drawing.Point(52, 364);
            this.tbPredInput.Name = "tbPredInput";
            this.tbPredInput.Size = new System.Drawing.Size(100, 31);
            this.tbPredInput.TabIndex = 0;
            // 
            // tbObstInput
            // 
            this.tbObstInput.Location = new System.Drawing.Point(52, 418);
            this.tbObstInput.Name = "tbObstInput";
            this.tbObstInput.Size = new System.Drawing.Size(100, 31);
            this.tbObstInput.TabIndex = 0;
            // 
            // tbIterInput
            // 
            this.tbIterInput.Location = new System.Drawing.Point(52, 474);
            this.tbIterInput.Name = "tbIterInput";
            this.tbIterInput.Size = new System.Drawing.Size(100, 31);
            this.tbIterInput.TabIndex = 0;
            // 
            // lbOceanField
            // 
            this.lbOceanField.AutoSize = true;
            this.lbOceanField.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOceanField.Location = new System.Drawing.Point(326, 308);
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
            this.btCreate.Location = new System.Drawing.Point(8, 43);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(180, 65);
            this.btCreate.TabIndex = 2;
            this.btCreate.Text = "Create Ocean";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.CreateOcean_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(8, 114);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(180, 65);
            this.btStart.TabIndex = 3;
            this.btStart.Text = "Start ";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.StartProcess_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btStop);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.btCreate);
            this.panel1.Controls.Add(this.tbPreyInput);
            this.panel1.Controls.Add(this.tbPredInput);
            this.panel1.Controls.Add(this.tbObstInput);
            this.panel1.Controls.Add(this.tbIterInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(945, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 703);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbOceanField);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 703);
            this.panel2.TabIndex = 5;
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(6, 185);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(180, 65);
            this.btStop.TabIndex = 4;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // FormOcean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1145, 703);
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
    }
}
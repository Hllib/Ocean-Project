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
            this.tbPreyInput = new System.Windows.Forms.TextBox();
            this.tbPredInput = new System.Windows.Forms.TextBox();
            this.tbObstInput = new System.Windows.Forms.TextBox();
            this.tbIterInput = new System.Windows.Forms.TextBox();
            this.lbOceanField = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPreyInput
            // 
            this.tbPreyInput.Location = new System.Drawing.Point(33, 21);
            this.tbPreyInput.Name = "tbPreyInput";
            this.tbPreyInput.Size = new System.Drawing.Size(100, 31);
            this.tbPreyInput.TabIndex = 0;
            // 
            // tbPredInput
            // 
            this.tbPredInput.Location = new System.Drawing.Point(171, 21);
            this.tbPredInput.Name = "tbPredInput";
            this.tbPredInput.Size = new System.Drawing.Size(100, 31);
            this.tbPredInput.TabIndex = 0;
            // 
            // tbObstInput
            // 
            this.tbObstInput.Location = new System.Drawing.Point(305, 21);
            this.tbObstInput.Name = "tbObstInput";
            this.tbObstInput.Size = new System.Drawing.Size(100, 31);
            this.tbObstInput.TabIndex = 0;
            // 
            // tbIterInput
            // 
            this.tbIterInput.Location = new System.Drawing.Point(440, 21);
            this.tbIterInput.Name = "tbIterInput";
            this.tbIterInput.Size = new System.Drawing.Size(100, 31);
            this.tbIterInput.TabIndex = 0;
            // 
            // lbOceanField
            // 
            this.lbOceanField.AutoSize = true;
            this.lbOceanField.Location = new System.Drawing.Point(134, 190);
            this.lbOceanField.Name = "lbOceanField";
            this.lbOceanField.Size = new System.Drawing.Size(128, 25);
            this.lbOceanField.TabIndex = 1;
            this.lbOceanField.Text = "Ocean Field";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormOcean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbOceanField);
            this.Controls.Add(this.tbIterInput);
            this.Controls.Add(this.tbObstInput);
            this.Controls.Add(this.tbPredInput);
            this.Controls.Add(this.tbPreyInput);
            this.Name = "FormOcean";
            this.Text = "FormOcean";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPreyInput;
        private System.Windows.Forms.TextBox tbPredInput;
        private System.Windows.Forms.TextBox tbObstInput;
        private System.Windows.Forms.TextBox tbIterInput;
        private System.Windows.Forms.Label lbOceanField;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
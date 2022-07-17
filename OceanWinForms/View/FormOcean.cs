using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OceanWinForms.View
{
    public partial class FormOcean : Form, IView
    {
        #region "fields"
        public int NumPrey { get; set; }
        public int NumPredators { get; set; }
        public int NumObstacles { get; set; }
        public int NumIterations { get; set; }

        public int IterationCounter { get; set; }
        public int PreyQuantity { get; set; }
        public int PredQuantity { get; set; }


        public StringBuilder SbOcean { get; set; }

        public event EventHandler NextIteration;
        public event EventHandler InitOcean;
        public event EventHandler SetDefaultOcean;
        #endregion

        public FormOcean()
        {
            InitializeComponent();

            lbOceanField.Text = String.Empty;
            lbOceanField.MaximumSize = new Size(639, 0);

            DisableButtons();
        }

        private void DisableButtons()
        {
            tbPreyStats.Enabled = false;
            tbPredStats.Enabled = false;
            tbIterCounter.Enabled = false;

            btStart.Enabled = false;
            btStop.Enabled = false;
        }

        public void GetInput()
        {
            try
            {
                this.NumPrey = int.Parse(maskedTextBox1.Text);
                this.NumPredators = int.Parse(maskedTextBox2.Text);
                this.NumObstacles = int.Parse(maskedTextBox3.Text);
                this.NumIterations = int.Parse(maskedTextBox4.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Settings set to default", "Initial values", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.SetDefaultOcean?.Invoke(this, EventArgs.Empty);
            }
        }

        private void ShowStats()
        {
            tbPreyStats.Text = this.PreyQuantity.ToString();
            tbPredStats.Text = this.PredQuantity.ToString();
            tbIterCounter.Text = String.Format("{0}/{1}",this.IterationCounter, this.NumIterations);
        }

        public bool ExitCondition()
        {
            if (this.IterationCounter >= this.NumIterations)
            {
                return true;
            }

            if (this.PredQuantity == 0 || this.PreyQuantity == 0)
            {
                return true;
            }

            return false;
        }

        #region "button events"
        public void CreateOcean_Click(object sender, EventArgs e)
        {
            this.IterationCounter = 0;
            progressBar1.Value = this.IterationCounter;

            GetInput();
            this.InitOcean?.Invoke(this, EventArgs.Empty);

            ShowStats();
            lbOceanField.Text = SbOcean.ToString();

            btStart.Enabled = true;
        }

        private void StartProcess_Click(object sender, EventArgs e)
        {
            InitTimer();
            btStop.Enabled = true;
        }
        private void StopProcess_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Interval = 50; 
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.IterationCounter += 1;
            this.progressBar1.Maximum = this.NumIterations;
            this.progressBar1.Value = this.IterationCounter;

            if (ExitCondition())
            {
                StopProcess_Click(sender, e);
                DisableButtons();
            }

            this.NextIteration?.Invoke(this, EventArgs.Empty);

            lbOceanField.Text = SbOcean.ToString();
            ShowStats();           
        }
        #endregion
    }
}

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
        public int NumPrey { get; set; }
        public int NumPredators { get; set; }
        public int NumObstacles { get; set; }
        public int NumIterations { get; set; }

        private int _iterationCounter;

        public StringBuilder SbOcean { get; set; }

        public event EventHandler NextIteration;
        public event EventHandler InitOcean;


        public FormOcean()
        {
            InitializeComponent();

            lbOceanField.Text = String.Empty;
            lbOceanField.MaximumSize = new Size(639, 0);
        }

        private void GetInput()
        {
            this.NumPrey = int.Parse(tbPreyInput.Text);
            this.NumPredators = int.Parse(tbPredInput.Text);
            this.NumObstacles = int.Parse(tbObstInput.Text);
            this.NumIterations = int.Parse(tbIterInput.Text);
        }

        public void CreateOcean_Click(object sender, EventArgs e)
        {
            GetInput();
            this.InitOcean?.Invoke(this, EventArgs.Empty);
            lbOceanField.Text = SbOcean.ToString();
        }

        private void StartProcess_Click(object sender, EventArgs e)
        {
            InitTimer();
        }

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Interval = 125; 
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(this._iterationCounter >= this.NumIterations)
            {
                Stop_Click(sender, e);
            }

            this.NextIteration?.Invoke(this, EventArgs.Empty);
            lbOceanField.Text = SbOcean.ToString();

            this._iterationCounter += 1;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}

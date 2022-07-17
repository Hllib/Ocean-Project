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
        public int numPrey;
        public int numPredators;
        public int numObstacles;
        public int numIterations;

        public StringBuilder sb { get; set; }

        public FormOcean()
        {
            InitializeComponent();

            lbOceanField.Text = String.Empty;
            lbOceanField.MaximumSize = new Size(639, 0);

            if(int.TryParse(tbPreyInput.Text, out numPrey))
            {
                numPrey = int.Parse(tbPreyInput.Text);
            }

            if (int.TryParse(tbPredInput.Text, out numPredators))
            {
                numPredators = int.Parse(tbPredInput.Text);
            }

            if (int.TryParse(tbPreyInput.Text, out numObstacles))
            {

                numObstacles = int.Parse(tbObstInput.Text);
            }

            if (int.TryParse(tbPreyInput.Text, out numIterations))
            {
                numIterations = int.Parse(tbIterInput.Text);
            }
        }

        public event EventHandler NextIteration;
        public event EventHandler InitOcean;

        private void button1_Click(object sender, EventArgs e)
        {
            this.InitOcean?.Invoke(this, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitTimer();
        }

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 25; 
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.NextIteration?.Invoke(this, EventArgs.Empty);
            lbOceanField.Text = sb.ToString();
        }

    }
}

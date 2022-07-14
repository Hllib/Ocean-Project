using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OceanBusinessLogic;

namespace OceanWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbOceanField.Text = String.Empty;    
        }

        public void GetInputInfo(ref int numPrey, ref int numPredators, ref int numObstacles, ref int numIterations)
        {
            numPrey = int.Parse(textBox1.Text);
            numPredators = int.Parse(textBox2.Text);
            numObstacles = int.Parse(textBox3.Text);
            numIterations = int.Parse(textBox4.Text);
        }

        public void DisplayOcean(Ocean ocean, int numRows, int numCols)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    stringBuilder.Append(ocean.cells[row, col].Show());
                }
            }

            lbOceanField.MaximumSize = new Size(639, 0);
            lbOceanField.Text = stringBuilder.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ocean myOcean = new Ocean();
            myOcean.Initialize();

            GetInputInfo(ref myOcean.numPrey, ref myOcean.numPredators, ref myOcean.numObstacles, ref myOcean.numIterations);

            myOcean.FillOcean();

            DisplayOcean(myOcean, myOcean.numRows, myOcean.numCols);          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitTimer();
        }

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 50; 
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

    }
}

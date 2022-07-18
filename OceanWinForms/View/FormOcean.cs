using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OceanWinForms.Controller;


namespace OceanWinForms.View
{
    public partial class FormOcean : Form, IView
    {
        #region "fields"
        public int NumPrey { get; set; }
        public int NumPredators { get; set; }
        public int NumObstacles { get; set; }
        public int NumIterations { get; set; }
        public int NumRows { get; set; }
        public int NumColumns { get; set; }

        public int IterationCounter { get; set; }
        public int PreyQuantity { get; set; }
        public int PredQuantity { get; set; }

        public Bitmap[,] CellImages { get; set; }

        public event EventHandler NextIteration;
        public event EventHandler InitOcean;
        public event EventHandler SetDefaultOcean;

        #endregion

        public FormOcean()
        {
            InitializeComponent();

            DisableButtons();
            CreateLayoutPanel();
        }

        public void CreateLayoutPanel()
        {
            LayoutOceanField.RowCount = this.NumRows = 23;
            LayoutOceanField.ColumnCount = this.NumColumns = 35;

            for (int row = 0; row < this.NumRows; row++)
            {
                for (int col = 0; col < this.NumColumns; col++)
                {                  
                    LayoutOceanField.Controls.Add(SetButton(row, col), col, row);
                }
            }
        }

        public CustomButton SetButton(int x, int y)
        {
            CustomButton button = new CustomButton(x, y);
            button.Width = 25;
            button.Height = 25;

            button.BackColor = Color.Transparent;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.ForeColor = System.Drawing.Color.White;

            return button;
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
                this.NumPrey = int.Parse(tbInputPrey.Text);
                this.NumPredators = int.Parse(tbInputPred.Text);
                this.NumObstacles = int.Parse(tbInputObst.Text);
                this.NumIterations = int.Parse(tbInputIter.Text);
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

        public void ChangeImages()
        {
            for (int i = 0; i < this.NumRows; i++)
            {
                for (int j = 0; j < this.NumColumns; j++)
                {
                    foreach(var button in LayoutOceanField.Controls.OfType<CustomButton>())
                    {
                        if(button.X == i && button.Y == j)
                        {
                            button.Image = CellImages[i, j];
                        }
                    }                
                }
            }
        }

        #region "button events"
        public void CreateOcean_Click(object sender, EventArgs e)
        {
            this.IterationCounter = 0;
            progressBar1.Value = this.IterationCounter;

            GetInput();
            this.InitOcean?.Invoke(this, EventArgs.Empty);

            ShowStats();
            ChangeImages();

            btStart.Enabled = true;
        }

        private void StartProcess_Click(object sender, EventArgs e)
        {
            InitTimer();
            btStop.Enabled = true;
            btStart.Enabled = false;
        }
        private void StopProcess_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btStart.Enabled = true;
        }

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Interval = 250; 
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
            ChangeImages();
            ShowStats();           
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            var exitMB = MessageBox.Show("Do you want to leave?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (exitMB == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            if (exitMB == DialogResult.No)
            {
                return;
            }
        }
        #endregion
    }
}

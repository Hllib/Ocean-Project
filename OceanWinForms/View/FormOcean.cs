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

        public FormOcean()
        {
            InitializeComponent();
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
            timer1.Interval = 1000; 
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.NextIteration?.Invoke(this, EventArgs.Empty);
        }


    }
}

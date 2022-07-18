using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace OceanWinForms.Controller
{
    public class CustomButton : System.Windows.Forms.Button
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CustomButton(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}

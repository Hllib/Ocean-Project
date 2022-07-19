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

            Width = 25;
            Height = 25;

            BackColor = Color.Transparent;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            ForeColor = System.Drawing.Color.White;
        }
    }
}

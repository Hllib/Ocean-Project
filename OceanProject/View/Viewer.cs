using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanProject.View
{
    public class Viewer : IView
    {
        #region "Fields"
        public int NumPrey { get; set; }
        public int NumPredators { get; set; }
        public int NumObstacles { get; set; }
        public int NumIterations { get; set; }
        public int NumRows { get; set; }
        public int NumColumns { get; set; }

        public int PreyQuantity { get; set; }
        public int PredQuantity { get; set; }
        public int IterationCounter { get; set; }

        public event EventHandler NextIteration;
        public event EventHandler InitOcean;
        #endregion

        private void DrawElement(char ch, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(x, y);
                Console.Write(ch);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        public void Show()
        {
            DrawElement('s', 0, 0);
        }
    }
}

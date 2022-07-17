using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanWinForms.View
{
    public interface IView
    {
        event EventHandler NextIteration;
        event EventHandler InitOcean;

        StringBuilder SbOcean { get; set; }

        int NumPrey { get; set; }
        int NumPredators { get; set; }
        int NumObstacles { get; set; }
        int NumIterations { get; set; }
    }
}

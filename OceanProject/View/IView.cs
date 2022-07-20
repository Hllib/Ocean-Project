﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanProject.View
{
    public interface IView
    {
        event EventHandler NextIteration;
        event EventHandler InitOcean;

        int NumPrey { get; set; } // user-defined
        int NumPredators { get; set; }
        int NumObstacles { get; set; }
        int NumIterations { get; set; }
        int NumRows { get; set; }
        int NumColumns { get; set; }

        int PreyQuantity { get; set; } // current amount 
        int PredQuantity { get; set; }
        int IterationCounter { get; set; } // current iteration number
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOceanProject
{
    internal interface IUI
    {
        void InputInfo(ref int numPrey, ref int numPredators, ref int numObstacles, ref int numIterations);
        void DisplayOcean(Ocean ocean, int numRows, int numCols);
        string DisplayStatistics(Ocean ocean);
        StringBuilder DisplayBorder();
        void ShowUI(Ocean ocean, int numRows, int numCols);

    }
}

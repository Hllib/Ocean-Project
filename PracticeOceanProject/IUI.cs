using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOceanProject
{
    internal interface IUI
    {
        void InputInfo();
        void DisplayOcean();
        string DisplayStatistics();
        StringBuilder DisplayBorder();
        void ShowUI();
    }
}

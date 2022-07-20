using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanBusinessLogic;

namespace OceanProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var form = new FormOcean();
            //var controller = new Controller.Controller(form);

            Ocean myOcean = new Ocean();
            Viewer myViewer = new Viewer();

            myOcean.SetDefaultSettings();
            myViewer.InputInfo(ref myOcean.numPrey, ref myOcean.numPredators, ref myOcean.numObstacles, ref myOcean.numIterations);
            myOcean.FillOcean();

            myViewer.ShowUI(myOcean, myOcean.numRows, myOcean.numCols);

            Console.ReadKey();
        }
    }
}

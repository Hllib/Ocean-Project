using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOceanProject
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Ocean myOcean = new Ocean();
            Viewer myViewer = new Viewer();

            myOcean.Initialize(myViewer);
            myViewer.ShowUI(myOcean, myOcean.numRows, myOcean.numCols);

            Console.ReadKey();
        }
    }
}

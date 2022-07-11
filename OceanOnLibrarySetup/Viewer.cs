using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanBusinessLogic;

namespace OceanOnLibrarySetup
{
    internal class Viewer : IUI
    {
        public void InputInfo(ref int numPrey, ref int numPredators, ref int numObstacles, ref int numIterations)
        {
            Console.Write("Input the number of prey (default = 150) : ");
            numPrey = int.Parse(Console.ReadLine());

            Console.Write("Input the number of predators (default = 20) : ");
            numPredators = int.Parse(Console.ReadLine());

            Console.Write("Input the number of obstacles (default = 75) : ");
            numObstacles = int.Parse(Console.ReadLine());

            Console.Write("Input the number of iterations: ");
            numIterations = int.Parse(Console.ReadLine());

        }

        public void DisplayOcean(Ocean ocean, int numRows, int numCols)
        {
            Console.WriteLine(DisplayStatistics(ocean));
            Console.WriteLine(DisplayBorder());
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    Console.Write(ocean.cells[row, col].Show());
                }
                Console.WriteLine();
            }
            Console.WriteLine(DisplayBorder());
        }

        public string DisplayStatistics(Ocean ocean)
        {
            string stats;
            int preyQuantity = ocean.CountPrey();
            int predQuantity = ocean.CountPredators();

            stats = String.Format("Iteration: {0}\nNumber of prey: {1}\nNumber of predators: {2}", ocean.iterationCounter, preyQuantity, predQuantity);
            return stats;
        }

        public StringBuilder DisplayBorder()
        {
            StringBuilder stats = new StringBuilder();
            for (int col = 0; col < Constants.MaxCols; col++)
            {
                stats.Append("*");
            }

            return stats;
        }

        public void ShowUI(Ocean ocean, int numRows, int numCols)
        {
            Console.WriteLine();
            DisplayOcean(ocean, numRows, numCols);
            Console.WriteLine("\nPress any key to begin....");
            Console.ReadKey();
            Console.Clear();

            for (int iteration = 1; iteration <= ocean.numIterations; iteration++)
            {
                ocean.Run();
                DisplayOcean(ocean, numRows, numCols);
                System.Threading.Thread.Sleep(150);
                Console.Clear();
            }

            DisplayOcean(ocean, numRows, numCols);
            Console.WriteLine("SIMULATION OVER");
        }
    }
}

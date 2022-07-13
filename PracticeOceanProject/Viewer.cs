using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeOceanProject
{
    internal class Viewer 
    {
        protected static int startRow;
        protected static int startColumn;

        protected bool IsNoPrey;
        protected bool IsNoPred;
        protected static void ReDrawElement(char ch, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(startColumn + x, startRow + y);
                Console.Write(ch);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        public void InputInfo(ref int numPrey, ref int numPredators, ref int numObstacles, ref int numIterations)
        {
            try
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
            catch(FormatException)
            {
                Console.Clear();
                InputInfo(ref numPrey, ref numPredators, ref numObstacles, ref numIterations);
            }
        }

        public void ReDrawOcean(Ocean ocean, int numRows, int numCols)
        {
            startRow = 9;
            startColumn = 0;
            Console.CursorVisible = false;

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    if (ocean.cells[row, col] is IMovable)
                    {
                        ReDrawElement(ocean.cells[row, col].Show(), col, row);
                    }
                }
            }

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    if (ocean.cells[row, col].GetType() != typeof(Obstacle) && !(ocean.cells[row, col] is IMovable))
                    {
                        ReDrawElement(Constants.DefaultImage, col, row);
                    }
                }
            }
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

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public void ReDrawStats(Ocean ocean)
        {
            int preyQuantity = ocean.CountPrey();
            int predQuantity = ocean.CountPredators();

            Console.SetCursorPosition(0, 5);
            ClearCurrentConsoleLine();
            Console.WriteLine($"Iteration: {ocean.iterationCounter}/{ocean.numIterations}");
            Console.SetCursorPosition(0, 6);
            ClearCurrentConsoleLine();
            Console.WriteLine($"Number of prey: {preyQuantity}");
            Console.SetCursorPosition(0, 7);
            ClearCurrentConsoleLine();
            Console.WriteLine($"Number of predators: {predQuantity}");

            if(preyQuantity == 0)
            {
                IsNoPrey = true;
            }

            if(predQuantity == 0)
            {
                IsNoPred = true;
            }
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

            for (int iteration = 1; iteration <= ocean.numIterations; iteration++)
            {
                ocean.Run();
                ReDrawOcean(ocean, numRows, numCols);
                ReDrawStats(ocean);
                System.Threading.Thread.Sleep(25);

                if (IsNoPrey)
                {
                    Console.Clear();
                    DisplayOcean(ocean, numRows, numCols);
                    Console.WriteLine("\n\t\t\tNO PREY LEFT");
                    break;
                }

                if (IsNoPred)
                {
                    Console.Clear();
                    DisplayOcean(ocean, numRows, numCols);
                    Console.WriteLine("\n\t\t\tNO PREDATORS LEFT");
                    break;
                }  
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n\t\t\tSIMULATION OVER");
        }
    }
}

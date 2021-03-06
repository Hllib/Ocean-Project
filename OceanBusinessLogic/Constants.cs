using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBusinessLogic
{
    public static class Constants
    {
        public const int MaxRows = 23;
        public const int MaxCols = 35;

        public const int DefaultNumObstacles = 60;
        public const int DefaultNumPredators = 15;
        public const int DefaultNumPrey = 100;
        public const int DefaultNumIterations = 250;

        public const char DefaultImage = '-';
        public const char DefaultPreyImage = 'f';
        public const char DefaultPredImage = 'S';
        public const char ObstacleImage = '#';

        public const int TimeToFeed = 6;
        public const int TimeToReproduce = 6;

        public enum Direction : int
        {
            North = -1,
            South = 1,
            West = -1,
            East = 1
        }

        public enum Borders : int
        {
            Top = 0,
            Lower = Constants.MaxRows - 1,
            Left = 0,
            Right = Constants.MaxCols - 1
        }
    }
}

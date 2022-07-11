using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBusinessLogic
{
    internal class Coordinate : ICoords
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Coordinate(int row, int col)
        {
            this.Row = row;
            this.Column = col;
        }

        public Coordinate[] GenerOffset(Ocean ocean)
        {
            Coordinate[] newCoords = ocean.SetMovementVariants();

            foreach (Coordinate coord in newCoords)
            {
                int rowInArray = coord.Row;
                int colInArray = coord.Column;

                if (this.Row + rowInArray < (int)Constants.Borders.Top)
                {
                    int indexToRemove = Array.IndexOf(newCoords, coord);
                    newCoords = newCoords.Where((source, index) => index != indexToRemove).ToArray();
                }
                if (this.Row + rowInArray > (int)Constants.Borders.Lower)
                {
                    int indexToRemove = Array.IndexOf(newCoords, coord);
                    newCoords = newCoords.Where((source, index) => index != indexToRemove).ToArray();
                }
                if (this.Column + colInArray < (int)Constants.Borders.Left)
                {
                    int indexToRemove = Array.IndexOf(newCoords, coord);
                    newCoords = newCoords.Where((source, index) => index != indexToRemove).ToArray();
                }
                if (this.Column + colInArray > (int)Constants.Borders.Right)
                {
                    int indexToRemove = Array.IndexOf(newCoords, coord);
                    newCoords = newCoords.Where((source, index) => index != indexToRemove).ToArray();
                }
            }

            return newCoords;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBusinessLogic
{
    public class Ocean
    {
        #region "Fields"
        public Cell[,] cells = new Cell[Constants.MaxRows, Constants.MaxCols];

        public int numRows; // These values are const
        public int numCols;
        public int size;

        public int iterationCounter = 0;

        public int numIterations; // These are user-defined parameters
        public int numPrey;
        public int numPredators;
        public int numObstacles;
        #endregion

        #region "Initialization"
        Random random = new Random();
        public void Initialize()
        {
            Ocean ocean = new Ocean();

            numRows = Constants.MaxRows;
            numCols = Constants.MaxCols;
            size = numRows * numCols;

            numPrey = Constants.DefaultNumPrey;
            numPredators = Constants.DefaultNumPredators;
            numObstacles = Constants.DefaultNumObstacles;
            numIterations = Constants.DefaultNumIterations;
        }

        public void FillOcean()
        {
            InitOcean();
            PlaceObjects();
        }

        public void InitOcean()
        {
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    cells[row, col] = new Cell();
                }
            }
        }

        public void PlaceObjects()
        {
            int randRowIndex;
            int randColIndex;

            for (int i = 0; i < numPrey; i++)
            {
                do
                {
                    randRowIndex = random.Next(0, Constants.MaxRows);
                    randColIndex = random.Next(0, Constants.MaxCols);

                } while (!cells[randRowIndex, randColIndex].GetType().Equals(typeof(Cell)));

                cells[randRowIndex, randColIndex] = new Prey(new Coordinate(randRowIndex, randColIndex));
            }

            for (int i = 0; i < numPredators; i++)
            {
                do
                {
                    randRowIndex = random.Next(0, Constants.MaxRows);
                    randColIndex = random.Next(0, Constants.MaxCols);

                } while (!cells[randRowIndex, randColIndex].GetType().Equals(typeof(Cell)));

                cells[randRowIndex, randColIndex] = new Predator(new Coordinate(randRowIndex, randColIndex));
            }

            for (int i = 0; i < numObstacles; i++)
            {
                do
                {
                    randRowIndex = random.Next(0, Constants.MaxRows);
                    randColIndex = random.Next(0, Constants.MaxCols);

                } while (!cells[randRowIndex, randColIndex].GetType().Equals(typeof(Cell)));

                cells[randRowIndex, randColIndex] = new Obstacle(new Coordinate(randRowIndex, randColIndex));
            }
        }
        #endregion

        #region "Movement Process"          
        public Coordinate[] SetMovementVariants()
        {
            Coordinate[] allVariants = new Coordinate[]
            {
                new Coordinate((int)Constants.Direction.North, 0),
                new Coordinate((int)Constants.Direction.South, 0),
                new Coordinate(0, (int)Constants.Direction.West),
                new Coordinate(0, (int)Constants.Direction.East)
            };

            return allVariants;
        }

        public bool IsCellEmpty(ICoords coords)
        {
            if (cells[coords.Row, coords.Column].GetType() == (typeof(Prey)))
            {
                return false;
            }

            if (cells[coords.Row, coords.Column].GetType() == (typeof(Predator)))
            {
                return false;
            }

            if (cells[coords.Row, coords.Column].GetType() == (typeof(Obstacle)))
            {
                return false;
            }

            return true;
        }

        public bool IsCellEdible(ICoords coords)
        {
            if (cells[coords.Row, coords.Column].GetType() == (typeof(Prey)))
            {
                return true;
            }

            return false;
        }

        public int CountPrey()
        {
            int preyQuantity = 0;

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    if (cells[row, col].GetType() == (typeof(Prey)))
                    {
                        preyQuantity += 1;
                    }
                }
            }

            return preyQuantity;
        }

        public int CountPredators()
        {
            int predQuantity = 0;

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    if (cells[row, col].GetType() == (typeof(Predator)))
                    {
                        predQuantity += 1;
                    }
                }
            }

            return predQuantity;
        }
        public void Run()
        {
            iterationCounter += 1;
            Ocean ocean = new Ocean();
            ocean.cells = this.cells;

            List<int> movedObjects = new List<int>();

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    if (cells[row, col] is IMovable)
                    {
                        if (movedObjects.Contains(cells[row, col].GetHashCode()))
                        {
                            continue;
                        }

                        movedObjects.Add(cells[row, col].GetHashCode());

                        ICoords oldCoords = new Coordinate(row, col);
                        ICoords newCoords = (((IMovable)cells[row, col]).ReturnNewCoords(ocean));

                        ((IMovable)cells[row, col]).Process(ocean, newCoords, oldCoords);
                    }
                }
            }
            movedObjects.Clear();
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOceanProject
{
    internal class Predator : Prey
    {
        protected int timeToFeed = Constants.TimeToFeed;

        public Predator(ICoords coords) : base(coords)
        {
 
        }

        public override ICoords ReturnNewCoords(Ocean ocean)
        {
            Random random = new Random();
            Coordinate[] newCoordsArray = this.coords.GenerOffset(ocean);

            foreach (Coordinate coord in newCoordsArray)
            {
                if (ocean.IsCellEdible(new Coordinate(this.coords.Row +
                coord.Row, this.coords.Column + coord.Column)))
                {
                    return new Coordinate(this.coords.Row + coord.Row,
                    this.coords.Column + coord.Column);
                }
            }

            foreach (Coordinate coord in newCoordsArray)
            {
                if (!ocean.IsCellEmpty(new Coordinate(this.coords.Row +
                coord.Row, this.coords.Column + coord.Column)))
                {
                    int indexToRemove = Array.IndexOf(newCoordsArray,
                    coord);
                    newCoordsArray = newCoordsArray.Where((source, index)
                    => index != indexToRemove).ToArray();
                }
            }

            if (newCoordsArray.Length == 0)
            {
                return this.coords;
            }

            int randomCoords = random.Next(0, newCoordsArray.Length);

            ICoords newCoords = newCoordsArray[randomCoords];

            return new Coordinate(this.coords.Row + newCoords.Row, this.coords.Column + newCoords.Column);
        }

        public override char Show()
        {
            return Constants.DefaultPredImage;
        }

        public override void Die(Ocean ocean, ICoords oldCoords)
        {
            ocean.cells[oldCoords.Row, oldCoords.Column] = new Cell();
        }

        private bool IsTimeToDie()
        {
            return (this.timeToFeed == 0);
        }

        public override void Reproduce(Ocean ocean, ICoords oldCoords)
        {
            ocean.cells[oldCoords.Row, oldCoords.Column] = new Predator(oldCoords); 
        }

        public override void Process(Ocean ocean, ICoords newCoords, ICoords oldCoords)
        {
            this.timeToFeed -= 1;

            if (IsTimeToDie())
            {
                Die(ocean, oldCoords);
            }

            else
            {
                Cell temp = ocean.cells[newCoords.Row, newCoords.Column];

                if (ocean.cells[newCoords.Row, newCoords.Column].GetType().Equals(typeof(Prey)))
                {
                    this.timeToFeed = Constants.TimeToFeed;
                    ocean.cells[newCoords.Row, newCoords.Column] = ocean.cells[oldCoords.Row, oldCoords.Column];

                    ((IMovable)ocean.cells[newCoords.Row, newCoords.Column]).SetCoords(newCoords);

                    if (IsTimeToReproduce())
                    {
                        this.timeToReproduce = Constants.TimeToReproduce;
                        Reproduce(ocean, oldCoords);
                    }
                }

                if(ocean.cells[newCoords.Row, newCoords.Column].GetType() != (typeof(Prey)))
                {
                    ocean.cells[newCoords.Row, newCoords.Column] = ocean.cells[oldCoords.Row, oldCoords.Column];

                    ((IMovable)ocean.cells[newCoords.Row, newCoords.Column]).SetCoords(newCoords);
                    ocean.cells[oldCoords.Row, oldCoords.Column] = temp;
                    if (IsTimeToReproduce())
                    {
                        this.timeToReproduce = Constants.TimeToReproduce;
                        Reproduce(ocean, oldCoords);
                    }
                }                              
            }
        }
    }    
}          






    



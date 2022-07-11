using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBusinessLogic
{
    internal class Prey : Cell, IMovable
    {
        protected ICoords coords;

        protected int timeToReproduce = Constants.TimeToReproduce;
        protected int moveCount = 0;

        public virtual ICoords ReturnNewCoords(Ocean ocean)
        {
            Random random = new Random();
            Coordinate[] newCoordsArray = this.coords.GenerOffset(ocean);

            foreach (Coordinate coord in newCoordsArray)
            {
                if (!ocean.IsCellEmpty(new Coordinate(this.coords.Row + coord.Row, this.coords.Column + coord.Column)))
                {
                    int indexToRemove = Array.IndexOf(newCoordsArray, coord);
                    newCoordsArray = newCoordsArray.Where((source, index) => index != indexToRemove).ToArray();
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

        public void SetCoords(ICoords coords)
        {
            this.timeToReproduce -= 1;
            this.moveCount += 1;
            this.coords = coords;
        }

        public virtual void Die(Ocean ocean, ICoords oldCoords)
        {

        }

        public bool IsTimeToReproduce()
        {
            return (this.timeToReproduce == 0);
        }

        public virtual void Reproduce(Ocean ocean, ICoords oldCoords)
        {
            ocean.cells[oldCoords.Row, oldCoords.Column] = new Prey(oldCoords);
        }

        public virtual void Process(Ocean ocean, ICoords newCoords, ICoords oldCoords)
        {
            Cell temp = ocean.cells[newCoords.Row, newCoords.Column];
            ocean.cells[newCoords.Row, newCoords.Column] = ocean.cells[oldCoords.Row, oldCoords.Column];

            ((IMovable)ocean.cells[newCoords.Row, newCoords.Column]).SetCoords(newCoords);

            if (IsTimeToReproduce())
            {
                this.timeToReproduce = Constants.TimeToReproduce;
                Reproduce(ocean, oldCoords);
            }

            else
            {
                ocean.cells[oldCoords.Row, oldCoords.Column] = temp;
            }
        }

        public Prey(ICoords coords)
        {
            this.coords = coords;
        }

        public override char Show()
        {
            return Constants.DefaultPreyImage;
        }
    }
}

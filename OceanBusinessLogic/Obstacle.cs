using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBusinessLogic
{
    internal class Obstacle : Cell
    {
        ICoords coords;
        public override char Show()
        {
            return Constants.ObstacleImage;
        }

        public Obstacle(ICoords coords)
        {
            this.coords = coords;
        }
    }
}

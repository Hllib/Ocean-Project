using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOceanProject
{
    internal interface IMovable
    {
        ICoords ReturnNewCoords(Ocean ocean);
        void SetCoords(ICoords coords);
        bool IsTimeToReproduce();
        void Process(Ocean ocean, ICoords newCoords, ICoords oldCoords);
        void Die(Ocean ocean, ICoords oldCoords);
        void Reproduce(Ocean ocean, ICoords oldCoords);
    }

    internal interface ICoords
    {
        Coordinate[] GenerOffset(Ocean ocean);
        int Row { get; set; }
        int Column { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBusinessLogic
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
}

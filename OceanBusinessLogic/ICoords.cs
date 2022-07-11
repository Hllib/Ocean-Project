using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBusinessLogic
{
    internal interface ICoords
    {
        Coordinate[] GenerOffset(Ocean ocean);
        int Row { get; set; }
        int Column { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBusinessLogic
{
    public class Cell
    {
        virtual public char Show()
        {
            return Constants.DefaultImage;
        }
    }
}

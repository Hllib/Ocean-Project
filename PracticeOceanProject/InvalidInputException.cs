using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOceanProject
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException() { }
        public InvalidInputException(string quantity) : base(String.Format("Invalid data input : {0}", quantity)) 
        {
            
        }
    }
}

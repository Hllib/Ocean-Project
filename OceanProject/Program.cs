using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanProject.View;

namespace OceanProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            var viewer = new Viewer();
            viewer.Show();

            Console.ReadKey();
        }
    }
}

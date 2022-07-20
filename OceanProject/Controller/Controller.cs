using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanBusinessLogic;
using OceanProject.View;

namespace OceanProject.Controller
{
    public class Controller
    {
        private readonly IView _view;
        private readonly Ocean _ocean;

        public Controller(IView view)
        {
            this._view = view;
            this._ocean = new Ocean();
        }

    }
}

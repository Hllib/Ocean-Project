using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanBusinessLogic;
using OceanWinForms.View;

namespace OceanWinForms.Controller
{
    public class Controller
    {
        private readonly IView _view;
        private Ocean _myOcean;

        public Controller(IView view)
        {
            this._view = view;
            this._myOcean = new Ocean();

            this._view.NextIteration += View_NextIteration;
            this._view.InitOcean += View_InitOcean;
        }

        private void View_InitOcean(object sender, EventArgs e)
        {
            this._myOcean.Initialize();
            this._myOcean.InitOcean();
        }

        private void View_NextIteration(object sender, EventArgs e)
        {
            this._myOcean.Run();

        }

    }
}

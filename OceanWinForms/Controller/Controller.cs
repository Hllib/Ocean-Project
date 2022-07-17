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

        public StringBuilder sb;

        public Controller(IView view)
        {
            this._view = view;
            this._myOcean = new Ocean();
            
            this._view.NextIteration += View_NextIteration;
            this._view.InitOcean += View_InitOcean;
            this._view.SetDefaultOcean += View_SetDefaultOcean;
        }

        private void View_SetDefaultOcean(object sender, EventArgs e)
        {
            this._view.NumPrey = Constants.DefaultNumPrey;
            this._view.NumPredators = Constants.DefaultNumPredators;
            this._view.NumObstacles = Constants.DefaultNumObstacles;
            this._view.NumIterations = Constants.DefaultNumIterations;
        }

        private void SetInput()
        {
            this._myOcean.numPrey = this._view.NumPrey;
            this._myOcean.numPredators = this._view.NumPredators;
            this._myOcean.numObstacles = this._view.NumObstacles;
            this._myOcean.numIterations = this._view.NumIterations;
        }

        private void GetStats()
        {
            this._view.PreyQuantity = this._myOcean.CountPrey();
            this._view.PredQuantity = this._myOcean.CountPredators();
        }

        private void View_InitOcean(object sender, EventArgs e)
        {
            this._myOcean.SetDefaultSettings();
      
            SetInput();
            this._myOcean.FillOcean();

            GetStats();
            this._view.SbOcean = this._myOcean.ReturnOceanString();
        }

        private void View_NextIteration(object sender, EventArgs e)
        {
            this._myOcean.Run();

            GetStats();
            this._view.SbOcean = this._myOcean.ReturnOceanString();
        }
    }
}

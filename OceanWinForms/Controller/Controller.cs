using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using OceanBusinessLogic;
using OceanWinForms.View;

namespace OceanWinForms.Controller
{
    public class Controller
    {
        private readonly IView _view;
        private readonly Ocean _myOcean;

        private readonly Bitmap preyImage = new Bitmap("prey.png");
        private readonly Bitmap predImage = new Bitmap("predator.png");
        private readonly Bitmap obstImage = new Bitmap("obstacle.png");

        public Controller(IView view)
        {
            this._view = view;
            this._myOcean = new Ocean();

            this._view.NextIteration += View_NextIteration;
            this._view.InitOcean += View_InitOcean;
            this._view.SetDefaultOcean += View_SetDefaultOcean;
        }

        public Bitmap[,] ReturnCellImages()
        {
            Bitmap[,] returnCellImages = new Bitmap[_myOcean.numRows, _myOcean.numCols];

            for(int row = 0; row < this._myOcean.numRows; row ++)
            {
                for(int col = 0; col < this._myOcean.numCols; col ++)
                {
                    if (_myOcean.cells[row, col].GetType() == typeof(Prey))
                    {
                        returnCellImages[row, col] = preyImage;
                    }

                    if (_myOcean.cells[row, col].GetType() == typeof(Predator))
                    {
                        returnCellImages[row, col] = predImage;
                    }

                    if (_myOcean.cells[row, col].GetType() == typeof(Obstacle))
                    {
                        returnCellImages[row, col] = obstImage;
                    }
                }
            }

            return returnCellImages;
        }

        private void View_SetDefaultOcean(object sender, EventArgs e)
        {
            _view.NumPrey = Constants.DefaultNumPrey;
            _view.NumPredators = Constants.DefaultNumPredators;
            _view.NumObstacles = Constants.DefaultNumObstacles; 
            _view.NumIterations = Constants.DefaultNumIterations;
        }

        private void SetInput()
        {
            _myOcean.numPrey = _view.NumPrey;
            _myOcean.numPredators = _view.NumPredators;
            _myOcean.numObstacles = _view.NumObstacles;
            _myOcean.numIterations = _view.NumIterations;
        }

        private void GetStats()
        {
            _view.PreyQuantity = this._myOcean.CountPrey();
            _view.PredQuantity = this._myOcean.CountPredators();
        }

        private void View_InitOcean(object sender, EventArgs e)
        {
            _myOcean.SetDefaultSettings();
      
            SetInput();
            _myOcean.FillOcean();

            GetStats();
            _view.CellImages = ReturnCellImages(); 
        }

        private void View_NextIteration(object sender, EventArgs e)
        {
            _myOcean.Run();

            GetStats();
            _view.CellImages = ReturnCellImages();
        }
    }
}

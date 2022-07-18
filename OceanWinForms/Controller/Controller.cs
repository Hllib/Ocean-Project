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

        public Controller(IView view)
        {
            this._view = view;
            this._myOcean = new Ocean();


            this._view.NumRows = 23; //preferred values for Win Forms maximized window
            this._view.NumColumns = 35; //preferred values for Win Forms maximized window

            this._view.NextIteration += View_NextIteration;
            this._view.InitOcean += View_InitOcean;
            this._view.SetDefaultOcean += View_SetDefaultOcean;
        }
        
        public Bitmap[,] ReturnCellImages()
        {
            Bitmap[,] returnCellImages = new Bitmap[this._myOcean.numRows, this._myOcean.numCols];

            for(int row = 0; row < this._myOcean.numRows; row ++)
            {
                for(int col = 0; col < this._myOcean.numCols; col ++)
                {
                    if (this._myOcean.cells[row, col].GetType() == typeof(Prey))
                    {
                        returnCellImages[row, col] = new Bitmap("prey.png");
                    }

                    if (this._myOcean.cells[row, col].GetType() == typeof(Predator))
                    {
                        returnCellImages[row, col] = new Bitmap("predator.png");
                    }

                    if (this._myOcean.cells[row, col].GetType() == typeof(Obstacle))
                    {
                        returnCellImages[row, col] = new Bitmap("obstacle.png");
                    }
                }
            }

            return returnCellImages;
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
            this._view.CellImages = this.ReturnCellImages(); 
        }

        private void View_NextIteration(object sender, EventArgs e)
        {
            this._myOcean.Run();

            GetStats();
            this._view.CellImages = this.ReturnCellImages();
        }
    }
}

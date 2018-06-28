using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club.Control
{
    class Controller: IControl
    {
        private IView view;
        private IGameModel gameModel;

        public Controller(IView view, IGameModel gameModel)
        {
            this.view = view;
            this.gameModel = gameModel;
            view.SetController(this);
            gameModel.AddObserver(view);
            StartNewGame();
        }

        public void GetBodyPart(BodyPart part)
        {
            gameModel.NextStep(part);
        }

        public void StartNewGame()
        {
            gameModel.StartGame();
        }

        public void ViewChanged(IView view, ViewEventArgs e)
        {
            gameModel.NextStep(e.Part);
        }
    }
}

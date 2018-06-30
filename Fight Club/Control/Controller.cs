using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    class Controller: IControl
    {
        private IViewPlayer viewPlayer1;
        private IViewPlayer viewPlayer2;
        private IViewLog viewLog;
        private IGameModel gameModel;

        public Controller(IViewPlayer viewPlayer1, IViewPlayer viewPlayer2, IViewLog viewLog, IGameModel gameModel)
        {
            this.viewPlayer1 = viewPlayer1;
            this.viewPlayer2 = viewPlayer2;
            this.viewLog = viewLog;
            this.gameModel = gameModel;
            viewPlayer1.SetController(this);
            viewPlayer2.SetController(this);
            viewLog.SetController(this);
            gameModel.AddObservers(viewPlayer1,viewPlayer2,viewLog);
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
    }
}

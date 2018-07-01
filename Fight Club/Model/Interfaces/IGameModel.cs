using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    interface IGameModel
    {
        event EventHandler<GameModelEventArgs> Start;
        IPlayer Player0 { get; }
        IPlayer Player1 { get; }

        void StartGame();
        void NextStep(BodyPart head);

        void AddObservers(IViewPlayer viewPlayer1, IViewPlayer viewPlayer2, IViewLog viewLog);
    }
}

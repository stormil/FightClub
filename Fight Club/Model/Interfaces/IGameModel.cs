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
        IPlayer Player1 { get; }
        IPlayer Player2 { get; }

        void StartGame();
        void NextStep(BodyPart head);
    }
}

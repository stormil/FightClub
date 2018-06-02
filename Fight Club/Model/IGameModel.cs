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
        Player Player1 { get; }
        Player Player2 { get; }

        void StartGame();
        void NextStep(BodyPart head);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    interface IView
    {
        event EventHandler<IView> changed;
        void SetController(IControl controller);
        void StartGameLog(object sender, GameModelEventArgs e);
        void RequestNewGameStart(object sender, PlayerEventArgs e);
        void BlockLog(object sender, PlayerEventArgs e);
        void WoundLog(object sender, PlayerEventArgs e);
        void DeathLog(object sender, PlayerEventArgs e);
        void LoadPlayerHealthPoints(object sender, PlayerEventArgs e);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    interface IView
    {
        void StartGameLog(object sender, GameModelEventArgs e);
        void RequestNewGameStart(object sender, PlayerEventArgs e);
        void BlockLog(object sender, PlayerEventArgs e);
        void WoundLog(object sender, PlayerEventArgs e);
        void DeathLog(object sender, PlayerEventArgs e);
        void LoadPlayer2HealthPoints(object sender, PlayerEventArgs e);
        void LoadPlayer1HealthPoints(object sender, PlayerEventArgs e);
    }
}

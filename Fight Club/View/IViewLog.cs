using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    interface IViewLog: IView
    {
        void StartGameLog(object sender, GameModelEventArgs e);
        void BlockLog(object sender, PlayerEventArgs e);
        void WoundLog(object sender, PlayerEventArgs e);
        void DeathLog(object sender, PlayerEventArgs e);
    }
}

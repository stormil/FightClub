using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    interface IViewPlayer: IView
    {
        void RequestNewGameStart(object sender, PlayerEventArgs e);
        void LoadPlayerHealthPoints(object sender, PlayerEventArgs e);
        void SwitchControls(object sender, EventArgs e);
    }
}

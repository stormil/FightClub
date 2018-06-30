using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    interface IPlayer
    {
        event EventHandler<PlayerEventArgs> Wound;
        event EventHandler<PlayerEventArgs> Death;
        event EventHandler<PlayerEventArgs> Block;
        int HealthPoints { get; set; }
        BodyPart Blocked { get; set; }
        string Name { get; }
        void GetHit(BodyPart choseBodyPart);
        void AddPlayerObserver(IViewPlayer viewPlayer);
        void AddLogObserver(IViewLog viewLog);
    }
}

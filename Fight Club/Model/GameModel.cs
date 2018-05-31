using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    class GameModel
    {
        //const int PlayersAmount=2;
        public Player Player1 { get; }
        public Player Player2 { get; }
        private int roundIndex = 0;

        public GameModel(string name)
        {
            Player1 = new Player(name);
            Player2 = new Player("Tyler Durden");
        }

        public event EventHandler<EventArgs> Start;

        private void OnStart()
        {
            var playerEventArgs = new PlayerEventArgs();

            if (Start != null)
            {
                Start(this, new EventArgs());
            }
        }

        public void StartGame()
        {
            roundIndex = new Random().Next(1);
            //StartLog();
        }


        public void NextStep(BodyPart bodyPart)
        {
            roundIndex++;
            if (roundIndex % 2 == 0)
            {
                Player1.Blocked = bodyPart;
                Player1.GetHit(Bot.choseBodyPart());
            }
            else
            {
                Player2.Blocked = Bot.choseBodyPart();
                Player2.GetHit(bodyPart);
            }
        }
    }
}

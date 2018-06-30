using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    class GameModel : IGameModel
    {
        const int PlayersAmount=2;

        public IPlayer Player1 { get; }
        public IPlayer Player2 { get; }
        private int roundIndex = 0;

        public GameModel(string name)
        {
            Player1 = new Player(name, 0);
            Player2 = new Player("Tyler Durden", 1);
        }

        public event EventHandler<GameModelEventArgs> Start;

        public void StartGame()
        {
            roundIndex = new Random().Next(0, PlayersAmount);
            Player1.HealthPoints = Player.MaxHealth;
            Player2.HealthPoints = Player.MaxHealth;
            Start?.Invoke(this, new GameModelEventArgs(roundIndex));
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

        public void AddObservers(IViewPlayer viewPlayer1, IViewPlayer viewPlayer2, IViewLog viewLog)
        {
            Player1.AddPlayerObserver(viewPlayer1);
            Player2.AddPlayerObserver(viewPlayer2);
            Player1.AddLogObserver(viewLog);
            Player2.AddLogObserver(viewLog);
            Start += viewLog.StartGameLog;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    class GameModel : IGameModel
    {
        const int PlayersAmount = 2;

        public IPlayer Player0 { get; }
        public IPlayer Player1 { get; }
        private int roundIndex = 0;

        public GameModel(string name)
        {
            Player0 = new Player(name, 0);
            Player1 = new Player("Tyler Durden", 1);
        }

        public event EventHandler<GameModelEventArgs> Start;
        public event EventHandler<EventArgs> NextTurn;

        public void StartGame()
        {
            roundIndex = new Random().Next(0, PlayersAmount);
            if (Player0.HealthPoints == Player.MaxHealth && Player1.HealthPoints == Player.MaxHealth &&
                roundIndex % 2 == 1)
                NextTurn?.Invoke(this, new EventArgs());
            if (Player0.HealthPoints == 0 && roundIndex % 2 == 1) NextTurn?.Invoke(this, new EventArgs());
            if (Player1.HealthPoints == 0 && roundIndex % 2 == 0) NextTurn?.Invoke(this, new EventArgs());
            Player0.HealthPoints = Player.MaxHealth;
            Player1.HealthPoints = Player.MaxHealth;
            Start?.Invoke(this, new GameModelEventArgs(roundIndex));
        }

        public void NextStep(BodyPart bodyPart)
        {
            roundIndex++;
            if (roundIndex % 2 == 0)
            {
                Player0.Blocked = bodyPart;
                Player0.GetHit(Bot.choseBodyPart());
            }
            else
            {
                Player1.Blocked = Bot.choseBodyPart();
                Player1.GetHit(bodyPart);
            }
            NextTurn?.Invoke(this, new EventArgs());
        }

        public void AddObservers(IViewPlayer viewPlayer0, IViewPlayer viewPlayer1, IViewLog viewLog)
        {
            Player0.AddLogObserver(viewLog);
            Player1.AddLogObserver(viewLog);
            Player0.AddPlayerObserver(viewPlayer0);
            Player1.AddPlayerObserver(viewPlayer1);
            Start += viewLog.StartGameLog;
            NextTurn += viewPlayer0.SwitchControls;
            NextTurn += viewPlayer1.SwitchControls;
        }
    }
}
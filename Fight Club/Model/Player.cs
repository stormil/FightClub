using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    class Player: IPlayer
    {
        public const int MaxHealth = 100;
        private const int DamageHealthPoints = 20;

        private BodyPart blocked;
        private int healthPoints;
        private readonly string name;
        public int Id { get; }

        public Player(string name, int id)
        {
            this.name = name;
            this.Id = id;
        }

        public event EventHandler<PlayerEventArgs> Wound;

        private void OnWound()
        {
            Wound?.Invoke(this, new PlayerEventArgs(Name, Id, healthPoints));
        }

        public event EventHandler<PlayerEventArgs> Block;

        private void OnBlock()
        {
            Block?.Invoke(this, new PlayerEventArgs(Name, Id, healthPoints));
        }

        public event EventHandler<PlayerEventArgs> Death;

        private void OnDeath()
        {
            Death?.Invoke(this, new PlayerEventArgs(Name, Id, healthPoints));
        }

        public BodyPart Blocked
        {
            get => blocked;
            set => blocked = value;
        }

        public int HealthPoints
        {
            get => healthPoints;
            set
            {
                if (value <= 0)
                {
                    healthPoints = 0;
                    OnDeath();
                }
                else
                {
                    healthPoints = value;
                    OnWound();
                }
            }
        }

        public string Name => name;

        public void GetHit(BodyPart targetBodyPart)
        {
            if (blocked == targetBodyPart)
            {
                OnBlock();
            }
            else
            {
                HealthPoints = HealthPoints - DamageHealthPoints;
            }
        }

        public void AddObserver(IView view)
        {
            Wound += view.WoundLog;
            Wound += view.LoadPlayerHealthPoints;
            Death += view.DeathLog;
            Death += view.LoadPlayerHealthPoints;
            Death += view.RequestNewGameStart;
            Block += view.BlockLog;
        }
    }
}
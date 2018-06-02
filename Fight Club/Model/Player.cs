using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    class Player
    {
        public const int MaxHealth = 100;
        private const int DamageHealthPoints = 20;

        private BodyPart blocked;
        private int healthPoints;
        private readonly string name;

        public Player(string name)
        {
            this.name = name;
        }

        public event EventHandler<PlayerEventArgs> Wound;

        private void OnWound()
        {
            Wound?.Invoke(this, new PlayerEventArgs(Name, healthPoints));
        }

        public event EventHandler<PlayerEventArgs> Block;

        private void OnBlock()
        {
            Block?.Invoke(this, new PlayerEventArgs(Name, healthPoints));
        }

        public event EventHandler<PlayerEventArgs> Death;

        private void OnDeath()
        {
            Death?.Invoke(this, new PlayerEventArgs(Name, healthPoints));
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
    }
}
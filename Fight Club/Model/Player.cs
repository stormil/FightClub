using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    class Player
    {
        private BodyPart blocked;
        private int healthPoints = 100;
        private string name;

        public Player(string name)
        {
            this.name = name;
        }

        public event EventHandler<PlayerEventArgs> Wound;

        private void OnWound()
        {
            var playerEventArgs = new PlayerEventArgs();

            if (Wound != null)
            {
                playerEventArgs.name = this.Name;
                playerEventArgs.healthPoints = this.HealthPoints;
                Wound(this, playerEventArgs);
            }
        }

        public event EventHandler<PlayerEventArgs> Block;

        private void OnBlock()
        {
            var playerEventArgs = new PlayerEventArgs();

            if (Block != null)
            {
                playerEventArgs.name = this.Name;
                playerEventArgs.healthPoints = this.HealthPoints;
                Block(this, playerEventArgs);
            }
        }

        public event EventHandler<PlayerEventArgs> Death;

        private void OnDeath()
        {
            var playerEventArgs = new PlayerEventArgs();

            if (Death != null)
            {
                playerEventArgs.name = this.Name;
                playerEventArgs.healthPoints = this.HealthPoints;
                Death(this, playerEventArgs);
            }
        }

        public BodyPart Blocked
        {
            get
            {
                return blocked;
            }
            set => blocked = value;
        }

        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
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

        public string Name
        {
            get => name;
        }

        public void GetHit(BodyPart targetBodyPart)
        {
            if (blocked == targetBodyPart)
            {
                OnBlock();
            }
            else
            {
                HealthPoints = HealthPoints - 20;
            }
        }
    }
}

// idea: do everything in FC style
// idea: do everything useing MVC
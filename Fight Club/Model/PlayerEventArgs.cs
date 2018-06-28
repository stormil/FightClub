using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    class PlayerEventArgs: EventArgs
    {
        public PlayerEventArgs(string name, int id, int healthPoints)
        {
            Name = name;
            Id = id;
            HealthPoints = healthPoints;
        }

        public string Name { get; }
        public int HealthPoints { get; }
        public int Id { get; }
    }
}

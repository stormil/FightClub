using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    class GameModelEventArgs
    {
        public GameModelEventArgs(int roundIndex)
        {
            RoundIndex = roundIndex;
        }

        public int RoundIndex { get; }
    }
}

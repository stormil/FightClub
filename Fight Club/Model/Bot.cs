using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    class Bot
    {
        public static BodyPart choseBodyPart()
        {
            var random = new Random();
            return (BodyPart)random.Next(3);
        }
    }
}

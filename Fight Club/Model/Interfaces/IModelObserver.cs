using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    interface IModelObserver
    {
        void modelChanged(IGameModel model, GameModelEventArgs e);
    }
}

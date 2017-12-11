using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman_1.GameState.States
{
    class PlayingState:State
    {
        public void atachState(StateContext context)
        {
            context.setState(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bomberman_1.GameState;

namespace Bomberman_1.StateHistory
{
    class Memento
    {
        private State state;

        public Memento(State state)
        {
            this.state = state;
        }

        public State getState()
        {
            return this.state;
        }
    }
}

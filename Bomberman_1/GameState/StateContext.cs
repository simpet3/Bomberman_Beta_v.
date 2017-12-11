using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bomberman_1.StateHistory;

namespace Bomberman_1.GameState
{
    class StateContext
    {
        private State state;

        public StateContext()
        {
            state = null;
        }

        public void setState(State state)
        {
            this.state = state;
        }

        public State getState()
        {
            return this.state;
        }

        public void getStateFromMemento(Memento mementoState)
        {
            setState(mementoState.getState());
        }

        public Memento saveStateToMemento()
        {
            return new Memento(this.state);
        }
    }
}

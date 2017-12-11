using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bomberman_1.StateHistory
{
    class StateHistory
    {
        private List<Memento> stateHistory = new List<Memento>();

        public void add(Memento state)
        {
           this.stateHistory.Add(state); 
        }

        public Memento getState(int index)
        {
            return this.stateHistory[index];
        }
    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bomberman_1.GameState.States;

namespace Bomberman_1.GameState
{
    class StateFactory
    {
        private static Dictionary<String, State> stateMap = new Dictionary<string,State>();

        public static State getState(String stateName)
        {
            State output;

            if (stateMap.TryGetValue(stateName, out output))
            {
                return output;
            }
            else
            {
                stateMap.Add(stateName, createState(stateName));
            }
            return getState(stateName);
        }



        private static State createState(String stateName)
        {
            if (stateName.Equals("PausedState"))
            {
                return new PausedState();
            }

            if (stateName.Equals("PlayingState"))
            {
                return new PlayingState();
            }

            return null;
        }
    }
}

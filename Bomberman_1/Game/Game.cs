using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Bomberman_1.GameState;
using BomberManProject.map;
using BomberManProject.player;
using BomberManProject.tile.build;

namespace Bomberman_1.Game
{
    class Game : StateContext
    {
        //private Map map;
        private Player player;

        public Game( Player player) : base()
        {
           // this.map = map;
            this.player = player;

        }

        //public Map getMap()
        //{
        //    return this.map;
        //}

        public Player getPlayer()
        {
            return this.player;
        }
    }
}

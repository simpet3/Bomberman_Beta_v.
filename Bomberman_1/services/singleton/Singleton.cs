using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.map;
using BomberManProject.player;
using Bomberman_1.services.mouse_Data;

namespace BomberManProject.Singleton
{
    class Singleton
    {
        private static Singleton _instance;

        public MouseData mouseData = new MouseData(0, 0);
        private Map map;
        private List<Player> players;

        private Singleton() { }

        public static Singleton getInstance()
        {
            if (_instance == null)
            {
                return new Singleton();
            }
            return _instance;
        }

        public MouseData getMouseData()
        {
            return this.mouseData;
        }
    }
}

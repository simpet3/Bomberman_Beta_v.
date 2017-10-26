using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.map;
using BomberManProject.player;

namespace BomberManProject.Singleton
{
    class Singleton
    {
        private static Singleton _instance;

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
    }
}

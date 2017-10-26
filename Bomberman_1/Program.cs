using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bomberman_1.services;
using BomberManProject.map;
using BomberManProject.tile.build;

namespace Bomberman_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new mapServices().generateMap();
            PrintMapToConsole a = new PrintMapToConsole();
            a.PrintMap(map.tiles);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bomberman_1.services;
using BomberManProject.map;
using BomberManProject.tile.build;
using BomberManProject.tile.decorator;

namespace Bomberman_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Map generation test
            Map map = new mapServices().generateMap();
            PrintMapToConsole a = new PrintMapToConsole();
            a.PrintMap(map.tiles);

            ConsoleDecoratorTest decorator = new ConsoleDecoratorTest();
            decorator.test();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BomberManProject.map;
using BomberManProject.tile.build;
using Bomberman_1.services;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Bomberman_1.Drawing
{
    public class MapPartDisplayVisitor : IMapPartVisitor
    {
        public int[,] map = mapInConsole();

        static public int [,] mapInConsole()
        {
            Map map = new mapServices().generateMap();
            PrintMapToConsole a = new PrintMapToConsole();
            return a.PrintMap(map.tiles);
        }
        
        public void visit(MapParts mapParts)
        {

            Console.WriteLine("Displaying map");
        }

        public void visit(Path path)
        {
            Console.WriteLine("displaying path");
        }

        public void visit(Destructable destructable)
        {
            Console.WriteLine("displaying destructable");
        }

        public void visit(Undestructable undestructable)
        {
            Console.WriteLine("displaying undestructable");
        }
    }
}

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
        static int yTileMax = 18;
        static int xTileMax = 18;

        static public int[,] mapInConsole()
        {
            Map map = new mapServices().generateMap();
            PrintMapToConsole a = new PrintMapToConsole();
            return a.PrintMap(map.tiles);
        }

        public void visit(MapParts mapParts, object sender, PaintEventArgs e)
        {
           
        }

        public void visit(Path path, object sender, PaintEventArgs e)
        {
            //for (int i = 0; i < xTileMax; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < yTileMax; j++)
            //    {
            //        if(map[i,j] == 3)
            //            e.Graphics.FillRectangle(Brushes.WhiteSmoke, i * 50, j * 50, 50, 50);
            //    }
            //}
        }

        public void visit(Destructable destructable, object sender, PaintEventArgs e)
        {
            for (int i = 0; i < xTileMax; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < yTileMax; j++)
                {
                    if (map[i, j] == 1)
                        e.Graphics.FillRectangle(Brushes.Brown, i * 50, j * 50, 50, 50);
                }
            }
        }

        public void visit(Undestructable undestructable, object sender, PaintEventArgs e)
        {
            for (int i = 0; i < xTileMax; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < yTileMax; j++)
                {
                    if (map[i, j] == 0)
                        e.Graphics.FillRectangle(Brushes.Black, i * 50, j * 50, 50, 50);
                }
            }
        }
        public void visit(WithBuff withBuff, object sender, PaintEventArgs e)
        {
            for (int i = 0; i < xTileMax; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < yTileMax; j++)
                {
                    if (map[i, j] == 2)
                        e.Graphics.FillRectangle(Brushes.Blue, i * 50, j * 50, 50, 50);
                }
            }
        }
    }
}

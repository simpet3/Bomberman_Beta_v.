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
        static int Template1 = 1;
        static int Template2 = 2;

        static public int[,] mapInConsole()
        {
            Map map = new mapServices().generateMap();
            PrintMapToConsole a = new PrintMapToConsole();
            return a.PrintMap(map.tiles);
        }

        public void visit(MapParts mapParts, int index, object sender, PaintEventArgs e)
        {
           
        }

        public void visit(Path path, int index, object sender, PaintEventArgs e)
        {
            // == 0
        }

        public void visit(Destructable destructable, int index, object sender, PaintEventArgs e)
        {
            for (int i = 0; i < xTileMax; i++)
            {
                //Console.WriteLine();
                for (int j = 0; j < yTileMax; j++)
                {
                    if (map[i, j] == 1)
                        if(index == Template1)
                            e.Graphics.FillRectangle(Brushes.Brown, i * 50, j * 50, 50, 50);
                        else
                            e.Graphics.FillRectangle(Brushes.LightBlue, i * 50, j * 50, 50, 50);
                }
            }
        }

        public void visit(Undestructable undestructable, int index, object sender, PaintEventArgs e)
        {
            for (int i = 0; i < xTileMax; i++)
            {
                //Console.WriteLine();
                for (int j = 0; j < yTileMax; j++)
                {
                    if (map[i, j] == 0)  
                        if (index == Template1)
                            e.Graphics.FillRectangle(Brushes.Black, i * 50, j * 50, 50, 50);
                        else
                            e.Graphics.FillRectangle(Brushes.LightSalmon, i * 50, j * 50, 50, 50);
                }
            }
        }
        public void visit(WithBuff withBuff, int index, object sender, PaintEventArgs e)
        {
            for (int i = 0; i < xTileMax; i++)
            {
                //Console.WriteLine();
                for (int j = 0; j < yTileMax; j++)
                {
                    if (map[i, j] == 2)
                        if (index == Template1)
                            e.Graphics.FillRectangle(Brushes.Red, i * 50, j * 50, 50, 50);
                        else
                            e.Graphics.FillRectangle(Brushes.LightYellow, i * 50, j * 50, 50, 50);
                }
            }
        }
    }
}

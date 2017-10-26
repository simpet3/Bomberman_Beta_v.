using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.coordinates;
using BomberManProject.tile;
using BomberManProject.tile.wall;

namespace BomberManProject.tile.build
{
    class FactoryPattern
    {
        static int xTileMax = 18;
        static int yTileMax = 18;
        static string empty = "Empty";
        static string simpleWall = "SimpleWall";
        static string immovableWall = "ImmovableWall";
        WallFactory wallFactory = new WallFactory();


        public List<ITile> buildWalls()
        {
            List<ITile> walls = new List<ITile>();
            List<ITile> temp1 = buildBreakable();
            List<ITile> temp2 = buildUnbreakable();

            //Adds lists together
            return walls.Concat(temp1).Concat(temp2).ToList();
        }

        public List<ITile> buildUnbreakable()
        {
            List<ITile> walls = new List<ITile>();
            
            for(int i = 1; i < xTileMax - 1; i++)
            {
                if (i % 2 == 1)
                    for (int j = 1; j < yTileMax - 1; j++)
                    {
                        if (j % 2 == 1)
                        {
                            WallFactory factory = new WallFactory();
                            TileCoordinates coordinates = new TileCoordinates(i, j);
                            walls.Add(factory.makeWall("ImmovableWall", coordinates));
                        }
                    }
            }
            return walls;
        }
        public List<ITile> buildBreakable()
        {
            List<ITile> walls = new List<ITile>();
            //ITile a;
            //WallFactory f = new WallFactory();
            //a = f.makeWall("Immovable", new TileCoordinates(0, 0));
            //WallFactory aa = (WallFactory)a;
            for (int i = 3; i < xTileMax - 1; i++)
            {
                if (i % 2 == 1)
                    for (int j = 2; j < yTileMax - 1; j++)
                    {
                        if (j % 2 == 0)
                        {
                            WallFactory factory = new WallFactory();
                            TileCoordinates coordinates = new TileCoordinates(i, j);
                            walls.Add(factory.makeWall("SimpleWall", coordinates));
                        }
                    }
            }
            return walls;
        }

    }
}

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


        //public List<ITile> buildWalls()
        //{
        //    TileCoordinates coordinates = new TileCoordinates(3, 3);
        //    Walls.Add(wallFactory.makeWall(simpleWall, coordinates));

        //    coordinates.changeCoord(5, 5);
        //    Walls.Add(wallFactory.makeWall(immovableWall, coordinates));
        //}
        //public List<ITile> buildBreakable()
        //{

        //}
        public List<ITile> buildUnbreakable()
        {
            List<ITile> walls = new List<ITile>();
            
            for(int i = 1; i < xTileMax - 1; i++)
            {
                if (i % 2 == 1)
                    for (int j = 1; i < yTileMax - 1; i++)
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
                    for (int j = 2; i < yTileMax - 1; i++)
                    {
                        if (j % 2 == 0)
                        {
                            WallFactory factory = new WallFactory();
                            TileCoordinates coordinates = new TileCoordinates(i, j);
                            walls.Add(factory.makeWall("ImmovableWall", coordinates));
                        }
                    }
            }
            return walls;
        }

    }
}

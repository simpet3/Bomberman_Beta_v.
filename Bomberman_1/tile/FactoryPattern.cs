using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.coordinates;

namespace BomberManProject.tile
{
    class FactoryPattern
    {
        static int xTileMax = 18;
        static int yTileMax = 18;
        static string empty = "Empty";
        static string simpleWall = "SimpleWall";
        static string immovableWall = "ImmovableWall";
        WallFactory wallFactory = new WallFactory();

        List<IWallTile> Walls = new List<IWallTile>();
        
        public void makeWalls()
        {
            TileCoordinates coordinates = new TileCoordinates(3, 3);
            Walls.Add(wallFactory.makeWall(simpleWall, coordinates));

            coordinates.changeCoord(5, 5);
            Walls.Add(wallFactory.makeWall(immovableWall, coordinates));

        }
    }
}

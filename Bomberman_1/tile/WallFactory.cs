using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.coordinates;

namespace BomberManProject.tile
{
    // Creates regular walls and immovable walls
    class WallFactory
    { 
        static string empty = "Empty";
        static string simpleWall = "SimpleWall";
        static string immovableWall = "ImmovableWall";

        //Use makeWall, to get wall of that type
        public IWallTile makeWall(string wallType, TileCoordinates coordinates)
        {
            if (wallType.Equals(empty, StringComparison.Ordinal)) {
                return null;
                Console.WriteLine("making: Empty tile");
            }
            else if (wallType.Equals(simpleWall, StringComparison.Ordinal))
            {
                return new SimpleWall(coordinates);
                Console.WriteLine("making: SimpleWall");
            }
            else if (wallType.Equals(immovableWall, StringComparison.Ordinal))
            {
                return new ImmovableWall(coordinates);
                Console.WriteLine("making: ImmovableWall");
            }
            return null;
        }
    }
}

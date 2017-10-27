using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.coordinates;

namespace BomberManProject.tile.wall
{
    // Creates regular walls and immovable walls
    class WallFactory
    { 
        public static string empty = "Empty";
        public static string simpleWall = "SimpleWall";
        public static string immovableWall = "ImmovableWall";

        //Use makeWall, to get wall of that type
        public ITile makeWall(string wallType, TileCoordinates coordinates)
        {
            if (wallType.Equals(empty, StringComparison.Ordinal)) {  
                //Console.WriteLine("making: Empty tile");
                return null;
            }
            else if (wallType.Equals(simpleWall, StringComparison.Ordinal))
            {
                //Console.WriteLine("making: SimpleWall");
                return new SimpleWall(coordinates);
            }
            else if (wallType.Equals(immovableWall, StringComparison.Ordinal))
            {       
                //Console.WriteLine("making: ImmovableWall");
                return new ImmovableWall(coordinates);
            }
            return null;
        }
    }
}

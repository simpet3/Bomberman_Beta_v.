using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.tile;

namespace BomberManProject.tile.build
{
    class PrintMapToConsole
    {
        string type1 = "BomberManProject.tile.wall.ImmovableWall";
        string type2 = "BomberManProject.tile.wall.SimpleWall";
        string type3 = "BomberManProject.tile.wall.WallWithBuff";
        string type4 = "BomberManProject.tile.PathTile";
        static int yTileMax = 18;
        static int xTileMax = 18;

        int[,] map = new int[xTileMax, yTileMax];
        public void PrintMap(List<ITile> list)
        {
            for (int i = 0; i < xTileMax; i++)
            {
                for (int j = 0; j < yTileMax; j++)
                {
                    map[i, j] = 9;
                }
            }
            foreach (ITile tile in list)
            {
                System.Type type = tile.GetType();
                string typeString = type.ToString();
                if (String.Equals(type1, typeString, StringComparison.Ordinal))
                {
                    //Console.Write(tile.getCoordinates().yTileCoordinate);
                    map[tile.getCoordinates().xTileCoordinate, tile.getCoordinates().yTileCoordinate] = 0;
                }
                else if (String.Equals(type2, typeString, StringComparison.Ordinal))
                {
                    //Console.Write(tile.getCoordinates().yTileCoordinate);
                    map[tile.getCoordinates().xTileCoordinate, tile.getCoordinates().yTileCoordinate] = 1;
                }
                else if (String.Equals(type3, typeString, StringComparison.Ordinal))
                {
                    //Console.Write(tile.getCoordinates().yTileCoordinate);
                    map[tile.getCoordinates().xTileCoordinate, tile.getCoordinates().yTileCoordinate] = 2;
                }
                else if (String.Equals(type4, typeString, StringComparison.Ordinal))
                {
                    //Console.Write(tile.getCoordinates().xTileCoordinate);
                    map[tile.getCoordinates().xTileCoordinate, tile.getCoordinates().yTileCoordinate] = 3;
                }    
            }
            for (int i = 0; i < xTileMax; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < yTileMax; j++)
                {
                    Console.Write(map[i, j]);
                }
            }
        }
    }
}

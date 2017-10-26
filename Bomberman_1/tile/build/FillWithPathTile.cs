using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.tile;
using BomberManProject.coordinates;

namespace BomberManProject.tile.build
{
    class FillWithPathTile
    {
        static int yTileMax = 18;
        static int xTileMax = 18;
        //public FillWithPathTile() { }

        public List<ITile> fillMap(List<ITile> mapWithNoPath)
        {
            List<ITile> map = new List<ITile>();
            for (int i = 0; i < xTileMax; i++)
            {
                for (int j = 0; j < yTileMax; j++)
                {
                    bool isfree = true;
                    foreach (ITile tile in mapWithNoPath)
                    {
                        if (tile.getCoordinates().xTileCoordinate == i && tile.getCoordinates().yTileCoordinate == j)
                        {
                            isfree = false;
                            break;
                        }
                    }
                    if (isfree)
                    {
                        Console.WriteLine("Build: Filling with path");
                        ITile path = new PathTile(new BomberManProject.coordinates.TileCoordinates(i, j));
                        map.Add(path);
                    }
                }        
            }
            foreach (ITile tile in mapWithNoPath)
            {
                map.Add(tile);
            }
            return map;
        }
    }
}

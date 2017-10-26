using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.coordinates;

namespace BomberManProject.tile
{
    class WallsWithBuffsBuilder
    {
        List<WallWithBuff> walls = new List<WallWithBuff>();

        static int PowerBuff = 1;
        static int BombNumberBuff = 2;
        static int yTileMax = 18;
        static int xTileMax = 18;
        int index = 1;

        public WallsWithBuffsBuilder()
        {
            for (int i = 2; i < xTileMax-1; i++)
            {
                if (i % 2 == 1)
                    for (int j = 2; i < yTileMax-1; i++)
                    {
                        if (j % 2 == 1) {
                            WallWithBuff wall;
                            if (index == 1)
                            {
                                wall = new WallWithBuff(new TileCoordinates(i, j), PowerBuff);
                                index = 2;
                                walls.Add(wall);
                            }
                            else if(index == 2)
                            {
                                wall = new WallWithBuff(new TileCoordinates(i, j), BombNumberBuff);
                                index = 1;
                                walls.Add(wall);
                            }
                        }
                    }
            }
        }
    }
}

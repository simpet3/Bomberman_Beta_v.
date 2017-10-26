using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.coordinates;
using BomberManProject.tile.wall;

namespace BomberManProject.tile.build
{
    class BuilderPattern
    {
        static int PowerBuff = 1;
        static int BombNumberBuff = 2;
        static int yTileMax = 18;
        static int xTileMax = 18;
        int index = 1;

        public List<ITile> buildWallsWithBuffs()
        {
            List<ITile> walls = new List<ITile>();
            for (int i = 2; i < xTileMax-1; i++)
            {
                if (i % 2 == 0)
                    for (int j = 2; j < yTileMax-1; j++)
                    {
                        if (j % 2 == 0) {
                            WallWithBuff wall;
                            if (index == 1)
                            {
                                wall = new WallWithBuff(new TileCoordinates(i, j), PowerBuff);
                                index = 2;
                                walls.Add(wall);
                                Console.WriteLine("Building: SimpleWall+Powerbuff");
                            }
                            else if(index == 2)
                            {
                                wall = new WallWithBuff(new TileCoordinates(i, j), BombNumberBuff);
                                index = 1;
                                walls.Add(wall);
                                Console.WriteLine("Building: SimpleWall+BombNumberBuff");
                            }
                        }
                    }             
            }
            return walls;
        }
    }
}

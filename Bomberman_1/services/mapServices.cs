using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.map;
using BomberManProject.tile;
using BomberManProject.tile.wall;
using BomberManProject.coordinates;

namespace Bomberman_1.services
{
    class mapServices
    {
        // map size 18 on 18
        static int yTileMax = 18;
        static int xTileMax = 18;
        
        public Map generateMap()
        {
            Map map = new Map();
            for(int i = 0; i < xTileMax; i++)
            {
                for(int j = 0; j < yTileMax; j++)
                {

                }
            }
            return map;
        }
        //Generates all walls with buff to ITile list
        public List<ITile> generateWallsWithBuffs()
        {
            List<ITile> wallsWithBuffs;
            WallsWithBuffsBuilder builder = new WallsWithBuffsBuilder();
            wallsWithBuffs = builder.buildWallsWithBuffs();
            return wallsWithBuffs;
        }
        //Generates breakable and unbreakable walls
        //public List<ITile> generateImmovableAndSimpleWalls()
        //{
        //    List<ITile> walls;
        //    FactoryPattern factory = new FactoryPattern();
        //   // walls = factory.buildWalls();
        //    return walls;

        //}


    }
}

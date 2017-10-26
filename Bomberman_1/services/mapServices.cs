using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.map;
using BomberManProject.tile;
using BomberManProject.tile.wall;
using BomberManProject.tile.build;
using BomberManProject.coordinates;

namespace Bomberman_1.services
{
    class mapServices
    {
        public Map generateMap()
        {
            Map map = new Map();
            //FillWithPathTile filler = new FillWithPathTile();
            map.tiles = map.tiles.Concat(new BuilderPattern().buildWallsWithBuffs()).Concat(new FactoryPattern().buildWalls()).ToList();
            map.tiles = new FillWithPathTile().fillMap(map.tiles);
            return map;
        }
    }
}

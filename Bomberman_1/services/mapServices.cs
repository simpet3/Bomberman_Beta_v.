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
using BomberManProject.Singleton;

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

        public List<Coordinates> getRealWallCoordinatesFromMap(Map map, int convertRatio )
        {
            var serviceOfCoordConvertion = ServicesSingleton.getInstance().coordinatesTransformationService;
            return serviceOfCoordConvertion.getRealCoordinatesFromTilesOfType(map, typeof(IWallTile), convertRatio, this);
        }



        public List<TileCoordinates> getTileCoordinatesOfType(Map map, Type ITileType) 
        {
            var list = new List<TileCoordinates>();
            foreach(ITile item in map.getTiles())
            {
                if(item.GetType()== ITileType)
                {
                    list.Add(item.getCoordinates());
                }
            }
            return list;
        }

    }
}

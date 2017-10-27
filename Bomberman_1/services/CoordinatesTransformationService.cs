using BomberManProject.coordinates;
using BomberManProject.map;
using BomberManProject.tile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman_1.services
{
    class CoordinatesTransformationService
    {

        private int ConvertCoordToRealLowerBound(int value, int ratio)
        {
            return value * ratio;
        }

        private int ConvertCoordToRealUpperBound(int value, int ratio)
        {
            return value * ratio + (ratio - 1);
        }

        private List<Coordinates> getRealCoordinatesFromTileCoordinates(int convertRatio, int x, int y)
        {
            List<Coordinates> coordinates = new List<Coordinates>();

            for (int i = ConvertCoordToRealLowerBound(x, convertRatio); i <= ConvertCoordToRealUpperBound(x, convertRatio); i++)
            {
                for (int j = ConvertCoordToRealLowerBound(y, convertRatio); j <= ConvertCoordToRealUpperBound(y, convertRatio); j++)
                {
                    coordinates.Add(new Coordinates(i, j));
                }
            }
            return coordinates;
        }

        public List<Coordinates> getRealCoordinatesFromTilesOfType(Map map, Type type,int convertRatio, mapServices mapService)
        {
            var list = new List<Coordinates>();

            foreach (TileCoordinates item in mapService.getTileCoordinatesOfType(map, type))
            {
                list.AddRange(getRealCoordinatesFromTileCoordinates(convertRatio, item.xTileCoordinate, item.yTileCoordinate));
            }

            return list;
        }


    }
}

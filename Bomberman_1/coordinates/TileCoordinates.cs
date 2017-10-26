using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberManProject.coordinates
{
    class TileCoordinates
    {
        public int xTileCoordinate { get; private set; }
        public int yTileCoordinate { get; private set; }

        //public TileCoordinates()
        //{
        //    this.xTileCoordinate = 0;
        //    this.yTileCoordinate = 0;
        //}
        public TileCoordinates(int x, int y)
        {
            this.xTileCoordinate = x;
            this.yTileCoordinate = y;
        }

        //Tile width is 50 pixels
        public TileCoordinates(Coordinates coordinates)
        {
            this.xTileCoordinate = coordinates.xCoordinate / 50;
            this.yTileCoordinate = coordinates.YCoordinate / 50;
        }

        public void changeCoord(int x, int y)
        {
            this.xTileCoordinate = x;
            this.yTileCoordinate = y;
        }
    }
}

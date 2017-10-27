﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberManProject.coordinates
{
    class Coordinates
    {
        public int xCoordinate { get; private set; }

        public int YCoordinate { get; private set; }

        public Coordinates(int xCoordinate, int yCoordinate)
        {
            this.xCoordinate = xCoordinate;
            this.YCoordinate = yCoordinate;
        }

        public Coordinates(TileCoordinates coordinates)
        {
            this.xCoordinate = coordinates.xTileCoordinate * 50;
            this.YCoordinate = coordinates.yTileCoordinate * 50;
        }
    }
}

﻿using BomberManProject.tile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.coordinates;
using BomberManProject.bomb;
using BomberManProject.improvement;
using BomberManProject.interactiveItem;
using Bomberman_1.ObserverHelpers;

namespace BomberManProject.tile
{
    class PathTile : Observer, ITile
    {
        public TileCoordinates coordinates { get; private set; }
        public IInteractiveItem interactiveItem { get; set; }
        public Bomb bomb { get; private set; }

        public PathTile(TileCoordinates coordinates)
        {
            this.coordinates = coordinates;
            this.interactiveItem = null;
        }


        public TileCoordinates getCoordinates()
        {
            return this.coordinates;
        }

        public Boolean isBombPlanted()
        {
            return this.bomb == null ? false : true;
        }

        public override void updateAfterExplosion()
        {
            Console.WriteLine(" Path Tile - responded to exploded bomb");
        }
    }
}

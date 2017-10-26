using BomberManProject.tile;
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
    class PathTile : Observer,ITile
    {
        public TileCoordinates coordinates { get; private set; }
        public IInteractiveItem interactiveItem { get; set; }
        public Bombb bomb { get; private set; }

        public PathTile(TileCoordinates coordinates, IInteractiveItem IInteractiveItem)
        {
            this.coordinates = coordinates;
            this.interactiveItem = IInteractiveItem;
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
            throw new NotImplementedException();
        }
    }
}

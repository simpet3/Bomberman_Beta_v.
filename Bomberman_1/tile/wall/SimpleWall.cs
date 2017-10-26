
using BomberManProject.coordinates;
using BomberManProject.improvement;
using BomberManProject.tile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.coordinates;
using Bomberman_1.ObserverHelpers;

namespace BomberManProject.tile.wall
{
     class SimpleWall : Observer, IWallTile
    {
        public Boolean _isDestructed { get; private set; }
        public TileCoordinates coordinates { get; private set; }
        public bool Immovable { set; get; }

        public SimpleWall(TileCoordinates coordinates)
        {
            this._isDestructed = false;
            this.coordinates = new TileCoordinates();
            this.Immovable = false;
        }

        public Boolean isDestructed()
        {
            return this._isDestructed;
        }

        public void CrushTile()
        {
            this._isDestructed = true;
        }

        public TileCoordinates getCoordinates()
        {
            return this.coordinates;
        }

        public override void updateAfterExplosion()
        {
            throw new NotImplementedException();
        }

        //public IImprovement getImprovement()
        //{
        //    return this.improvement;
        //}
    }
}

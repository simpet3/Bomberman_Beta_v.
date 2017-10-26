
using BomberManProject.coordinates;
using BomberManProject.improvement;
using BomberManProject.tile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.coordinates;

namespace BomberManProject.tile.wall
{
    class SimpleWall : IWallTile
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

        //public IImprovement getImprovement()
        //{
        //    return this.improvement;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.coordinates;

namespace BomberManProject.tile.wall
{
    class ImmovableWall : IWallTile
    {
        bool IWallTile.Immovable { get; set; }
        TileCoordinates coordinates { get; set; }
        bool Immovable { get; set; }

        public ImmovableWall(TileCoordinates coordinates)
        {
            this.coordinates = coordinates;
            this.Immovable = true;
        }

        public TileCoordinates getCoordinates()
        {
            throw new NotImplementedException();
        }
    }
}

using BomberManProject.tile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.coordinates;
using BomberManProject.bomb;
using BomberManProject.improvement;

namespace BomberManProject.tile
{
    class PathTile : IInteractiveTile
    {
        public TileCoordinates coordinates { get; private set; }
        public IImprovement improvement { get; private set; }
        public Bombb bomb { get; private set; }

        public PathTile(TileCoordinates coordinates, IImprovement improvement)
        {
            this.coordinates = coordinates;
            this.improvement = improvement;
        }

        public TileCoordinates getCoordinates()
        {
            return this.coordinates;
        }

        public IImprovement getImprovement()
        {
            return this.improvement;
        }

        public Boolean isBombPlanted()
        {
            return this.bomb == null ? false : true;
        }
    }
}

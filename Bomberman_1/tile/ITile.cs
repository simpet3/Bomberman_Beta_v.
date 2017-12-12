using BomberManProject.coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberManProject.tile
{
    public interface ITile
    {
        TileCoordinates getCoordinates();
    }
}


using BomberManProject.tile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberManProject.map
{
    class Map
    {
        // gal reikia size of map
        public List<ITile> tiles { get; private set; }

        public List<ITile> getTiles()
        {
            return this.tiles;
        }
    }
}

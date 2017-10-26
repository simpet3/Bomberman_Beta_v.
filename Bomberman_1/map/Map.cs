
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
        public List<ITile> tiles = new List<ITile>();
        //public List<ITile> tiles { get; private set; }

        public Map(){
            //this.tiles = null;
        }
        

        public List<ITile> getTiles()
        {
            return this.tiles;
        }
    }
}

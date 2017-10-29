using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.bomb;
using BomberManProject.coordinates;
using BomberManProject.map;
using BomberManProject.player;
using BomberManProject.improvement;

namespace BomberManProject.tile.decorator
{
    abstract class Decorator : Improvement
    {
        protected Improvement improvement;


        protected Decorator(Improvement improvement)
        {
            this.improvement = improvement;
        }

    }
}

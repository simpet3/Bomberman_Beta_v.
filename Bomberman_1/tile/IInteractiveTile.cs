
using BomberManProject.improvement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberManProject.tile
{
    interface IInteractiveTile : ITile
    {
        IImprovement getImprovement();
    }
}

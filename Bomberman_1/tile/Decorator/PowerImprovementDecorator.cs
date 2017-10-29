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
    class PowerImprovementDecorator : Decorator
    {
        public PowerImprovementDecorator(Improvement improvement) : base(improvement)
        {
            if (improvement.GetType().ToString() == "BomberManProject.tile.decorator.PowerImprovementDecorator")
            {
                int power = this.improvement.getImprovement() + 1;
                this.improvement = new PowerImprovement(power);
            }
            else
                this.improvement = new PowerImprovement();
        }

        public override int getImprovement()
        {
            return improvement.getImprovement();
        }
    }
}

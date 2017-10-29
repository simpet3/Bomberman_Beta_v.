using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.player;
using BomberManProject.improvement;

namespace BomberManProject.tile.decorator
{
    class BombCountImprovementDecorator : Decorator
    {
        public BombCountImprovementDecorator(Improvement improvement) : base(improvement)
        {
            if (improvement.GetType().ToString() == "BomberManProject.tile.decorator.BombCountImprovementDecorator")
            {
                int count = this.improvement.getImprovement() + 1;
                this.improvement = new CountImprovement(count);
            }
            else
                this.improvement = new CountImprovement();
        }

        public override int getImprovement()
        {
            return improvement.getImprovement();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberManProject.improvement
{
    class PowerImprovement : IImprovement
    {
        //Starting bomb power is 0;
        int improvementPower = 0;

        //Improves bomb's power by 1;
        public PowerImprovement()
        {
            this.improvementPower++;
        }

        public int getImprovement()
        {
            return this.improvementPower;
        }
    }
}

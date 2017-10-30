using BomberManProject.interactiveItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.player;

namespace BomberManProject.improvement
{
    class PowerImprovement : Improvement, IInteractiveItem
    {
        //Starting bomb power is 0;
        int improvementPower { set; get; }

        //Improves bomb's power by 1;
        public PowerImprovement()
        {
            this.improvementPower = 1;
        }
        public PowerImprovement(int power)
        {
            this.improvementPower = power;
        }
        public override int getImprovement()
        {
            return improvementPower;
        }
        public void increasePower()
        {
            improvementPower++;
        }

        public void interact()
        {
            throw new NotImplementedException();
        }
    }
}

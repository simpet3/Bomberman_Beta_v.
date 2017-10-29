using BomberManProject.interactiveItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberManProject.improvement
{
    class CountImprovement : Improvement, IInteractiveItem
    {
        //Starting ammount of bombs a player can plant
        int improvementCount { set; get; }

        public CountImprovement()
        {
            this.improvementCount = 2;
        }
        public CountImprovement(int bombNum)
        {
            this.improvementCount = bombNum;
        }

        public override int getImprovement()
        {
            return this.improvementCount;
        }

        public void increaseCount()
        {
            this.improvementCount++;
        }
        public void interact()
        {
            throw new NotImplementedException();
        }
    }
}

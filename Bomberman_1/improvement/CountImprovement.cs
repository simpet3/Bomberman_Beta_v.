﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberManProject.improvement
{
    class CountImprovement : IImprovement
    {
        //Starting ammount of bombs a player can plant
        int improvementCount = 1;

        public CountImprovement()
        {
            this.improvementCount++;
        }

        public int getImprovement()
        {
            return this.improvementCount;
        }
    }
}

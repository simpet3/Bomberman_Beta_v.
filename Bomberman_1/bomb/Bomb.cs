
using Bomberman_1.ObserverHelpers;
using BomberManProject.improvement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberManProject.bomb
{
    class Bombb : Subject 
    {
        public double durationOfDetonation { get; private set; }

        public int explosionPower { get; private set; }

        public int explosionDistance { get; private set; }

        public List<IImprovement> improvements { get; private set; }


        public Bombb(double durationOfDetonation, int explosionPower, int explosionDistance, List<IImprovement> improvements)
        {
            this.durationOfDetonation = durationOfDetonation;

            this.explosionPower = explosionPower;

            this.explosionDistance = explosionDistance;

            this.improvements = improvements;

            this.improvements = new List<IImprovement>();
        }

        //Default settings
        public Bombb()
        {
            this.durationOfDetonation = 3;

            this.explosionPower = 0;

            this.explosionDistance = 1;

            this.improvements = null;
        }

        public int getExplosionDistance()
        {

            return this.explosionDistance + this.improvements.Where(a => a is CountImprovement).Sum(b => ((CountImprovement)b).getImprovement());
        }


        public double getDurationOfDetonation()
        {
            return this.durationOfDetonation;
        }


        public int getExplosionPower()
        {
            return this.explosionPower + +this.improvements.Where(a => a is PowerImprovement).Sum(b => ((PowerImprovement)b).getImprovement());
        }

        public void explode()
        {
            notifyAllObservers();
            
        }

        public void addImprovement(IImprovement improvement)
        {
            this.improvements.Add(improvement);
        }

    }
}

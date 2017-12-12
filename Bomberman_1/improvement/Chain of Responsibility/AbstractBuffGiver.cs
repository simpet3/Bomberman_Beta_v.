using Bomberman_1.player;
using BomberManProject.player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman_1.improvement.Chain_of_Responsibility
{
    public abstract class AbstractBuffGiver
    {
        public static int NONE = 1;
        public static int POWER = 2;
        public static int COUNT = 3;

        protected int level;

        //next element in chain or responsibility
        protected AbstractBuffGiver nextBuffGiver;

        public void setNextBuffGiver(AbstractBuffGiver nextBuffGiver)
        {
            this.nextBuffGiver = nextBuffGiver;
        }

        public Player giveBuff(int level, Player p)
        {
            if (this.level >= level)
            {
                return give(p);
            }
            if (nextBuffGiver != null)
            {
                nextBuffGiver.giveBuff(level, p);
            }
            return p;
        }

        abstract protected Player give(Player p);
    }
}

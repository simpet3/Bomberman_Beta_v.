using Bomberman_1.player;
using BomberManProject.player;
using BomberManProject.tile.decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman_1.improvement.Chain_of_Responsibility
{
    public class PowerGiver : AbstractBuffGiver
    {
        public PowerGiver(int level)
        {
            this.level = level;
        }

        protected override Player give(Player p)
        {
            //PowerImprovementDecorator pid = new PowerImprovementDecorator(p);
            p.improvement = new PowerImprovementDecorator(p);
            return p;
            Console.WriteLine("Power console::BuffGiver: ");
        }
    }
}
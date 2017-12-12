using Bomberman_1.player;
using BomberManProject.player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman_1.improvement.Chain_of_Responsibility
{
    class BuffRemover : AbstractBuffGiver
    {
        public BuffRemover(int level)
        {
            this.level = level;
        }
        protected override Player give(Player p)
        {
            p.improvement = new ProxyPlayer().improvement;
            Console.WriteLine("Remover console::BuffGiver: ");
            return p;
        }
    }
}

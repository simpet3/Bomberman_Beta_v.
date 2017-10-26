//using BomberManProject.controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.player;

namespace BomberManProject.commands
{
    class CommandPlantBomb : ICommand
    {
        private Player player;

        public CommandPlantBomb(Player player)
        {
            this.player = player;
        }

        public void execute()
        {
            this.player.plantBomb();
        }

    }
}

//using BomberManProject.controls;
using BomberManProject.player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberManProject.commands
{
    class CommandMoveUp : ICommand
    {
        private Player player;

        public CommandMoveUp(Player player)
        {
            this.player = player;
        }
        public void execute()
        {
            this.player.moveUp();
        }
    }
}

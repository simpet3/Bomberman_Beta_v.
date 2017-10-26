//using BomberManProject.controls;
using BomberManProject.player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberManProject.commands
{
    class CommandMoveRight : ICommand
    {
        private Player player;

        public CommandMoveRight(Player player)
        {
            this.player = player;
        }
        public void execute()
        {
            this.player.moveRight();
        }
    }
}

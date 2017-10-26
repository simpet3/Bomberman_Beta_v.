//using BomberManProject.controls;
using BomberManProject.player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.commands;

namespace BomberManProject.commands
{
    class CommandMoveLeft : ICommand
    {
        private Player player;

        public CommandMoveLeft(Player player)
        {
            this.player = player;
        }

        public void execute()
        {
            this.player.moveLeft();
        }
    }
}

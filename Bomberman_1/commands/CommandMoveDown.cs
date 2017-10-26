
using BomberManProject.player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberManProject.commands
{
    class CommandMoveDown : ICommand
    {
        private Player player;

        public CommandMoveDown(Player player)
        {
            this.player = player;
        }

        public void execute()
        {
            this.player.moveDown();
        }
    }
}

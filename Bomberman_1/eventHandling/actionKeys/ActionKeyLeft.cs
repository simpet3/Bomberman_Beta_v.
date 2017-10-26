using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using BomberManProject.controls;
using BomberManProject.player;
using BomberManProject.services;
using BomberManProject.commands;
using BomberManProject.eventHandling;

namespace BomberManProject.eventHandling.actionKeys
{
    class ActionKeyLeft : IAction
    {
        public ICommand createCommand(Player player)
        {
            return new CommandMoveLeft(player);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using BomberManProject.controls;
using BomberManProject.player;
using BomberManProject.services;
using BomberManProject.commands;

namespace BomberManProject.eventHandling.actionKeys
{
    class ActionKeySpace : IAction
    {
        public ICommand createCommand(Player player)
        {
            return new CommandPlantBomb(player);
        }
    }
}

//using BomberManProject.controls;
using BomberManProject.player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.commands;

namespace BomberManProject.eventHandling
{
    interface IAction
    {
        ICommand createCommand(Player player);
    }
}

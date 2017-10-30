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
    class Keyboard : Event
    {
        
        public Keyboard( IAction action) : base(action)
        {
        }
        public override ICommand handleEvent(Player player)
        {
            Console.WriteLine("Bridge paternas: kuria komanda Command patternui.");
            return action.createCommand(player);
        }
    }
}

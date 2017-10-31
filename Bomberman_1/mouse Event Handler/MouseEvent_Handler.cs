using BomberManProject.commands;
using BomberManProject.eventHandling;
using BomberManProject.eventHandling.actionKeys;
using BomberManProject.player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman_1.mouse_Event_Handler
{
    interface MouseEvent_Handler 
    {


        ICommand handleMouseEvent(Player player, MouseEventArgs e);

    }
}

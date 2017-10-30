using BomberManProject.commands;
using BomberManProject.eventHandling;
using BomberManProject.eventHandling.actionKeys;
using BomberManProject.player;
using BomberManProject.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman_1.mouse_Event_Handler
{
    class MouseEventHandlerAdapter : MouseEvent_Handler
    {
        Event _event { get; set; }

        public override ICommand handleMouseEvent(Player player, MouseEventArgs e)
        {
            // i singletona idet Mouse coordinates.//////////////////////////////
            var mouseData = Singleton.getInstance().mouseData;
            int lastX = mouseData.x;
            int lastY = mouseData.y;

            int dx = e.X - lastX;
            int dy = e.Y - lastY;

            if(e.Button == MouseButtons.Left)
            {
                _event = (new Keyboard(new ActionKeySpace()));
            }
            else if (Math.Abs(dx) > Math.Abs(dy))
                _event = (dx > 0) ? (new Keyboard(new ActionKeyRight())) : (new Keyboard(new ActionKeyLeft()));
            else
                _event = (dy > 0) ? (new Keyboard(new ActionKeyDown())) : (new Keyboard(new ActionKeyUp()));
            
            return _event.handleEvent(player);
        }
    }
}

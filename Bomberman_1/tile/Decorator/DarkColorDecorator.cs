using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.player;

namespace BomberManProject.tile.decorator
{
    class DarkColorDecorator : Decorator
    {
        public DarkColorDecorator(VisualComponent visualComponent) : base(visualComponent)
        {
            this.color = "Dark";
        }
        public override string getColor()
        {
            return base.getColor();
        }
    }
}
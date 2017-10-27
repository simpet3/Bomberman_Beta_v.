using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.bomb;
using BomberManProject.coordinates;
using BomberManProject.map;
using BomberManProject.player;

namespace BomberManProject.tile.decorator
{
    class BrightColorDecorator : Decorator
    {
        public BrightColorDecorator(VisualComponent visualComponent) : base(visualComponent)
        {
            this.color = "Light";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

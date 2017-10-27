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
    abstract class Decorator : VisualComponent
    {
        private VisualComponent visualComponent = null;

        protected string color = "";

        protected Decorator(VisualComponent visualComponent)
        {
            this.visualComponent = visualComponent;
        }

        public override string getColor()
        {
            return color + visualComponent.getColor();
        }
    }
}

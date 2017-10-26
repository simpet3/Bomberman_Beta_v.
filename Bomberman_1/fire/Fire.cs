using BomberManProject.coordinates;
using BomberManProject.interactiveItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberManProject.Fire
{
    class Fire : IInteractiveItem 
    {
        public Coordinates coordinates { get; private set; }
        
        public Fire(Coordinates coordinates)
        {
            this.coordinates = coordinates;
        }

        public void interact()
        {
            throw new NotImplementedException();
        }
    }
}

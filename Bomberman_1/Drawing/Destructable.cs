using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman_1.Drawing
{
    public class Destructable : IMapPart
    {
        public void accept(IMapPartVisitor mapPartVisitor)
        {
            mapPartVisitor.visit(this);
        }
    }
}

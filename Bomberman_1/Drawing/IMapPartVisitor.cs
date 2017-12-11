using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman_1.Drawing
{
    public interface IMapPartVisitor
    {
        void visit(Path computer);
        void visit(Destructable mouse);
        void visit(Undestructable keyboard);
        void visit(MapParts mapDrawing);
    }
}

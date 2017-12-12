using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman_1.Drawing
{
    public interface IMapPartVisitor
    {
        void visit(Path computer, int index, object sender, PaintEventArgs e);
        void visit(Destructable mouse, int index,  object sender, PaintEventArgs e);
        void visit(WithBuff withBuff, int index, object sender, PaintEventArgs e);
        void visit(Undestructable keyboard, int index, object sender, PaintEventArgs e);
        void visit(MapParts mapDrawing, int index, object sender, PaintEventArgs e);
    }
}

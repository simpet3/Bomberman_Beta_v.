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
        void visit(Path computer, object sender, PaintEventArgs e);
        void visit(Destructable mouse, object sender, PaintEventArgs e);
        void visit(WithBuff withBuff, object sender, PaintEventArgs e);
        void visit(Undestructable keyboard, object sender, PaintEventArgs e);
        void visit(MapParts mapDrawing, object sender, PaintEventArgs e);
    }
}

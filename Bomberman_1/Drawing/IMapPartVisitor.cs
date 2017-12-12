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
        void visit(Path path, int index, object sender, PaintEventArgs e);
        void visit(Destructable destructable, int index,  object sender, PaintEventArgs e);
        void visit(WithBuff withBuff, int index, object sender, PaintEventArgs e);
        void visit(Undestructable undestructable, int index, object sender, PaintEventArgs e);
        void visit(MapParts mapParts, int index, object sender, PaintEventArgs e);
    }
}

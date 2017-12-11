using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman_1.Drawing
{
    public class Undestructable : IMapPart
    {
        public void accept(IMapPartVisitor mapPartVisitor, object sender, PaintEventArgs e)
        {
            mapPartVisitor.visit(this, sender, e);
        }
    }
}

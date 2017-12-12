using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman_1.Drawing
{
    public class Path : IMapPart
    {
        public void accept(IMapPartVisitor mapPartVisitor, int index, object sender, PaintEventArgs e)
        {
            mapPartVisitor.visit(this, index, sender, e);
        }
    }
}

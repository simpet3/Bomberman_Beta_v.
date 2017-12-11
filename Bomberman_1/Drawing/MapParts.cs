using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman_1.Drawing
{
    public class MapParts : IMapPart
    {
        IMapPart[] parts;

        public MapParts()
        {
            parts = new IMapPart[] { new Path(), new Destructable(), new Undestructable(), new WithBuff() };
        }

        public void accept(IMapPartVisitor mapPartVisitor, object sender, PaintEventArgs e)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i].accept(mapPartVisitor, sender, e);
            }
            mapPartVisitor.visit(this, sender, e);
        }
    }
}

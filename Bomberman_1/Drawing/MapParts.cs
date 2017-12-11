using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman_1.Drawing
{
    public class MapParts : IMapPart
    {
        IMapPart[] parts;

        public MapParts()
        {
            parts = new IMapPart[] { new Path(), new Destructable(), new Undestructable() };
        }

        public void accept(IMapPartVisitor mapPartVisitor)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i].accept(mapPartVisitor);
            }
            mapPartVisitor.visit(this);
        }
    }
}

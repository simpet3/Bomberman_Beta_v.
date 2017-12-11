using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman_1.Drawing
{
    public interface IMapPart
    {
        void accept(IMapPartVisitor mapPartVisitor);
    }
}

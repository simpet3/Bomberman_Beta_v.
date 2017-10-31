using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman_1.services.mouse_Data
{
    class MouseData
    {
        public int x { get; set; }
        public int y { get; set; }
        public MouseData(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}

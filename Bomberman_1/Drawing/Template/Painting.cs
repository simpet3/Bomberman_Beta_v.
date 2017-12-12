using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman_1.Drawing.Template
{
    public abstract class Painting
    {
        public abstract void drawMap(object sender, PaintEventArgs e);
        public abstract void drawPlayer(object sender, PaintEventArgs e, int _x, int _y);

        //template method
        public void draw(object sender, PaintEventArgs e, int _x, int _y)
        {
            drawMap(sender, e);
            drawPlayer(sender, e, _x, _y);
        }
    }
}

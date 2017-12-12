using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman_1.Drawing.Template
{
    class PaintingTemplate2 : Painting
    {
        static int template2 = 2;

        public override void drawMap(object sender, PaintEventArgs e)
        {
            IMapPart mapPart = new MapParts();
            mapPart.accept(new MapPartDisplayVisitor(), template2, sender, e);
        }

        public override void drawPlayer(object sender, PaintEventArgs e, int _x, int _y)
        {
            e.Graphics.FillRectangle(Brushes.BlueViolet, _x, _y, 45, 45);
        }
    }
}

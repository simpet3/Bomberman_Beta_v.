using Bomberman_1.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BomberManProject.map;
using BomberManProject.tile.build;
using Bomberman_1.services;

namespace Bomberman_1
{
    public partial class FormView : Form
    {
        enum Position
        {
            Left, Right, Up, Down
        }

        private int _x;
        private int _y;
        private Position _objPosition;


        public FormView()
        {
            InitializeComponent();
            _x = 0;
            _y = 0;
            _objPosition = Position.Down;
        }
        
        private void FormView_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.BlueViolet, _x, _y, 45, 45);

            IMapPart mapPart = new MapParts();
            mapPart.accept(new MapPartDisplayVisitor(), sender, e);
        }

        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            if (_objPosition == Position.Right)
            {
                _x += 10;
            }
            else if (_objPosition == Position.Left)
            {
                _x -= 10;
            }
            else if (_objPosition == Position.Up)
            {
                _y -= 10;
            }
            else if (_objPosition == Position.Down)
            {
                _y += 10;
            }

            Invalidate();
        }

        private void FormView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                _objPosition = Position.Left;
            }
            else if (e.KeyCode == Keys.D)
            {
                _objPosition = Position.Right;
            }
            else if (e.KeyCode == Keys.W)
            {
                _objPosition = Position.Up;
            }
            else if (e.KeyCode == Keys.S)
            {
                _objPosition = Position.Down;
            }
        }

        
    }
}

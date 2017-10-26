using BomberManProject.bomb;
using BomberManProject.coordinates;
using BomberManProject.map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberManProject.player
{
    abstract class Player
    {
        public Boolean isDead { get; private set; }

        public Bombb bomb { get; private set; }

        public Coordinates coordinates { get; private set; }

        public Map map;


        public Player(Bombb bomb, Coordinates coordinates, Map map)
        {
            this.isDead = false;
            this.bomb = bomb;
            this.coordinates = coordinates;
            this.map = map;
        }

        public void plantBomb()
        {
            /// put bomb
        }

        public void moveUp()
        {

        }

        public void moveDown()
        {

        }

        public void moveLeft()
        {

        }

        public void moveRight()
        {

        }

    }
}

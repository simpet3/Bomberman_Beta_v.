using BomberManProject.improvement;
using BomberManProject.player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman_1.player
{
    public class ProxyPlayer : Player
    {
        private HumanPlayer hp;

        public ProxyPlayer()
        {

        }

        public void plantBomb()
        {
            if (hp == null)
            {
                hp = new HumanPlayer();
            }
            hp.plantBomb();
        }

        public void moveUp()
        {
            if (hp == null)
            {
                hp = new HumanPlayer();
            }
            hp.moveUp();
        }

        public void moveDown()
        {
            if (hp == null)
            {
                hp = new HumanPlayer();
            }
            hp.moveDown();
        }

        public void moveLeft()
        {
            if (hp == null)
            {
                hp = new HumanPlayer();
            }
            hp.moveLeft();
        }

        public void moveRight()
        {
            if (hp == null)
            {
                hp = new HumanPlayer();
            }
            hp.moveRight();
        }

        public Improvement getImprov()
        {
            if (hp == null)
            {
                hp = new HumanPlayer();
            }
            return hp.getImprov();
        }
    }
}

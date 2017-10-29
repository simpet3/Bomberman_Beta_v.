using BomberManProject.bomb;
using BomberManProject.coordinates;
using BomberManProject.map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.tile.decorator;
using Bomberman_1.services;
using BomberManProject.improvement;

//Player implements this class
namespace BomberManProject.player
{
    abstract class Player : Improvement
    {
        public Boolean isDead { get; private set; }

        public Bombb bomb { get; private set; }

        public Coordinates coordinates { get; private set; }

        public Map map;

        public Improvement improvement { set; get; }

        public Player(Bombb bomb, Coordinates coordinates, Map map)
        {
            this.isDead = false;
            this.bomb = bomb;
            this.coordinates = coordinates;
            this.map = map;
        }
        // Default settings
        public Player()
        {
            this.isDead = false;
            this.bomb = new Bombb();
            this.coordinates = new Coordinates(0,0);
            this.map = new mapServices().generateMap();
        }
        public Player(Player player)
        {
            this.isDead = player.isDead;
            this.bomb = player.bomb;
            this.coordinates = player.coordinates;
            this.map = player.map;
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

        public override int getImprovement()
        {
            if (improvement != null)
                return improvement.getImprovement();
            else // if improvement does not exist
                return -1;
        }
    }
}

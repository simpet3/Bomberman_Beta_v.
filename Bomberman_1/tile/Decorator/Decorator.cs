using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.bomb;
using BomberManProject.coordinates;
using BomberManProject.map;
using BomberManProject.player;
using BomberManProject.improvement;

namespace BomberManProject.tile.decorator
{
    abstract class Decorator : Player
    {
        protected Player _player = null;

        public Decorator(Player player)
        {
            this._player = player;     
        }

        public override int getImprovement()
        {
            return _player.getImprovement();
        }

        public virtual Bomb bomb
        {
            get { return _player.bomb; }
            set { _player.bomb = value; }
        }
        public virtual Coordinates coordinates
        {
            get { return _player.coordinates; }
            set { _player.coordinates = value; }
        }
        public virtual Boolean isDead
        {
            get { return _player.isDead; }
            set { _player.isDead = value; }
        }
        public virtual Map map
        {
            get { return _player.map; }
            set { _player.map = value; }
        }
        public virtual Improvement improvement
        {
            get { return _player.improvement; }
            set { _player.improvement = value; }
        }
    }
}

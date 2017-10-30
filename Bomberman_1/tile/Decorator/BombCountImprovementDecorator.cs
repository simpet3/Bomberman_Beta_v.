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
    class BombCountImprovementDecorator : Decorator
    {
        public BombCountImprovementDecorator(Player player) : base(player)
        {
            if (player.GetType().ToString() == "BomberManProject.tile.decorator.BombCountImprovementDecorator")
            {
                int count = this._player.getImprovement() + 1;
                this._player.improvement = new CountImprovement(count);
            }
            else
            this._player.improvement = new CountImprovement();
        }

        public override int getImprovement()
        {
            return _player.improvement.getImprovement();
        }

        public override Bombb bomb
        {
            get { return base.bomb; }
            set { base.bomb = value; }
        }
        public override Coordinates coordinates
        {
            get { return base.coordinates; }
            set { base.coordinates = value; }
        }
        public override Boolean isDead
        {
            get { return base.isDead; }
            set { base.isDead = value; }
        }
        public override Map map
        {
            get { return base.map; }
            set { base.map = value; }
        }
        public override Improvement improvement
        {
            get { return base.improvement; }
            set { base.improvement = value; }
        }
    }
}
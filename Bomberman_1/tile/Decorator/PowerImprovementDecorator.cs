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
    class PowerImprovementDecorator : Decorator
    {
        public PowerImprovementDecorator(Player player) : base(player)
        {
            if (player.GetType().ToString().Equals("BomberManProject.tile.decorator.PowerImprovementDecorator"))
            {
                int power = player.getImprovement() + 1;
                //Console.WriteLine("power " + power);
                this._player.improvement = new PowerImprovement(power);
                //Console.WriteLine(this._player.improvement.getImprovement());
            }
            else
            {
                this._player.improvement = new PowerImprovement();
            }
        }

        public override int getImprovement()
        {
            return _player.improvement.getImprovement();
        }

        public override Bomb bomb
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

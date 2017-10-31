using System;
using BomberManProject.bomb;
using BomberManProject.coordinates;
using BomberManProject.map;
using BomberManProject.improvement;

namespace BomberManProject.player
{
    class HumanPlayer : Player
    {
        //private Player _player;
        //public HumanPlayer(Player player) : base(player)
        //{
        //    _player = player;
        //}

        public HumanPlayer(Bomb bomb, Coordinates coordinates, Map map) : base(bomb, coordinates, map)
        {

        }
        public HumanPlayer() : base()
        {

        }
    }
}

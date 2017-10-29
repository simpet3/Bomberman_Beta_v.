using System;
using BomberManProject.bomb;
using BomberManProject.coordinates;
using BomberManProject.map;


namespace BomberManProject.player
{
    class HumanPlayer : Player
    {
        public HumanPlayer(Player player) : base(player)
        {

        }

        public HumanPlayer(Bombb bomb, Coordinates coordinates, Map map) : base(bomb, coordinates, map)
        {

        }

    }
}

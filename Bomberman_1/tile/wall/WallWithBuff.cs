using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.improvement;
using BomberManProject.coordinates;

namespace BomberManProject.tile.wall
{
    class WallWithBuff : IInteractiveTile
    {
        IImprovement improvement;
        SimpleWall simpleWall;
        static int powerBuffNum = 1;
        static int bombNumBuff = 2;

        public WallWithBuff(TileCoordinates coordinates, int buffNumber)
        {
            //KOORDINATEJE KURIA SIENA
            simpleWall = new SimpleWall(coordinates);

            //KOORDINATEJE DEDA BUFFA
            if (buffNumber == powerBuffNum)
            {
                this.improvement = new PowerImprovement();
            }
            else if(buffNumber == bombNumBuff)
            {
                this.improvement = new CountImprovement();
            }
            this.improvement.getImprovement();
        }

        public TileCoordinates getCoordinates()
        {
            throw new NotImplementedException();
        }

        IImprovement IInteractiveTile.getImprovement()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.improvement;
using BomberManProject.coordinates;
using Bomberman_1.ObserverHelpers;

namespace BomberManProject.tile.wall
{
    class WallWithBuff : Observer,IInteractiveTile
    {
        Improvement improvement;
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
            return simpleWall.coordinates;
        }

        Improvement IInteractiveTile.getImprovement()
        {
            throw new NotImplementedException();
        }

        public override void updateAfterExplosion()
        {
            // pavercia this objeta i Path . kopina objekto savybes . 
            Console.WriteLine(" Wall with buff - Tile responded to exploded bomb");
        }
    }
}

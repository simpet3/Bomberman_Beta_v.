using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.tile.decorator;
using BomberManProject.player;
using BomberManProject.bomb;
using BomberManProject.coordinates;
using BomberManProject.map;
using BomberManProject.improvement;
using Bomberman_1.services;

namespace BomberManProject.tile.decorator
{
    class ConsoleDecoratorTest
    {
        public void test()
        {
            List<IImprovement> imp = new List<IImprovement>();
            imp.Add(new PowerImprovement());
            Player player = new HumanPlayer(new Bombb(10,1,1, imp), new Coordinates(0, 0), new mapServices().generateMap());
            Console.WriteLine();
            BlueDecorator bd = new BlueDecorator(player);

            Console.WriteLine(bd.getColor());
            DarkColorDecorator dcd = new DarkColorDecorator(bd);

            VisualComponent v = (DarkColorDecorator)dcd;
            DarkColorDecorator aa = (DarkColorDecorator)v;
            aa.GetType().GetMember("moveUp").Initialize();
            //Console.Write(aa);
            Console.WriteLine(dcd.getColor());

        }
    }

}

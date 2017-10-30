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
            //DECORATOR VEIKIMAS
            // jei paima 2 vienodus patobulinimus, ju efektas stiprinamas, 
            // bet jeigu paima kita, pirmasis bufas dingsta ir paemus pirmaji bufa is naujo, jo efekto
            // sudetis pradedama skaiciuoti nuo pradzios
            // (jeigu nenori prarasti bufo, neimi kito) # strategy

            // kiekviena karta kai paima improvementa, wrapinamas player
            // pvz. PowerImprovementDecorator improvedplayer = PowerImprovementDecorator(player);
            // ir visi tolimesni veiksmai atliekami su improvedplayer
            // o norint gauti jo galias reikia gauti improvedPlayer.getType().toString() ir lyginti su abiem
            // power-upais, o grazinamas skaicius yra to power-upo stiprumo lygis


            // MANO TESTAVIMAS
            // i ataskaita kanors graziau sumastysiu
            List<Improvement> imp = new List<Improvement>();
            imp.Add(new PowerImprovement());
            HumanPlayer p = new HumanPlayer(new Bombb(10, 1, 1, imp), new Coordinates(0, 0), new mapServices().generateMap());

            Console.WriteLine(p.getImprovement());

            PowerImprovementDecorator pid = new PowerImprovementDecorator(p);
            Console.WriteLine(pid.getImprovement());

            PowerImprovementDecorator pid2 = new PowerImprovementDecorator(pid);
            Console.WriteLine(pid2.getImprovement());

            BombCountImprovementDecorator bci = new BombCountImprovementDecorator(pid2);
            Console.WriteLine(bci.getImprovement());

            BombCountImprovementDecorator bci2 = new BombCountImprovementDecorator(bci);
            Console.WriteLine(bci2.getImprovement());

            Bombb b = bci2.bomb;
            Console.WriteLine(b.explosionPower);

        }
    }

}

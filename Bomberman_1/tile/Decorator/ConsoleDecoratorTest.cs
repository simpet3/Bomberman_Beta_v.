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
        // uses->PowerImprovementDecorator ir BombCountImprovementDecorator
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
            //Console.WriteLine();
            Console.WriteLine("Player has no power-up");
            List<Improvement> imp = new List<Improvement>();
            imp.Add(new PowerImprovement());
            HumanPlayer p = new HumanPlayer(new Bomb(10, 1, 1, imp), new Coordinates(0, 0), new mapServices().generateMap());

            Console.WriteLine(p.getImprovement());

            PowerImprovementDecorator pid = new PowerImprovementDecorator(p);
            Console.WriteLine("Player has level "+ pid.getImprovement()+ " power improvement");

            PowerImprovementDecorator pid2 = new PowerImprovementDecorator(pid);
            Console.WriteLine("Player has level " + pid2.getImprovement() + " power improvement");

            Console.WriteLine("Player picked up different power-up and lost previous one");
            BombCountImprovementDecorator bci = new BombCountImprovementDecorator(pid2);
            Console.WriteLine("Player has level " + bci.getImprovement() + " bomb count improvement");

            BombCountImprovementDecorator bci2 = new BombCountImprovementDecorator(bci);
            Console.WriteLine("Player has level " + bci2.getImprovement() + " bomb count improvement");

            //<<<<<<< HEAD
            //Bombb b = bci2.bomb;
            //Console.WriteLine(b.explosionPower);
            //=======
            //Bomb b = bci2.bomb;
            //Console.WriteLine(b.explosionPower);
//>>>>>>> b99dbf3e3ef462631d7e8b30f68faaf65d3585b8

        }
    }

}

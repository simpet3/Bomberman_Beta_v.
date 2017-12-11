using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bomberman_1.services;
using BomberManProject.map;
using BomberManProject.tile.build;
using BomberManProject.tile.decorator;
using BomberManProject.player;
using BomberManProject.eventHandling;
using BomberManProject.eventHandling.actionKeys;
using BomberManProject.commands;
using BomberManProject.Singleton;
using BomberManProject.tile;
using BomberManProject.coordinates;
using BomberManProject.tile.wall;
using BomberManProject.bomb;
using System.Windows.Forms;
using Bomberman_1.Drawing;
using Bomberman_1.mouse_Event_Handler;

namespace Bomberman_1
{
    class Program
    {
        static int yTileMax = 18;
        static int xTileMax = 18;

        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormView());

            //Map generation test
            //Map map = new mapServices().generateMap();
            //PrintMapToConsole a = new PrintMapToConsole();
            ////mapp - map representation in number code
            //int [,] mapp  = a.PrintMap(map.tiles);

            //ConsoleDecoratorTest decorator = new ConsoleDecoratorTest();
            //decorator.test();
            //


            //    Boolean loopActive = true;
            //    ConsoleKeyInfo keyInfo;
            //    HumanPlayer humanPlayer = new HumanPlayer();
            //    Console.WriteLine("\n\n Command and bridge pattern test \n");
            //    while (loopActive)
            //    {
            //        keyInfo = Console.ReadKey();
            //        deleteLetter();
            //        switch (keyInfo.KeyChar)
            //        {
            //            case 'w':
            //                Keyboard keyboardUp = new Keyboard(new ActionKeyUp());
            //                ICommand commandUp = keyboardUp.handleEvent(humanPlayer);
            //                ServicesSingleton.getInstance().commandService.addCommand(commandUp);
            //                break;
            //            case 'a':
            //                Keyboard keyboardLeft = new Keyboard(new ActionKeyLeft());
            //                ICommand commandLeft = keyboardLeft.handleEvent(humanPlayer);
            //                ServicesSingleton.getInstance().commandService.addCommand(commandLeft);
            //                break;
            //            case 'd':
            //                Keyboard keyboardRight = new Keyboard(new ActionKeyRight());
            //                ICommand commandRight = keyboardRight.handleEvent(humanPlayer);
            //                ServicesSingleton.getInstance().commandService.addCommand(commandRight);
            //                break;
            //            case 's':
            //                Keyboard keyboardDown = new Keyboard(new ActionKeyDown());
            //                ICommand commandDown = keyboardDown.handleEvent(humanPlayer);
            //                ServicesSingleton.getInstance().commandService.addCommand(commandDown);
            //                break;
            //            case '1':
            //                Keyboard keyboardSpace = new Keyboard(new ActionKeySpace());
            //                ICommand commandSpace = keyboardSpace.handleEvent(humanPlayer);
            //                ServicesSingleton.getInstance().commandService.addCommand(commandSpace);
            //                break;
            //            case 't':
            //                loopActive = false;
            //                break;
            //        }
            //    }
            //    TestObserver();

            //    Console.ReadKey();
            //}
            //private static void deleteLetter()
            //{
            //    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            //    Console.WriteLine(" ");
            //}

            //private static void TestObserver()
            //{
            //    Console.WriteLine("\n\nObserver pattern test \n");
            //    //observers
            //    var pathTIle = new PathTile(new TileCoordinates(0,0));
            //    var simpleTile = new SimpleWall(new TileCoordinates(0, 0)); 
            //    var wallWithBuff = new WallWithBuff(new TileCoordinates(0, 0),1);

            //    //target
            //    var bomb = new Bomb();

            //    bomb.atach(pathTIle);
            //    bomb.atach(simpleTile);
            //    bomb.atach(wallWithBuff);

            //    bomb.explode();
        }

    }


}

using Bomberman_1.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BomberManProject.map;
using BomberManProject.tile.build;
using Bomberman_1.services;
using BomberManProject.player;
using Bomberman_1.Game;
using Bomberman_1.GameState;
using Bomberman_1.GameState.States;
using Bomberman_1.mouse_Event_Handler;
using BomberManProject.commands;
using BomberManProject.coordinates;
using BomberManProject.eventHandling;
using BomberManProject.eventHandling.actionKeys;
using BomberManProject.services;
using BomberManProject.Singleton;

namespace Bomberman_1
{
    public partial class FormView : Form
    {
        enum Position
        {
            Left, Right, Up, Down
        }

        private Boolean draw = true;
        private int _x;
        private int _y;
        private Position _objPosition;
        private Game.Game game;
        private CommandsService commandService;
        private StateFactory stateFactory;
        private StateHistory.StateHistory stateHistory;
        private MouseEventHandlerAdapter mouseEventHandler;


        public FormView()
        {
            this.mouseEventHandler = new MouseEventHandlerAdapter();
            this.stateHistory = new StateHistory.StateHistory();
            this.stateFactory = new StateFactory();
            this.commandService = ServicesSingleton.getInstance().commandService;
            this.game = new Game.Game(new HumanPlayer());
            this.game.setState(StateFactory.getState("PlayingState"));
            InitializeComponent();
            _x = 0;
            _y = 0;
            _objPosition = Position.Down;
        }
        
        private void FormView_Paint(object sender, PaintEventArgs e)
        {

                Coordinates playerCoord = game.getPlayer().coordinates;
                e.Graphics.FillRectangle(Brushes.BlueViolet, playerCoord.xCoordinate, playerCoord.YCoordinate, 45, 45);

                IMapPart mapPart = new MapParts();
                mapPart.accept(new MapPartDisplayVisitor(), sender, e);
               // Invalidate();
               // draw = false;
            
            //Refresh();

        }

        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            //if (_objPosition == Position.Right)
            //{
            //    _x += 10;
            //}
            //else if (_objPosition == Position.Left)
            //{
            //    _x -= 10;
            //}
            //else if (_objPosition == Position.Up)
            //{
            //    _y -= 10;
            //}
            //else if (_objPosition == Position.Down)
            //{
            //    _y += 10;
            //}

            Invalidate();
        }

        private void FormView_KeyDown(object sender, KeyEventArgs e)
        {
            State gameState = game.getState() as PlayingState;
            if (e.KeyCode == Keys.P)
            {
                stateHistory.add(this.game.saveStateToMemento());
                if (gameState != null)
                {
                    game.setState(StateFactory.getState("PausedState"));
                }else
                {
                    game.setState(StateFactory.getState("PlayingState"));
                }
            }

            if (gameState != null)
            {             
                Keyboard keyboard = null;
                if (e.KeyCode == Keys.A)
                {
                    keyboard = new Keyboard(new ActionKeyLeft());
                }
                else if (e.KeyCode == Keys.D)
                {
                    keyboard = new Keyboard(new ActionKeyRight());
                }
                else if (e.KeyCode == Keys.W)
                {
                    keyboard = new Keyboard(new ActionKeyUp());
                }
                else if (e.KeyCode == Keys.S)
                {
                    keyboard = new Keyboard(new ActionKeyDown());
                }

                if (keyboard != null)
                {
                    ICommand command = keyboard.handleEvent(game.getPlayer());
                    commandService.addCommand(command);
                   // draw = true;
                }
             }   

        /*
                     if (e.KeyCode == Keys.A)
        {
            _objPosition = Position.Left;
        }
        else if (e.KeyCode == Keys.D)
        {
            _objPosition = Position.Right;
        }
        else if (e.KeyCode == Keys.W)
        {
            _objPosition = Position.Up;
        }
        else if (e.KeyCode == Keys.S)
        {
            _objPosition = Position.Down;
        }
         */
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
          //  commandService.addCommand(mouseEventHandler.handleMouseEvent(game.getPlayer(), e)); 
          ////xujovai veikia bet veikia
        }

    }
}

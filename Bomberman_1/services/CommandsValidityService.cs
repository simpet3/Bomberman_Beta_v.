using BomberManProject.commands;
using BomberManProject.map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman_1.services
{
    class CommandsValidityService
    {
        Map map { get; set; }

        public CommandsValidityService(Map map)
        {
            this.map = map;
        }


        // dabaigt implementint visus metodus 
        public Boolean validateMoveCommand(ICommand command)
        {
            return false;
        }

        private Boolean validateMoveRightCommand(ICommand command)
        {
            return false;
        }
        private Boolean validateMoveUpCommand(ICommand command)
        {
            return false;
        }
        private Boolean validateMoveDownCommand(ICommand command)
        {
            return false;
        }
        private Boolean validateMoveLeftCommand(ICommand command)
        {
            return false;
        }
    }
}

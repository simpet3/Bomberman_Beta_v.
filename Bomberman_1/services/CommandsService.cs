//using BomberManProject.controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomberManProject.commands;

namespace BomberManProject.services
{
    class CommandsService
    {
        private List<ICommand> commandsList = new List<ICommand>();

        public void addCommand(ICommand command)
        {
            this.commandsList.Add(command);

            /// pradiniai versijai :
            executeCommands();
        }

        public void executeCommands()
        {
            Console.WriteLine(" command patterno servizas : vykdo komanda. ");
            foreach(ICommand command in commandsList)
            {
                command.execute();
            }
            commandsList.Clear();
        }
    }
}

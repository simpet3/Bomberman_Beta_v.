//using BomberManProject.controls;
using BomberManProject.commands;
using BomberManProject.player;
namespace BomberManProject.eventHandling
{
    abstract class Event
    {
        protected IAction action;

        protected Event(IAction action)
        {
            this.action = action;
        }

        public abstract ICommand handleEvent(Player player);
    }
}

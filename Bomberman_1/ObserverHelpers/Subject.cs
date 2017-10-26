using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman_1.ObserverHelpers
{
    abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();
        
        public void atach(Observer observer)
        {
            this.observers.Add(observer);
        }
    
        public void notifyAllObservers()
        {
            foreach(Observer observer in observers)
            {
                observer.updateAfterExplosion();
            }

        }
    }
}

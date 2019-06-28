using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Observer:IObserver
    {
        public string ObserverName;
        public Observer(string name)
        {
            ObserverName = name;
        }
        public void Update()
        {
            //Observer can update his system accordingly  
            Console.WriteLine("Hello " + ObserverName + ", a new article has been published by the author.");
        }
    }
}

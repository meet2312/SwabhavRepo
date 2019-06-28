using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Subject:ISubject
    {
        private List<Observer> Observers = new List<Observer>();
        private int articlesCount = 1;
        public int Articles
        {
            get
            {
                return articlesCount;
            }
            set
            {
                if (value > articlesCount)
                {
                    articlesCount++;
                    notifyObservers();
                }
            }
        }
        public void registerObserver(Observer observer)
        {
            Observers.Add(observer);
        }
        public void unregisterObserver(Observer observer)
        {
            Observers.Remove(observer);
        }
        public void notifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Update();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Bank : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Delete(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(var o in observers)
            {
                o.ShowStatus();
            }
        }
    }
}

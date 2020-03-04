using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface IObservable
    {
        public void Add(IObserver observer);
        public void Delete(IObserver observer);
        public void Notify();
    }
}

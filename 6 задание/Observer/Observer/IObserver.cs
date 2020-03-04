using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface IObserver
    {
        public string Name { get; set; }
        public float Money { get; set; }
        public void ShowStatus();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class BankAccount : IObserver
    {
        public string Name { get; set; }
        public float Money { get; set; }

        public BankAccount(string name, float money)
        {
            Name = name;
            Money = money;
        }

        public void ShowStatus()
        {
            Console.WriteLine("На счету {0} количество денег: {1}", Name, Money);
        }
    }
}

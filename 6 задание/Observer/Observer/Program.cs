using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var observer = new Bank();
            var account1 = new BankAccount("Сократ", 25);
            var account2 = new BankAccount("Платон", 0);
            var account3 = new BankAccount("Диоген", 100);
            observer.Add(account1);
            observer.Add(account2);
            observer.Add(account3);
            observer.Notify();
        }
    }
}

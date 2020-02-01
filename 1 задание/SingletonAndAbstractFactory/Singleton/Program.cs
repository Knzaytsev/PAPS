using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse warehouse = Warehouse.GetInstance();
            Console.WriteLine(warehouse.AddFood(new Food() { Name = "Apple", Price = 228 }));
            foreach(var f in warehouse.GetFoods())
            {
                Console.WriteLine("Food: " + f.Name + " Price: " + f.Price);
            }
        }
    }
}

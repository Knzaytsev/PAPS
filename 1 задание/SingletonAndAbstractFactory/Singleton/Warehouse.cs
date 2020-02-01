using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Warehouse
    {
        private static Warehouse instance;
        private List<Food> foods = new List<Food>();

        private Warehouse() { }

        public static Warehouse GetInstance()
        {
            if (instance == null)
                instance = new Warehouse();
            return instance;
        }

        public string AddFood(Food food)
        {
            foods.Add(food);
            return "Successfully added!\n";
        }

        public List<Food> GetFoods()
        {
            return foods;
        }
    }
}

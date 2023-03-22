using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSSS
{
    public abstract class Menu
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        public abstract void PrepareSpice();

        public void Prepare()
        {
            Console.WriteLine("Tossing dough..." + name);
            Console.WriteLine("Bread is baking..." + name);
            Console.WriteLine("Sauce is adding...");
            Console.WriteLine("Toppings are adding...");
            foreach(var topping in  toppings) 
            {
                Console.WriteLine("\t" + topping);
            }
        }

        public void AddEgg()
        {
            Console.WriteLine("Egg is adding..." + name);
        }

        public void box()
        {
            Console.WriteLine("Bread is boxing..." + name);
        }
    }
}

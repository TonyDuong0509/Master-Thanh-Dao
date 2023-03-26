using Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public abstract class Menu
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<Toppings> toppings = new List<Toppings>();

        public abstract void PrepareSpice();

        public void Prepare()
        {
            Console.WriteLine("Tossing dough..." + name);
            Console.WriteLine("Bread is baking..." + name);
            Console.WriteLine("Sauce is adding...");
            Console.WriteLine("Toppings:...");
            foreach(Toppings t in toppings) 
            {
                Console.WriteLine("\t" + t.name);
            }
        }

        public void AddEgg()
        {
            Console.WriteLine("Egg is adding..." + name);
        }

        public void Box()
        {
            Console.WriteLine("Bread is boxing..." + name);
        }

        public abstract void Add(string names);
        public abstract void Remove(string names);
    }
}


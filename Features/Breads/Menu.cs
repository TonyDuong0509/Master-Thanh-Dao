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
        protected List<string> toppings = new List<string>();

        public abstract void PrepareSpice();
        public abstract void AddTopping1();
        public abstract void AddTopping2();

        public void Prepare()
        {
            Console.WriteLine("Tossing dough..." + name);
            Console.WriteLine("Bread is baking..." + name);
            Console.WriteLine("Sauce is adding...");
           
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


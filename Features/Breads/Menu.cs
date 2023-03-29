using Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Features.Breads
{
    public abstract class Menu<T> where T : RecipeBase
    {
        protected string name;
        protected string dough;
        protected string sauce;

        public abstract void PrepareSpice();
        private T _recipe;

        
        public Menu(T recipe)
        {
            _recipe = recipe;
        }

        public void Prepare()
        {
            Console.WriteLine("Tossing dough..." + name);
            Console.WriteLine("Bread is baking..." + name);
            Console.WriteLine("Sauce is adding...");
            Console.WriteLine("Toppings:...");
        }


        public void Box()
        {
            Console.WriteLine("Bread is boxing..." + name);
        }

        public void Order(T recipe)
        {
            _recipe = recipe;
        }
    }
}


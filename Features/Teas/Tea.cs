using Store.Features.Breads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Store.Features.Teas
{
    public abstract class Tea<T> where T : RecipeDrink
    {
        protected string name;
        protected string size;
        protected float price;
        protected string drinkHot;
        protected string drinkCold;
        private T _recipe;

        public Tea(T recipe)
        {
            _recipe = recipe;
        }

        public void GetCup() { Console.WriteLine("Getting cup..." + name); }
        public void ChooseSize() { Console.WriteLine("Choosing size..." + size); }
        public float Pay(float price) { return price; }
        public abstract void Prepare();

        public void Order(T recipe)
        {
            _recipe = recipe;
        }
    }
}

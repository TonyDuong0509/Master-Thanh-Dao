using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class VegetableBread : Menu, IOrder
    {
        public override void PrepareSpice()
        {
            Console.WriteLine("Vegetable is washed..");
        }

        public VegetableBread()
        {
            name = "Vegetable Bread";
            dough = "Thin";
            sauce = "Sour";
        }

        public void Order()
        {
            Console.WriteLine("Order VegetableBread..." + name);
            this.PrepareSpice();
            this.Prepare();
            this.AddEgg();
            this.Box();
        }

        public override void Add(string names)
        {
            if (!toppings.Contains(new Toppings(names))) toppings.Add(new Toppings(names));

        }

        public override void Remove(string names)
        {
            if (toppings.Contains(new Toppings(name))) toppings.Remove(new Toppings(name));
            else { }
        }
    }
}

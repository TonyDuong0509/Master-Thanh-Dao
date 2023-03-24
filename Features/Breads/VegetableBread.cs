using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class VegetableBread : Menu, IOrder, IOrderTopping1, IOrderTopping2
    {
        public override void PrepareSpice()
        {
            Console.WriteLine("Vegetable is washed..");
        }

        public override void AddTopping1()
        {
            Console.WriteLine("Toppings:");
            toppings.Add("Cucumber");
            foreach (var topping in toppings)
            {
                Console.WriteLine("\t" + topping);
            }
        }

        public override void AddTopping2()
        {
            Console.WriteLine("Toppings:");
            toppings.Add("Orion");
            foreach (var topping in toppings)
            {
                Console.WriteLine("\t" + topping);
            }
        }

        public VegetableBread()
        {
            name = "Vegetable Bread";
            dough = "Very thick";
            sauce = "Sour";
        }

        public void Order()
        {
            VegetableBread vegetableBread = new VegetableBread();
            Console.WriteLine("Order VegetableBread..." + name);
            vegetableBread.PrepareSpice();
            vegetableBread.Prepare();
            vegetableBread.AddEgg();
            vegetableBread.box();
        }
        public void OrderTopping1()
        {
            VegetableBread vegetableBreadTopping1 = new VegetableBread();
            vegetableBreadTopping1.AddTopping1();
        }

        public void OrderTopping2()
        {
            VegetableBread vegetableBreadTopping2 = new VegetableBread();
            vegetableBreadTopping2.AddTopping2();
        }
    }
}

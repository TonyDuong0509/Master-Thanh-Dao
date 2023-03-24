using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class MeatBread : Menu, IOrder, IOrderTopping1, IOrderTopping2
    {
        public override void PrepareSpice()
        {
            Console.WriteLine("Meat is cutting..");
        }

        public override void AddTopping1()
        {
            Console.WriteLine("Toppings:");
            toppings.Add("Meats");
            foreach (var topping in toppings)
            {
                Console.WriteLine("\t" + topping);
            }
        }

        public override void AddTopping2()
        {
            Console.WriteLine("Toppings:");
            toppings.Add("Two Eggs");
            foreach (var topping in toppings)
            {
                Console.WriteLine("\t" + topping);
            }
        }

        public MeatBread()
        {
            name = "Meat Bread";
            dough = "Thick";
            sauce = "Salty";
        }
        public void Order()
        {
            MeatBread meatBread = new MeatBread();
            Console.WriteLine("Order MeatBread..." +name);
            meatBread.PrepareSpice();
            meatBread.Prepare();
            meatBread.AddEgg();
            meatBread.box();
        }
        public void OrderTopping1()
        {
            MeatBread meatBreadTopping1 = new MeatBread();
            meatBreadTopping1.AddTopping1();
        }
        public void OrderTopping2()
        {
            MeatBread meatBreadTopping2 = new MeatBread();
            meatBreadTopping2.AddTopping2();
        }
    }
}

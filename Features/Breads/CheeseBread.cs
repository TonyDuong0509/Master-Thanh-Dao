using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class CheeseBread : Menu, IOrder, IOrderTopping1, IOrderTopping2
    {
        public override void PrepareSpice()
        {
            Console.WriteLine("Cheese is prepared...");
        }

        public override void AddTopping1()
        {
            Console.WriteLine("Toppings:");
            toppings.Add("Tomato");
            foreach (var topping in toppings)
            {
                Console.WriteLine("\t" + topping);
            }
        }

        public override void AddTopping2()
        {
            Console.WriteLine("Toppings:");
            toppings.Add("Chiili");
            foreach (var topping in toppings)
            {
                Console.WriteLine("\t" + topping);
            }
        }

        public CheeseBread()
        {
            name = "Cheese Bread";
            dough = "Very thin";
            sauce = "Sweet";
        }
        public void Order()
        {
            CheeseBread cheeseBread = new CheeseBread();
            Console.WriteLine("Order CheeseBread..." + name);
            cheeseBread.PrepareSpice();
            cheeseBread.Prepare();
            cheeseBread.AddEgg();
            cheeseBread.box();
        }

        public void OrderTopping1()
        {
            CheeseBread cheeseBreadTopping1 = new CheeseBread();
            cheeseBreadTopping1.AddTopping1();
        }
        public void OrderTopping2()
        {
            CheeseBread cheeseBreadTopping2 = new CheeseBread();
            cheeseBreadTopping2.AddTopping2();
        }
    }

}

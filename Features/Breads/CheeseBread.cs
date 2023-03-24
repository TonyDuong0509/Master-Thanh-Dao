using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class CheeseBread : Menu, IOrder
    {
        public override void PrepareSpice()
        {
            Console.WriteLine("Cheese is prepared...");
        }

        public CheeseBread()
        {
            int input = 0;
            name = "Cheese Bread";
            dough = "Very thin";
            sauce = "Sweet";
            Console.WriteLine("Do you want to add Tomato? - Input <1> YES or <2> No");
            input = int.Parse(Console.ReadLine());
            if (input == 1)
                toppings.Add("Tomato");
            Console.WriteLine("Do you want to add Chiili? - Input <1> YES or <2> No");
            input = int.Parse(Console.ReadLine());
            if (input == 1)
                toppings.Add("Chiili");
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
    }

}

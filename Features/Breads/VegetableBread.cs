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
            int input = 0;
            name = "Vegetable Bread";
            dough = "Very thick";
            sauce = "Sour";
            Console.WriteLine("Do you want to add Cucumber? - Input <1> YES or <2> No");
            input = int.Parse(Console.ReadLine());
            if (input == 1)
                toppings.Add("Cucumber");
            Console.WriteLine("Do you want to add Orion? - Input <1> YES or <2> No");
            input = int.Parse(Console.ReadLine());
            if (input == 1)
                toppings.Add("Orion");
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
    }
}

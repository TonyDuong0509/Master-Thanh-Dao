using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSSS
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
            dough = "Very thick";
            sauce = "Sour";
            toppings.Add("Cucumber");
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

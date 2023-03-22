using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSSS
{
    public class MeatBread : Menu
    {
        public override void PrepareSpice()
        {
            Console.WriteLine("Meat is cutting..");
        }

        public MeatBread()
        {
            name = "Meat Bread";
            dough = "Thick";
            sauce = "Salty";
            toppings.Add("Meats");
            toppings.Add("two Eggs");
        }
    }
}

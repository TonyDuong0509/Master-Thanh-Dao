using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSSS
{
    public class CheeseBread : Menu
    {
        public override void PrepareSpice()
        {
            Console.WriteLine("Cheese is prepared...");
        }

        public CheeseBread()
        {
            name = "Cheese Bread";
            dough = "Very thin";
            sauce = "Sweet";
            toppings.Add("Tomato");
            toppings.Add("Chilli");
        }
    }

}

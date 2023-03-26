using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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
            name = "Cheese Bread";
            dough = "Very thin";
            sauce = "Sweet";
            toppings.Add("Tomato");
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

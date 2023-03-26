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
        }
        public void Order()
        {
            Console.WriteLine("Order CheeseBread..." + name);
            this.PrepareSpice();
            this.Prepare();
            this.AddEgg();
            this.Box();
        }

        public override void Add(string names)
        {
            if (!toppings.Contains(new Toppings(names))) toppings.Add(new Toppings(names));
            else { }
        }

        public override void Remove(string names)
        {
            if (toppings.Contains(new Toppings(name))) toppings.Remove(new Toppings(name));
            else { }
        }
    }
}

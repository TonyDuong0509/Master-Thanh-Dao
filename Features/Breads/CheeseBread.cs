using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Store.Features;

namespace Store.Features.Breads
{
    public class CheeseBread<CheeseBreadRecipe> : Menu<CheeseBreadRecipe>
    {
        public override void PrepareSpice()
        {
            Console.WriteLine("Cheese is prepared...");
        }

        public CheeseBread() : base(new CheeseBreadRecipe())
        {
            name = "Cheese Bread";
            dough = "Very thin";
            sauce = "Sweet";
        }
    }
}

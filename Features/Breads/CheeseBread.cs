using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Store.Features;

namespace Store.Features.Breads.Recipes
{
    public class CheeseBread : Menu<CheeseBreadRecipe>, IOrder
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

        public void Order()
        {
            CheeseBread cheeseBread = new CheeseBread();
            CheeseBreadRecipe cheeseBreadRecipe = new CheeseBreadRecipe();
            cheeseBreadRecipe.AddMyRecipe(new List<Topping>());
            cheeseBread.PrepareSpice();
            cheeseBread.Prepare();
            cheeseBread.Box();
        }
    }
}

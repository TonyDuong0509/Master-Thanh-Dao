using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Features.Breads.Recipes
{
    public class VegetableBread : Menu<VegetableBreadRecipe>, IOrder
    {
        public override void PrepareSpice()
        {
            Console.WriteLine("Vegetable is washed..");
        }

        public VegetableBread() : base(new VegetableBreadRecipe())
        {
            name = "Vegetable Bread";
            dough = "Thin";
            sauce = "Sour";
        }
        
        public void Order()
        {
            VegetableBread vegetableBread = new VegetableBread(); 
            vegetableBread.PrepareSpice();
            vegetableBread.Prepare();
            vegetableBread.Box();
        }
    }
}

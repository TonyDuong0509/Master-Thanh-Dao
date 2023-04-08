using Store.Features.Breads.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Features.Breads.Recipes
{
    public class MeatBread : Menu<MeatBreadRecipe>
    {
        public override void PrepareSpice()
        {
            Console.WriteLine("Meat is cutting..");
        }

        public MeatBread() : base(new MeatBreadRecipe())
        {
            name = "Meat Bread";
            dough = "Very thick";
            sauce = "Salty";
        }
    }
}

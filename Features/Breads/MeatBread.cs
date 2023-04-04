using Store.Features.Breads.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Features.Breads.Recipes
{
    public class MeatBread : Menu<MeatBreadRecipe>, IOrder
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

        public void Order()
        {
            MeatBread meatBread = new MeatBread();
            meatBread.PrepareSpice();
            meatBread.Order();
            meatBread.Box();
        }
    }
}

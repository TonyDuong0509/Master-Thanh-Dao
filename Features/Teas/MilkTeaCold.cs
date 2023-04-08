using Store.Features.Breads.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Features.Teas
{
    public class MilkTeaCold : Tea<RecipeMilkTeaCold>
    {
        public MilkTeaCold() : base(new RecipeMilkTeaCold())
        {
            name = "Oolong Tea";
            size = "Size XL";
            drinkHot = "Drink Cold";
        }
        public override void Prepare()
        {
            Console.WriteLine("Pour milk into tea...");
        }
    }
}

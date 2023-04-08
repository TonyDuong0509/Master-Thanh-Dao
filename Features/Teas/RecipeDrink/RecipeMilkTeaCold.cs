using Store.Features.Breads.Toppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Features.Teas
{
    public class RecipeMilkTeaCold : RecipeDrink
    {
        public RecipeMilkTeaCold() : base() 
        {
            toppingsDrink.Add(new Pearl());
            toppingsDrink.Add(new Peach());
            foreach(var item in toppingsDrink) 
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}

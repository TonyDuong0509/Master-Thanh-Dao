using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Features.Breads.Toppings;

namespace Store.Features.Teas
{
    public class RecipeMilkTeaHot : RecipeDrink
    {
        public RecipeMilkTeaHot() : base() 
        {
            toppingsDrink.Add(new ChocolateJelly());
            foreach(var item in toppingsDrink)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}

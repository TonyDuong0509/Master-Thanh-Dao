using Store.Features.Breads.Toppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Features.Breads.Recipes
{
    internal class MilkTeaColdRecipe : RecipeBase
    {
        public MilkTeaColdRecipe() : base() 
        {
            _toppings.Add(new Pearl());
            _toppings.Add(new Peach());
            foreach(var item in _toppings)
            {
                Console.WriteLine(item.Name);
            }    
        }
    }
}

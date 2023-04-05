using Store.Features.Breads.Toppings;
using System;
using System.Collections.Generic;

namespace Store.Features.Breads.Recipes
{
    public class CheeseBreadRecipe : RecipeBase
    {
        public CheeseBreadRecipe() : base()
        {
            
        }

        public override void AddMyRecipe(List<Topping> _toppings)
        {
            _toppings.Add(new Tomato());
            _toppings.Add(new Chiili());
            foreach(var item in _toppings)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
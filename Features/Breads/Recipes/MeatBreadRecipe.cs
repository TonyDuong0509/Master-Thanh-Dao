using Store.Features.Breads.Toppings;
using System;
using System.Collections.Generic;

namespace Store.Features.Breads.Recipes
{
    public class MeatBreadRecipe : RecipeBase
    {
        public MeatBreadRecipe() : base()
        {
        }

        public override void AddMyRecipe(List<Topping> _toppings)
        {
            _toppings.Add(new Egg());
            _toppings.Add(new Chiili());
            foreach(var item in _toppings)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
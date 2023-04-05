using Store.Features.Breads.Toppings;
using System;
using System.Collections.Generic;

namespace Store.Features.Breads.Recipes
{
    public class VegetableBreadRecipe : RecipeBase
    {
        public VegetableBreadRecipe() : base()
        {
        }

        public override void AddMyRecipe(List<Topping> _toppings)
        {
            _toppings.Add(new Cucumber());
            _toppings.Add(new Tomato());
            foreach(var item in _toppings)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
using Store.Features.Breads.Toppings;
using System;
using System.Collections.Generic;

namespace Store.Features.Breads.Recipes
{
    public class VegetableBreadRecipe : RecipeBase
    {
        public VegetableBreadRecipe() : base()
        {
            List<Topping> toppings = new List<Topping>();
            toppings.Add(new Cucumber());
            toppings.Add(new Tomato());
            Console.WriteLine("Toppings are adding...");
            foreach (Topping t in toppings)
            {
                Console.WriteLine(t.Name);
            }
        }
    }
}
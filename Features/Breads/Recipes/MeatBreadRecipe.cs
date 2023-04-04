using Store.Features.Breads.Toppings;
using System;
using System.Collections.Generic;

namespace Store.Features.Breads.Recipes
{
    public class MeatBreadRecipe : RecipeBase
    {
        public MeatBreadRecipe() : base()
        {
            List<Topping> toppings = new List<Topping>();
            toppings.Add(new Cucumber());
            toppings.Add(new Chiili());
            toppings.Add(new Egg());
            Console.WriteLine("Toppings are adding...");
            foreach (Topping t in toppings)
            {
                Console.WriteLine(t.Name);
            }
        }
    }
}
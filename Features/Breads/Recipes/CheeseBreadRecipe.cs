using Store.Features.Breads.Toppings;
using System;
using System.Collections.Generic;

namespace Store.Features.Breads.Recipes
{
    public class CheeseBreadRecipe : RecipeBase
    {
        public CheeseBreadRecipe() : base()
        {
            List<Topping> toppings = new List<Topping>();
            toppings.Add(new Tomato());
            toppings.Add(new Chiili());
            Console.WriteLine("Toppings are adding...");
            foreach (Topping t in toppings) 
            {
                Console.WriteLine(t.Name);
            }
        }
    }
}
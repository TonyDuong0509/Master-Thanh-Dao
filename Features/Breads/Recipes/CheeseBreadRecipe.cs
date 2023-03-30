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
            Cheese cheese = new Cheese();
            toppings.Add(cheese);
        }

        public override void AddTopping(Topping toppings)
        {
            base.AddTopping(toppings);
        }
    }
}
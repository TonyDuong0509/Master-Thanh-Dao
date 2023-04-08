using Store.Features.Breads.Toppings;
using System;
using System.Collections.Generic;

namespace Store.Features.Breads.Recipes
{
    public class MeatBreadRecipe : RecipeBase
    {
        public MeatBreadRecipe() : base()
        {
            _toppings.Add(new Egg());
            _toppings.Add(new Cucumber());
            _toppings.Add(new Chiili());
            foreach (var item in _toppings)
            {
                Console.WriteLine(item.Name);
            }
        }

        //public override void AddTopping(List<Topping> toppings)
        //{
        //    toppings.Add(new Egg());
        //    toppings.Add(new Tomato());
        //    toppings.Add(new Chiili());
        //    foreach(var topping in toppings)
        //    {
        //        Console.WriteLine(topping.Name);
        //    }
        //}
    }
}
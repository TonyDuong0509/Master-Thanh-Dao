using Store.Features.Breads.Toppings;
using System;
using System.Collections.Generic;

namespace Store.Features.Breads.Recipes
{
    public class VegetableBreadRecipe : RecipeBase
    {
        public VegetableBreadRecipe() : base() 
        {
            _toppings.Add(new Cucumber());
            _toppings.Add(new Tomato());
            foreach (var item in _toppings)
            {
                Console.WriteLine(item.Name);
            }
        }

        //public override void AddTopping(List<Topping> toppings)
        //{
        //    toppings.Add(new Cucumber());
        //    toppings.Add(new Tomato());
        //    foreach(var topping in toppings)
        //    {
        //        Console.WriteLine(topping.Name);
        //    }
        //}
    }
}
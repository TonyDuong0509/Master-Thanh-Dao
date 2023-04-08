using Store.Features.Breads.Toppings;
using System;
using System.Collections.Generic;

namespace Store.Features.Breads.Recipes
{
    public class CheeseBreadRecipe : RecipeBase
    {
        public CheeseBreadRecipe() : base()
        {
            _toppings.Add(new Tomato());
            _toppings.Add(new Chiili());
            foreach(var item in _toppings)
            {
                Console.WriteLine(item.Name);
            }
        }

        //public override void AddTopping(List<Topping> toppings)
        //{
        //    toppings.Add(new Tomato());
        //    toppings.Add(new Chiili());
        //    foreach (var t in toppings)
        //    {
        //        Console.WriteLine(t.Name);
        //    }
        //}
    }
}
using System.Linq;
using System.Collections.Generic;
using System;
using Store.Features.Breads.Recipes;
using Store.Features.Breads.Toppings;

namespace Store.Features.Breads
{
    public class RecipeBase
    {
        protected readonly List<Store.Topping> _toppings;

        public RecipeBase()
        {
            _toppings = new List<Store.Topping>();
        }
        public virtual void AddTopping(List<Topping> toppings)
        {
            toppings = new List<Store.Topping>();
        }

        public virtual void RemoveTopping(Store.Topping toppings)
        {
            if (!_toppings.Any(t => t.Name == toppings.Name))
                throw new System.Exception("Topping not exist");

            // TODO Remove toppings
        }
    }
}

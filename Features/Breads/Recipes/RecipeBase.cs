using System.Linq;
using System.Collections.Generic;
using System;
using Store.Features.Breads.Recipes;
using Store.Features.Breads.Toppings;

namespace Store.Features.Breads
{
    public abstract class RecipeBase
    {
        private readonly List<Store.Topping> _toppings;

        public IReadonlyCollection<Store.Topping> Topping
        {
            get
            {
                return (IReadonlyCollection<Topping>)_toppings.AsReadOnly();
            }
        }

        public RecipeBase()
        {
        }

        public abstract void AddMyRecipe(List<Topping> _toppings);

        public virtual void AddTopping(Store.Topping toppings)
        {
            _toppings.Add(toppings);
        }

        public virtual void RemoveTopping(Store.Topping toppings)
        {
            if (!_toppings.Any(t => t.Name == toppings.Name))
                throw new System.Exception("Topping not exist");

            // TODO Remove toppings
        }
    }
}

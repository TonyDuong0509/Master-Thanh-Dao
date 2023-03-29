using System.Linq;
using System.Collections.Generic;
using System;

namespace Store.Features.Breads
{
    public class RecipeBase
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
            _toppings = new List<Store.Topping>();
        }

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

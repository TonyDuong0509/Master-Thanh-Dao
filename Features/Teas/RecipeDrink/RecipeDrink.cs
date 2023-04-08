using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Features.Teas
{
    public class RecipeDrink
    {
        protected readonly List<Topping> toppingsDrink;

        public RecipeDrink()
        {
            toppingsDrink = new List<Topping>();
        }

        public void AddToppingsDrink(List<Topping> toppings)
        {
            toppings = new List<Topping>();
        }

        public void RemoveTopping(Store.Topping toppings)
        {
            if (!toppingsDrink.Any(t => t.Name == toppings.Name))
                throw new System.Exception("Topping not exist");

            // TODO Remove toppings
        }
    }
}

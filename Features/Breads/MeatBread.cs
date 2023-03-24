using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class MeatBread : Menu, IOrder
    {
        public override void PrepareSpice()
        {
            Console.WriteLine("Meat is cutting..");
        }

        public MeatBread()
        {
            int input = 0;
            name = "Meat Bread";
            dough = "Thick";
            sauce = "Salty";
            Console.WriteLine("Do you want to add Meats? - Input <1> YES or <2> No");
            input = int.Parse(Console.ReadLine());
            if (input == 1)
                toppings.Add("Cucumber");
            Console.WriteLine("Do you want to add Two Eggs? - Input <1> YES or <2> No");
            input = int.Parse(Console.ReadLine());
            if (input == 1)
                toppings.Add("Two Eggs");
        }
        public void Order()
        {
            MeatBread meatBread = new MeatBread();
            Console.WriteLine("Order MeatBread..." +name);
            meatBread.PrepareSpice();
            meatBread.Prepare();
            meatBread.AddEgg();
            meatBread.box();
        }
    }
}

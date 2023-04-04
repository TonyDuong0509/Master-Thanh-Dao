using Store.Features.Breads;
using Store.Features.Breads.Recipes;
using Store.Features.Breads.Toppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Topping> toppings = new List<Topping>();
            List<IOrder> orders = new List<IOrder>();
            int select = 0;
            do
            {
                Console.WriteLine(@"HaoStore have three breads with each of tastes and Milktea:
                                  1. Cheese Bread
                                  2. Vegetable Bread
                                  3. Meat Bread
                                  4. Milktea Cold
                                  5. Milktea Hot
                                        
                                    PLEASE ORDER...
                                  <- Select <Number> to ORDER ->
                                  <- Select any <key> to QUIT ->");
                select = int.Parse(Console.ReadLine());
                if (select == 1)
                {
                    CheeseBread cheeseBread = new CheeseBread();
                    orders.Add(cheeseBread);
                }
                else if (select == 2)
                {
                    VegetableBread vegetableBread = new VegetableBread();
                    orders.Add(vegetableBread);
                }
                else if (select == 3)
                {
                    MeatBread meatBread = new MeatBread();
                    orders.Add(meatBread);
                }
                else if (select == 4)
                {
                    MilkTeaCold milkTeaCold = new MilkTeaCold();
                    orders.Add(milkTeaCold);
                }
                else
                {
                    MilkTeaHot milkTeaHot = new MilkTeaHot();
                    orders.Add(milkTeaHot);
                }
                foreach (IOrder o in orders)
                {
                    o.Order();
                }
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Enter to continue order !!!");
                Console.ReadLine();
            } while (select!=5);
        }
    }
}


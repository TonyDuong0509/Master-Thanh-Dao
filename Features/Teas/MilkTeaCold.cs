using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class MilkTeaCold : Tea, IOrder
    {
        public MilkTeaCold()
        {
            name = "Oolong Tea";
            size = "Size XL";
            price = 37.555f;
            drinkHot = "Drink Cold";
        }
        public override void Prepare()
        {
            Console.WriteLine("Pour milk into tea...");
        }
        public void Order()
        {
            MilkTeaCold milkTeaCold = new MilkTeaCold();
            Console.WriteLine("Order Milktea..." + name);
            milkTeaCold.Prepare();
            Console.WriteLine("Adding ice into cup..." + drinkCold);
            Console.WriteLine("Paying...."+price);
        }
    }
}

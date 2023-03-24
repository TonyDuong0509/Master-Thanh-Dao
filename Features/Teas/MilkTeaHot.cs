using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class MilkTeaHot : Tea, IOrder
    {
        public MilkTeaHot()
        {
            name = "Oolong Tea";
            size = "Size S";
            price = 25.555f;
            drinkHot = "Drink Hot";
        }
        public override void Prepare()
        {
            Console.WriteLine("Pour milk into tea...");
        }
        public void Order()
        {
            MilkTeaHot milkTeaHot = new MilkTeaHot();
            Console.WriteLine("Order Milktea..." + name);
            milkTeaHot.Prepare();
            Console.WriteLine("Heat milk to 100 degrees..." +drinkHot);
        }
    }
}

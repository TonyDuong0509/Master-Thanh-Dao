using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSSS
{
    public class MilkTea : Drinks, IDrinkHot, IDrinkCold
    {
        public override void Prepare()
        {
            Console.WriteLine("Pour milk into tea...");
        }

        public void DrinkHot()
        {
            Console.WriteLine("Heat milk to 100 degrees...");
        }

        public void DrinkCold()
        {
            Console.WriteLine("Adding ice into cup...");
        }

    }
}

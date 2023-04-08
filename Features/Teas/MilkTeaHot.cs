using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Features.Teas
{
    public class MilkTeaHot : Tea<RecipeMilkTeaHot>
    {
        public MilkTeaHot() : base(new RecipeMilkTeaHot())
        {
            name = "Oolong Tea";
            size = "Size S";
            drinkHot = "Drink Hot";
        }
        public override void Prepare()
        {
            Console.WriteLine("Pour milk into tea...");
        }
    }
}

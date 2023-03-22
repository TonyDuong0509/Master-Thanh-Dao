using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSSS
{
    public class HaoStore
    {
        public void OrderCheeseBread()
        {
            CheeseBread cheeseBread = new CheeseBread();
            cheeseBread.PrepareSpice();
            cheeseBread.Prepare();
            cheeseBread.AddEgg();
            cheeseBread.box();
        }

        public void OrderVegetableBread()
        {
            VegetableBread vegetableBread = new VegetableBread();
            vegetableBread.PrepareSpice();
            vegetableBread.Prepare();
            vegetableBread.AddEgg();
            vegetableBread.box();
        }

        public void OrderMeatBread()
        {
            MeatBread meatBread = new MeatBread();
            meatBread.PrepareSpice();
            meatBread.Prepare();
            meatBread.AddEgg();
            meatBread.box();
        }

        public void OrderMilkTea()
        {
            MilkTea milkTea = new MilkTea();
            milkTea.Prepare();
            milkTea.DrinkHot();
            milkTea.DrinkCold();
        }
    }
}

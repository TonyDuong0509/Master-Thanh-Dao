using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSSS
{
    #region Abstract Class
    public abstract class Menu
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        public abstract void PrepareSpice();

        public void Prepare()
        {
            Console.WriteLine("Tossing dough..." + name);
            Console.WriteLine("Bread is baking..." + name);
            Console.WriteLine("Sauce is adding...");
            Console.WriteLine("Toppings are adding...");
            toppings?.ForEach((topping) => Console.WriteLine("\t" + topping));
        }

        public void AddEgg()
        {
            Console.WriteLine("Egg is adding..." + name);
        }

        public void box()
        {
            Console.WriteLine("Bread is boxing..." + name);
        }
    }
    #endregion

    #region CheeseBread
    public class CheeseBread : Menu
    {
        public override void PrepareSpice()
        {
            Console.WriteLine("Cheese is prepared...");
        }

        public CheeseBread()
        {
            name = "Cheese Bread";
            dough = "Very thin";
            sauce = "Sweet";
            toppings.Add("Tomato");
            toppings.Add("Chilli");
        }
    }
    #endregion

    #region VegetableBread
    public class VegetableBread : Menu
    {
        public override void PrepareSpice()
        {
            Console.WriteLine("Vegetable is washed..");
        }

        public VegetableBread()
        {
            name = "Vegetable Bread";
            dough = "Very thick";
            sauce = "Sour";
            toppings.Add("Cucumber");
            toppings.Add("Orion");
        }
    }
    #endregion

    #region MeatBread
    public class MeatBread : Menu
    {
        public override void PrepareSpice()
        {
            Console.WriteLine("Meat is cutting..");
        }

        public MeatBread()
        {
            name = "Meat Bread";
            dough = "Thick";
            sauce = "Salty";
            toppings.Add("Meats");
            toppings.Add("two Eggs");
        }
    }
    #endregion

    #region Drinks
    public abstract class Drinks
    {
        public abstract void Prepare();
    }

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
    interface IDrinkHot
    {
        void DrinkHot();
    }

    interface IDrinkCold
    {
        void DrinkCold();
    }
    #endregion

    #region Class just to Order
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
    #endregion
}

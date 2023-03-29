//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Store
//{
//    public class MeatBread : Menu, IOrder
//    {
//        public override void PrepareSpice()
//        {
//            Console.WriteLine("Meat is cutting..");
//        }

//        public MeatBread()
//        {
//            name = "Meat Bread";
//            dough = "Very thick";
//            sauce = "Salty";
//        }
//        public void Order()
//        {
//            Console.WriteLine("Order MeatBread..." +name);
//            this.PrepareSpice();
//            this.Prepare();
//            this.AddEgg();
//            this.Box();
//        }

//        public override void Add(string names)
//        {
//            if (!toppings.Contains(new Toppings(names))) toppings.Add(new Toppings(names));
//            else { }
//        }
//        public override void Remove(string names)
//        {
//            if (toppings.Contains(new Toppings(name))) toppings.Remove(new Toppings(name));
//            else { }
//        }
//    }
//}

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
            List<IOrder> orders = new List<IOrder>();
            List<IOrderTopping1> orderTopping1 = new List<IOrderTopping1>();
            List<IOrderTopping2> orderTopping2 = new List<IOrderTopping2>();
            int select = 0;
            do
            {
                Console.WriteLine(@"HaoStore have three breads with each of tastes and Milktea:
                                  1. Cheese Bread
                                  2. Vegetable Bread
                                  3. Meat Bread
                                  -- Milktea --
                                        
                                    PLEASE ORDER...
                                  <- Select <1> to ORDER ->
                                  <- Select any <key> to QUIT ->");
                select = int.Parse(Console.ReadLine());
                if (select == 1)
                {
                    int select1 = 0;
                    do
                    {
                        Console.WriteLine("*******************************");
                        Console.WriteLine("\nPlease select <1> to buy Cheese Bread");
                        Console.WriteLine("Please select <2> to buy Vegetable Bread");
                        Console.WriteLine("Please select <3> to buy Meat Bread");
                        Console.WriteLine("Please select <4> to buy HotMilktea");
                        Console.WriteLine("Please select <5> to buy ColdMilktea");
                        Console.WriteLine();
                        select1 = int.Parse(Console.ReadLine());
                        int choise = 0;
                        if (select1 == 1)
                        {
                            CheeseBread cheeseBread = new CheeseBread();
                            orders.Add(cheeseBread);
                            Console.WriteLine("Do you want to add Tomato? - Choise <1> YES or Choise <2> NO");
                            choise = int.Parse(Console.ReadLine());
                            CheeseBread cheeseBreadTopping1 = new CheeseBread();
                            if (choise == 1)
                                orderTopping1.Add(cheeseBreadTopping1);
                            Console.WriteLine("Do you want to add Chilli? - Choise <1> YES or Choise <2> NO");
                            choise = int.Parse(Console.ReadLine());
                            CheeseBread cheeseBreadTopping2 = new CheeseBread();
                            if (choise == 1)
                                orderTopping2.Add(cheeseBreadTopping2);
                        }
                        else if (select1 == 2)
                        {
                            VegetableBread vegetableBread = new VegetableBread();
                            orders.Add(vegetableBread);
                            Console.WriteLine("Do you want to add Cucumber? - Choise <1> YES or Choise <2> NO");
                            choise = int.Parse(Console.ReadLine());
                            VegetableBread vegetableTopping1 = new VegetableBread();
                            if (choise == 1)
                                orderTopping1.Add(vegetableTopping1);
                            Console.WriteLine("Do you want to add Orion? - Choise <1> YES or Choise <2> NO");
                            choise = int.Parse(Console.ReadLine());
                            VegetableBread vegetableTopping2 = new VegetableBread();
                            if (choise == 1)
                                orderTopping2.Add(vegetableTopping2);
                        }

                        else if (select1 == 3)
                        {
                            MeatBread meatBread = new MeatBread();
                            orders.Add(meatBread);
                            Console.WriteLine("Do you want to add Meats? - Choise <1> YES or Choise <2> NO");
                            choise = int.Parse(Console.ReadLine());
                            MeatBread meatBreadTopping1 = new MeatBread();
                            if (choise == 1)
                                orderTopping1.Add(meatBreadTopping1);
                            Console.WriteLine("Do you want to add Two Eggs? - Choise <1> YES or Choise <2> NO");
                            choise = int.Parse(Console.ReadLine());
                            MeatBread meatBreadTopping2 = new MeatBread();
                            if (choise == 1)
                                orderTopping2.Add(meatBreadTopping2);
                        }
                        else if (select1 == 4)
                        {
                            MilkTeaHot milkTeaHot = new MilkTeaHot();
                            orders.Add(milkTeaHot);
                        }
                        else 
                        {
                            MilkTeaCold milkTeaCold = new MilkTeaCold();
                            orders.Add(milkTeaCold);
                        }
                        foreach (IOrder o in orders)
                        {
                            Console.WriteLine("*******************************");
                            o.Order();
                        }
                        foreach (IOrderTopping1 ot1 in orderTopping1)
                        {
                            ot1.OrderTopping1();
                        }
                        foreach (IOrderTopping2 ot2 in orderTopping2)
                        {
                            ot2.OrderTopping2();
                        }
                    } while (select1 >= 1 && select1 <= 5);
                    Console.WriteLine("--------- Thank you very much ---------");
                }
            } while (select == 1);
            Console.ReadLine();
        }
    }
}

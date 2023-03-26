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
                            Console.WriteLine("Do you want to add Tomato? - Choise <1> YES or <2> NO");
                            choise = int.Parse(Console.ReadLine());
                            if (choise == 1) cheeseBread.Add("Tomato");
                            else cheeseBread.Remove("Tomato");
                            Console.WriteLine("Do you want to add Chiili? - Choise <1> YES or <2> NO");
                            choise = int.Parse(Console.ReadLine());
                            if (choise == 1) cheeseBread.Add("Chiili");
                            else cheeseBread.Remove("Chiili");
                            orders.Add(cheeseBread);
                        }
                        else if (select1 == 2)
                        {
                            VegetableBread vegetableBread = new VegetableBread();
                            Console.WriteLine("Do you want to add Cucumber? - Choise <1> YES or <2> NO");
                            choise = int.Parse(Console.ReadLine());
                            if (choise == 1) vegetableBread.Add("Cucumber");
                            else vegetableBread.Remove("Cucumber");
                            Console.WriteLine("Do you want to add Orion? - Choise <1> YES or <2> NO");
                            choise = int.Parse(Console.ReadLine());
                            if (choise == 1) vegetableBread.Add("Orion");
                            else vegetableBread.Remove("Orion");
                            orders.Add(vegetableBread);
                        }

                        else if (select1 == 3)
                        {
                            MeatBread meatBread = new MeatBread();
                            Console.WriteLine("Do you want to add Meats? - Choise <1> YES or <2> NO");
                            choise = int.Parse(Console.ReadLine());
                            if (choise == 1) meatBread.Add("Meats");
                            else meatBread.Remove("Meats");
                            Console.WriteLine("Do you want to add Two Eggs? - Choise <1> YES or <2> NO");
                            choise = int.Parse(Console.ReadLine());
                            if (choise == 1) meatBread.Add("Two Eggs");
                            else meatBread.Remove("Two Eggs");
                            orders.Add(meatBread);
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
                        foreach(IOrder o in orders)
                        {
                            Console.WriteLine("*********************************");
                            o.Order();
                        }
                    } while (select1 >= 1 && select1 <= 5);
                    Console.WriteLine("--------- Thank you very much ---------");
                }
            } while (select == 1);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSSS
{
    class Program
    {
        static void Main(string[] args)
        {
            HaoStore haoStore = new HaoStore();
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
                        Console.WriteLine("======================================================");
                        Console.WriteLine("\nPlease select <1> to buy Cheese Bread");
                        Console.WriteLine("Please select <2> to buy Vegetable Bread");
                        Console.WriteLine("Please select <3> to buy Meat Bread");
                        Console.WriteLine("Please select <4> to buy Milktea");
                        Console.WriteLine();
                        select1 = int.Parse(Console.ReadLine());
                        if (select1 == 1) haoStore.OrderCheeseBread();
                        else if (select1 == 2) haoStore.OrderVegetableBread();
                        else if (select1 == 3) haoStore.OrderMeatBread();
                        else haoStore.OrderMilkTea();
                    } while (select1 == 1 || select1 == 2 || select1 == 3 || select1 == 4);
                    Console.WriteLine("--------- Thank you very much ---------");
                }
            } while (select == 1);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            var price = -1.0;
            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana") price = 2.50;
                else if (fruit == "apple") price = 1.20;
                else if (fruit == "orange") price = 0.85;
                else if (fruit == "grapefruit") price = 1.45;
                else if (fruit == "kiwi") price = 2.70;
                else if (fruit == "pineapple") price = 5.50;
                else if (fruit == "grapes") price = 3.85;
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana") price = 2.70;
                else if (fruit == "apple") price = 1.25;
                else if (fruit == "orange") price = 0.90;
                else if (fruit == "grapefruit") price = 1.60;
                else if (fruit == "kiwi") price = 3.00;
                else if (fruit == "pineapple") price = 5.60;
                else if (fruit == "grapes") price = 4.20;
            }


            if (price >= 0)
            {
                Console.WriteLine("{0:f2}",price * quantity);
            }
            else
            {
                Console.WriteLine("error");
            }
           
        }
    }
}
// string fruit = Console.ReadLine();
//string day = Console.ReadLine();
//double quantity = double.Parse(Console.ReadLine());
            
//            if (day == "Monday" || day == "Tuesday" ||day == "Wednesday" || day == "Thursday" || day == "Friday")
//            {
//                if (fruit == "banana")
//                {
//                    Console.WriteLine(2.50* quantity);
//                }
//                else if (fruit == "apple")
//                {
//                    Console.WriteLine(1.20* quantity);
//                }
//                else if (fruit == "orange")
//                {
//                    Console.WriteLine(0.85* quantity);
//                }
//                else if (fruit == "grapefruit")
//                {
//                    Console.WriteLine(1.45* quantity);
//                }
//                else if (fruit == "kiwi")
//                {
//                    Console.WriteLine(2.70* quantity);
//                }
//                else if (fruit == "pineapple")
//                {
//                    Console.WriteLine(5.50* quantity);
//                }
//                else if (fruit == "grapes")
//                {
//                    Console.WriteLine(3.85* quantity);
//                }
//                else if (fruit == "tomato")
//                {
//                    Console.WriteLine("error");
//                }
               
//            }
//            else if (day == "Saturday" || day == "Sunday")
//            {
//                if (fruit == "banana")
//                {
//                    Console.WriteLine(2.70 * quantity);
//                }
//                else if (fruit == "apple")
//                {
//                    Console.WriteLine(1.25 * quantity);
//                }
//                else if (fruit == "orange")
//                {
//                    Console.WriteLine(0.90 * quantity);
//                }
//                else if (fruit == "grapefruit")
//                {
//                    Console.WriteLine(1.60 * quantity);
//                }
//                else if (fruit == "kiwi")
//                {
//                    Console.WriteLine(3.00 * quantity);
//                }
//                else if (fruit == "pineapple")
//                {
//                    Console.WriteLine(5.60 * quantity);
//                }
//                else if (fruit == "grapes")
//                {
//                    Console.WriteLine(4.20 * quantity);
//                }
               
//            }

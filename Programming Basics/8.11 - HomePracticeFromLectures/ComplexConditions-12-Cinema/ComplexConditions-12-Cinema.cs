using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexConditions_12_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double price = 0;
            double result = 0;
            if (type == "Premiere")
            {
                price = 12.00;
                result = c * r * price;
                Console.WriteLine("{0:f2}",result);
            }
            else if (type == "Normal")
            {
                price = 7.50;
                result = c * r * price;
                Console.WriteLine("{0:f2}", result);
            }
            else if (type == "Discount")
            {
                price = 5.00;
                result = c * r * price;
                Console.WriteLine("{0:f2}", result);
            }
        
        
        }
    }
}

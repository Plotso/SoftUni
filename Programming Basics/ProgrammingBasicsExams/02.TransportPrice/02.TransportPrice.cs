using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string period = Console.ReadLine();
            double price = 0;
            if (period == "day")
            {
                if (n < 20)
                {
                    price += 0.70 + (n * 0.79);
                }
                else if (n >= 20 && n < 100)
                {
                    price += n * 0.09;
                }
                else if (n >= 100)
                {
                    price += n * 0.06;
                }
            }
            else if (period == "night")
            {
                if (n < 20)
                {
                    price += 0.70 + (n * 0.90);
                }
                else if (n >= 20 && n < 100)
                {
                    price += n * 0.09;
                }
                else if (n >= 100)
                {
                    price += n * 0.06;
                }

            }
            Console.WriteLine("{0}:f2",price);
        }
    }
}

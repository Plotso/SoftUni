using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Firma
{
    class Program
    {
        static void Main(string[] args)

        {
            int h = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            double rD = d - (0.10 * d);
            double wH = rD * 8;
            double eW = w * (2 * d);
            double total =  Math.Truncate(wH + eW);
            if (total >= h)
            {
                Console.WriteLine("Yes!{0} hours left.",total - h);
            }
            else if (total < h)
            {
                Console.WriteLine("Not enough time!{0} hours needed.",h - total);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dividedByTwo = 0;
            int dividedByThree = 0;
            int dividedByFour = 0;
            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (current % 2 == 0)
                {
                    dividedByTwo++;
                }
                if (current % 3 == 0)
                {
                    dividedByThree++;
                }
                if (current % 4 == 0)
                {
                    dividedByFour++;
                }
            }
            Console.WriteLine("{0:f2}%",((double)dividedByTwo/n)*100);
            Console.WriteLine("{0:f2}%", ((double)dividedByThree / n) * 100);
            Console.WriteLine("{0:f2}%", ((double)dividedByFour / n) * 100);
            

        }
    }
}

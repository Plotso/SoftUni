using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Cifri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstDigit = n / 100;
            int secondDigit = (n / 10) % 10;
            int thirdDigit = n % 10;
            for (int i = 0; i < firstDigit + secondDigit; i++)
            {
                for (int j = 0; j < firstDigit + thirdDigit; j++)
                {
                    if (n % 5 == 0)
                    {
                        n -= firstDigit;
                    }
                    else if (n % 3 == 0)
                    {
                        n -= secondDigit;
                    }
                    else
                    {
                        n += thirdDigit;
                    }
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
            
            
        }
    }
}

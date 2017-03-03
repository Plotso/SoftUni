using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondFromExam
{
    class DiamondFromExam
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('.', n) +
                    new string('*', 5 * n - 2 * n) +
                    new string('.', n));

            for (int i = 1; i <= n - 1; i++)
            {
                Console.WriteLine(new string('.', n - i) + "*" +
                    new string('.', 5 * n - (n - i) * 2 - 2) + "*" +
                    new string('.', n - i));
            }
            Console.WriteLine(new string('*', 5 * n));

            for (int i = 1; i < 2 * n + 1; i++)
            {
                Console.WriteLine(new string('.', i) + "*" +
                    new string('.', 5 * n - 2 * i - 2) + "*" +
                    new string('.', i));
            }
            Console.WriteLine(new string('.', 2 * n + 1) +
                new string('*', 5 * n - (4 * n + 2)) +
                    new string('.', 2 * n + 1));
        }
    }
}

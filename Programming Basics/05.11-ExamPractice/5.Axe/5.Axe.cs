using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string ('-',3*n)+ "*" + 
                    new string('-',i) + "*" + new string('-',2*(n-1)-i));
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine(new string('-',3*n + 1) +
                    new string('-',n-1)+ "*" +
                    new string('-',n-1));
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine(new string ('-',3*n - i) + "*" +
                    new string ('-',n-1 + 2*1) + "*" +
                    new string ('-',n-1 - i));
            }
            Console.WriteLine(new string('-', 3 * n - (n / 2 - 1)) +  // ('-'),3 * n - n/2 + 1
                new string('*', n / 2) + new string('*', n - 1) +
                new string('*', n / 2) + new string('-',n- n/2));
        }
    }
}

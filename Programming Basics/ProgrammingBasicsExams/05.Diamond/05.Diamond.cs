using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('.',n) + new string('*',2 * n) + new string ('.',n));
            for (int i =1; i <= n - 1  ; i++)
            {
                Console.WriteLine(new string('.',n-i) + "*" + new string('.', 5 * n - (n - i) * 2 - 2) + 
                    "*" + new string('.',n-i));
            }
        }
    }
}

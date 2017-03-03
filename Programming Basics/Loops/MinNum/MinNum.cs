using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNum
{
    class MinNum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var min = 1000000;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }
                Console.WriteLine(min);
            }
        }
    }
}

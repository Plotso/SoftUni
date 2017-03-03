using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest3Numbers2
{
    class LargestThreeNumbersShort
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .Take(3)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}

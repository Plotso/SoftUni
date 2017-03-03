using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest3Numbers
{
    class LargestThreeNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var list = new List<int>().OrderByDescending(n => n).Take(3); 
            //.foreach(Console.WriteLine);
            foreach (var item in numbers)
            {

                Console.WriteLine();
            }
               
        }
    }
}

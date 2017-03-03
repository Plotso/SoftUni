using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativeAndReverse
{
    class RemoveNegativeAndReverse
    {
        static void Main(string[] args)
        {
            var listOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var remainingElements = new List<int>();
            foreach (var number in listOfIntegers)
            {
                if (number >= 0)
                {
                    remainingElements.Add(number);
                }
            }
            remainingElements.Reverse();
            if (remainingElements.Count > 0)
            {
                Console.WriteLine(string.Join(" ", remainingElements));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}

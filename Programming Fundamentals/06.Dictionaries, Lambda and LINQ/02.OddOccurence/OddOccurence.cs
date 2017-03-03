using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurence
{
    class OddOccurence
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse); // .ToList();
            var dictionary = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!dictionary.ContainsKey(number))
                {
                    dictionary[number] = 0;
                }
                dictionary[number]++;
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}

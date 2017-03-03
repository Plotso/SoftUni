using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SumReversedNumbers3
{
    class SumReversedNumbers3
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().ToList();
            var sum = new List<string>();
            foreach (var number in numbers)
            {
                var reversedNum = int.Parse(new string(number.Reverse()));
                sum.Add(reversedNum);
            }
            Console.WriteLine(int.Parse(sum.Sum()));
        }
    }
}

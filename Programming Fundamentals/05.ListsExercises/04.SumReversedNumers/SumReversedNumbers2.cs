using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SumReversedNumers
{
    class SumReversedNumbers2
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').ToList();
            var sum = new List<int>();
            foreach (var number in numbers)
            {
                var array = number.ToCharArray();
                var reversed = array.Reverse().ToArray();
                sum.Add(int.Parse(new string(reversed)));

            }
            Console.WriteLine(sum.Sum());
        }
    }
}

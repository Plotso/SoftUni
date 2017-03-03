using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').ToList();
            int sum = 0;
            foreach (var number in numbers)
            {
                var array = number.ToCharArray();
                var reversed = array.Reverse().ToArray();
                int num = int.Parse(new string(reversed));
                sum += num;

            }
            Console.WriteLine(sum);
            
        }
    }
}

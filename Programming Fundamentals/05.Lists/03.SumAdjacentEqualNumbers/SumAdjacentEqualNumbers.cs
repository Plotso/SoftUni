using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            for (int i = 1; i < input.Count ; i++)
            {
                if (input[i-1] == input[i])
                {
                    input[i-1] *= 2;
                    input.RemoveAt(i);
                    i-=2;
                    if (i < 0)
                    {
                        i = 0;
                    }
                 // it can also be done by skipping the if statement and instead of writting
                 // i -= 2 we can just write i = 0 so that the loop starts from the zero position again
                }

            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var currentSequenceStartIndex = 0;
            var currentSequenceLength = 1;
            var longestSequenceStartIndex = 0;
            var longestSequenceLength = 1;
            for (int i = 0; i < integers.Count - 1; i++)
            {
                if (integers[i] == integers[i + 1])
                {
                   currentSequenceLength++;
                    if (currentSequenceLength > longestSequenceLength)
                    {
                        longestSequenceLength = currentSequenceLength;
                        longestSequenceStartIndex = currentSequenceStartIndex;
                    }
                }
                else
                {
                    currentSequenceStartIndex = i + 1;
                    currentSequenceLength = 1;
                }
            }
            var result = integers.Skip(longestSequenceStartIndex).Take(longestSequenceLength).ToList();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}

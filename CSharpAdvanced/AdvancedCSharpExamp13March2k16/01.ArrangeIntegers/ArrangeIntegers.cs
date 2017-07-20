namespace _01.ArrangeIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ArrangeIntegers
    {
        public static void Main()
        {
            var numsInWords = new List<string>()
            { "zero", "one",
              "two", "three",
              "four", "five",
              "six", "seven",
              "eight", "nine"
            };

            var input = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var stringSort = SortedNumbersAsString(input, numsInWords);
        }

        private static object SortedNumbersAsString(int[] input, List<string> numsInWords)
        {

            foreach (var number in input)
            {
                var sb = new StringBuilder();
                for (int i = 0; i < number.ToString().Length; i++)
                {

                }
            }
        }
    }
}

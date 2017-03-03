namespace _06.FoldAndSum2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FoldAndSum2
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int k = input.Count / 4;

            var firstRowLeft = input
                .Take(k)
                .Reverse()
                .ToList();

            var firstRowRight = input
                .Skip(3 * k)
                .Take(k)
                .Reverse()
                .ToList();

            var firstRow = firstRowLeft.Concat(firstRowRight).ToList();

            var secondRow = input.Skip(k).Take(2 * k).ToList();

            var finalResult = new List<int>();
            //var result = firstRow.Select((n, index) => n + secondRow[index]);
            //Console.WriteLine(string.Join(" ", result));
            for (int i = 0; i < input.Count / 2; i++)
            {
                var currentNumber = firstRow[i] + secondRow[i];
                finalResult.Add(currentNumber);
            }
            Console.WriteLine(string.Join(" ",finalResult));
        }
    }
}

namespace _06.FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = input.Length / 4;

            var firstRowLeft = input
                .Take(k)
                .Reverse()
                .ToList();

            var firstRowRight = input
                .Reverse()
                .Take(k)
                .ToList();

            var firstRow = firstRowLeft.Concat(firstRowRight).ToList();

            var secondRow = input.Skip(k).Take(2 * k).ToList();

            var result = firstRow.Zip(secondRow, (x, y) => x + y);

            //var result = new List<int>()
            //{
            //    firstRow[0] + secondRow[0],
            //    firstRow[1] + secondRow[1]
            //};

            Console.WriteLine(string.Join(" ", result));

            //var result = firstRow.Select((n, index) => n + secondRow[index]);

        }
    }
}

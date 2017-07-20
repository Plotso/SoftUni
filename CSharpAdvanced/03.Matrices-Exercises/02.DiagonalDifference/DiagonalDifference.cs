namespace _02.DiagonalDifference
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DiagonalDifference
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var matrix = new int[n][];

            var primaryDiagonalSum = 0;
            var secondaryDiagonalSum = 0;

            for (int i = 0; i < n; i++)
            {
                //matrix[n] = new int[i];
                matrix[i] = Console.ReadLine()
                    .Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                primaryDiagonalSum += matrix[i][i];
                secondaryDiagonalSum += matrix[i][matrix[i].Length - 1 - i];
            }

            var result = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);

            Console.WriteLine(result);

        }
    }
}

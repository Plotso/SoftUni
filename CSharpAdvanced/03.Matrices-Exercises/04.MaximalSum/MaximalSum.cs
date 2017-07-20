namespace _04.MaximalSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaximalSum
    {
        public static void Main()
        {
            var matrixSize = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            var matrix = new int[matrixSize[0]][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            var maxSquareRow = 0;
            var maxSquareCol = 0;
            var sum = int.MinValue;

            for (int row = 1; row < matrix.Length - 1; row++)
            {
                for (int col = 1; col < matrix[row].Length - 1; col++)
                {
                    var currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col - 1] +
                        matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col - 1] +
                        matrix[row - 1][col] + matrix[row - 1][col + 1] + matrix[row - 1][col - 1];

                    if (sum < currentSum)
                    {
                        sum = currentSum;
                        maxSquareRow = row;
                        maxSquareCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {sum}");
            //Console.WriteLine(
            //    $"{matrix[maxSquareRow][maxSquareCol]} {matrix[maxSquareRow][maxSquareCol + 1]} " +
            //    $"{matrix[maxSquareRow][maxSquareCol + 2]} \n" +
            //    $"{matrix[maxSquareRow + 1][maxSquareCol]} {matrix[maxSquareRow + 1][maxSquareCol + 1]} " +
            //    $"{matrix[maxSquareRow + 1][maxSquareCol + 2]} \n" +
            //    $"{matrix[maxSquareRow + 2][maxSquareCol]} {matrix[maxSquareRow + 2][maxSquareCol + 1]} " +
            //    $"{matrix[maxSquareRow + 2][maxSquareCol + 2]}");

            Console.WriteLine($"{matrix[maxSquareRow - 1][maxSquareCol - 1]} {matrix[maxSquareRow - 1][maxSquareCol]} {matrix[maxSquareRow - 1][maxSquareCol + 1]}\r\n" +
                $"{matrix[maxSquareRow][maxSquareCol - 1]} {matrix[maxSquareRow][maxSquareCol]} {matrix[maxSquareRow][maxSquareCol + 1]}\r\n" +
                $"{matrix[maxSquareRow + 1][maxSquareCol - 1]} {matrix[maxSquareRow + 1][maxSquareCol]} {matrix[maxSquareRow + 1][maxSquareCol + 1]}");
        }
    }
}

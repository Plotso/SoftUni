namespace _01.SumMatrixElements2
{
    using System;
    using System.Linq;

    public class SumMatrixElements2
    {
        public static void Main()
        {
            var matrixSize = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrix = new int[matrixSize[0]][];

            var sum = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                //for (int col = 0; col < matrix[row].Length; col++)
                //{
                //    sum += matrix[row][col];
                //}

                sum += matrix[row].Sum();
            }

            Console.WriteLine(matrixSize[0]);
            Console.WriteLine(matrixSize[1]);
            Console.WriteLine(sum);
        }
    }
}

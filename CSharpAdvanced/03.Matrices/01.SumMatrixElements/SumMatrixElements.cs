namespace _01.SumMatrixElements
{
    using System;
    using System.Linq;

    public class SumMatrixElements
    {
        public static void Main()
        {
            var matrixSize = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = matrixSize[0];
            var cols = matrixSize[1];
            
            var matrix = new int[rows, cols];

            var sum = 0;
            for (int row = 0; row < rows; row++)
            {
                var inputRow = Console.ReadLine()
                    .Split(new[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = inputRow[col];
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}

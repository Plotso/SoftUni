namespace _01.MatrixOfPalindromes2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MatrixOfPalindromes2
    {
        public static void Main()
        {
            //var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            var matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var rows = matrixSize[0];
            var cols = matrixSize[1];

            var matrix = new string[rows,cols];

            char firstAndLastChar = 'a';
            for (int row = 0; row < rows; row++)
            {
                char middleChar = firstAndLastChar;
                for (int col = 0; col < cols; col++)
                {
                    var resultString = firstAndLastChar.ToString() + middleChar.ToString() + firstAndLastChar.ToString();
                    matrix[row, col] = resultString;
                    Console.Write(matrix[row, col] + " ");
                    middleChar++;
                }
                Console.WriteLine();
                firstAndLastChar++;
            }

        }
    }
}

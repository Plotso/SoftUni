namespace _01.MatrixOfPalindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MatrixOfPalindromes
    {
        public static void Main()
        {
            //var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            var matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var rows = matrixSize[0];
            var cols = matrixSize[1];

            char a = 'a';
            char b = 'a';
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(a);
                    Console.Write(b);
                    Console.Write(a);
                    Console.Write(" ");
                    b++;
                }
                Console.WriteLine();
                a++;
                b = a;
            }

        }
    }
}

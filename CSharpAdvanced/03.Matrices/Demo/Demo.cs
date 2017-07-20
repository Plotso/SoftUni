namespace Demo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Demo
    {
        public static void Main()
        {
            int[,] matrix = new int[5, 5];

            int counter = 10;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    matrix[row, col] = counter;
                    counter++;
                    Console.Write($"{matrix[row,col]}");
                }
                Console.WriteLine();
            }

        }
    }
}

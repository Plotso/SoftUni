namespace Demo1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Demo1
    {
        public static void Main()
        {
            int[][] matrix = new int[5][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[5];
            }

            matrix[3][3] = 20;

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}

namespace _03.GroupNumbersDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GroupNumbersDemo
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] sizes = new int[3];

            foreach (var number in numbers)
            {
                int reminder = number % 3;
                sizes[reminder]++;
            }

            int[][] matrix = new int[3][]
            {
              new int[sizes[0]],
              new int[sizes[1]],
              new int[sizes[2]]
            };

            int[] offsets = new int[3];
            foreach (var number in numbers)
            {
                int reminder = Math.Abs(number % 3);
                int index = offsets[reminder];
                matrix[reminder][index] = number;
                offsets[reminder]++;
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}

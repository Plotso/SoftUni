namespace _05.RubiksMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RubiksMatrix
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var R = dimensions[0];
            var C = dimensions[1];

            var matrix = new int[R][];

            var counter = 1;

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[C];
            }
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = counter;
                    counter++;
                }
            }

            var numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var command = Console.ReadLine().Split().ToArray();

                var rowOrCol = int.Parse(command[0]);
                var direction = command[1];
                var move = int.Parse(command[2]);

                switch (direction)
                {
                    case "up":
                        for (int row = 0; row < matrix.Length; row++)
                        {
                            for (int col = 0; col < matrix[row].Length; col++)
                            {
                                if (col == rowOrCol)
                                {

                                }
                            }
                        }
                        break;
                    case "down":
                        break;
                    case "left":
                        break;
                    case "right":
                        break;
                }
            }
        }
    }
}

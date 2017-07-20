namespace _02.NaturesProphet
{
    using System;
    using System.Linq;

    public class NaturesProphet
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var gardenRows = dimensions[0];
            var gardenCols = dimensions[1];

            var garden = GardenSize(gardenRows, gardenCols);

            var input = Console.ReadLine();

            var counter = 0;
            var maxLoops = gardenRows * gardenCols;
            while (input != "Bloom Bloom Plow")
            {
                var integers = input.Split().Select(int.Parse).ToArray();
                var givenRow = integers[0];
                var givenCol = integers[1];

                for (int rowIndex = 0; rowIndex < garden[givenCol].Length; rowIndex++)
                {
                    garden[rowIndex][givenCol] += 1;
                }
                for (int colIndex = 0; colIndex < garden.Length; colIndex++)
                {
                    garden[givenRow][colIndex] += 1;
                }
                garden[givenRow][givenCol] --;

                input = Console.ReadLine();
            }
            foreach (var row in garden)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }

        private static int[][] GardenSize(int gardenRows, int gardenCols)
        {
            var garden = new int[gardenRows][];

            for (int rowIndex = 0; rowIndex < garden.Length; rowIndex++)
            {
                garden[rowIndex] = new int[gardenCols];
                for (int colIndex = 0; colIndex < garden[rowIndex].Length; colIndex++)
                {
                    garden[rowIndex][colIndex] = 0;
                }
            }
            return garden;
        }
    }
}

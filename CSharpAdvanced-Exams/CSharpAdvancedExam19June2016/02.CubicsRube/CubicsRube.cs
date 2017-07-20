namespace _02.CubicsRube
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CubicsRube
    {
        public static void Main()
        {
            var dimensionSize = long.Parse(Console.ReadLine());

            var sumOfPatricles = 0l;
            var changedCells = 0l;
            string input;
            while ((input = Console.ReadLine()) != "Analyze")
            {
                var inputTokens = input
                    .Split()
                    .Select(long.Parse)
                    .ToArray();

                if (inputTokens.Take(3).Any(pt => pt < 0 || pt >= dimensionSize))
                {
                    continue;
                }
                if (inputTokens[3] != 0)
                {
                    sumOfPatricles += inputTokens[3];
                    changedCells++;
                }
            }

            Console.WriteLine(sumOfPatricles);
            Console.WriteLine(Math.Pow(dimensionSize,3) - changedCells);
        }
    }
}

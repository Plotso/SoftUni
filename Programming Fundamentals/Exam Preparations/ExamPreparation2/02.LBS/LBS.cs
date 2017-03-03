namespace _02.LBS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LBS
    {
        public static void Main()
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var ladyBugsIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(f => f >= 0 && f < fieldSize)
                .ToArray();

            var ladyBugs = new int[fieldSize];

            for (int i = 0; i < ladyBugsIndexes.Length; i++)
            {
                var currentLadyBugIndex = ladyBugsIndexes[i];
                ladyBugs[currentLadyBugIndex] = 1;
            }
        }
    }
}

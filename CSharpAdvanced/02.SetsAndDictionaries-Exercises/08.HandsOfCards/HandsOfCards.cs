namespace _08.HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HandsOfCards
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', ':' });

            var peopleDict = new Dictionary<string, int>();

            while (input[0] != "JOKER")
            {
                var score = 0;

                if (!peopleDict.ContainsKey(input[0]))
                {
                    peopleDict[input[0]] = score;
                }
                else
                {
                    peopleDict[input[0]] += score;
                }
                input = Console.ReadLine()
                .Split(new[] { ' ', ':' });
            }
        }
    }
}

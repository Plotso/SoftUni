namespace _04.HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HornetArmada
    {
        public static void Main()
        {
            var numberOfInput = int.Parse(Console.ReadLine());
            //var sortLegions = new Dictionary<Dictionary<int,string>, int>();
            var sortedLegions = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfInput; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                var lastActivity = int.Parse(input[0]);
                var legionName = input[2];
                var soldierTypeCount = input[4].Split(':').ToArray();
                var soldierType = soldierTypeCount[0];
                var soldierCount = int.Parse(soldierTypeCount[1]);
                var randomDict = new Dictionary<string, int>();
                
                if (sortedLegions.ContainsKey(legionName))
                {
                    if (randomDict.ContainsKey(soldierType))
                    {
                        
                        sortedLegions[legionName][soldierType] = soldierCount;
                    }
                    sortedLegions[legionName] = randomDict;
                    //sortedLegions[legionName][soldierType] = soldierCount;
                }
                else
                {
                    randomDict[soldierType] = soldierCount;
                    //sortedLegions[legionName] = randomDict;
                    sortedLegions[legionName][soldierType] = soldierCount;
                }
            }
            var finalInput = Console.ReadLine().Split();
            if (finalInput.Length == 1)
            {
                var soldierType = finalInput;
            }
            else if (finalInput.Length > 1)
            {
                var activity = finalInput[0];
                var soldierType = finalInput[2];
            }
        }
    }
}

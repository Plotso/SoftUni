namespace _04.CubicAssault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CubicAssault
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var resultDictionary = new Dictionary<string, SortedDictionary<string, long>>();

            while (input != "Count em all")
            {
                var inputTokens = input
                    .Split(new[] { " -> " },StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var regionName = inputTokens[0];
                var meteorType = inputTokens[1];
                var count = long.Parse(inputTokens[2]);


                if (!resultDictionary.ContainsKey(regionName))
                {
                    resultDictionary.Add(regionName, new SortedDictionary<string, long>());
                    resultDictionary[regionName].Add("Black", 0);
                    resultDictionary[regionName].Add("Red", 0);
                    resultDictionary[regionName].Add("Green", 0);
                }
                resultDictionary[regionName][meteorType] += count;

                if (resultDictionary[regionName]["Green"] >= 1000000)
                {
                    resultDictionary[regionName]["Red"] += resultDictionary[regionName]["Green"] / 1000000;
                    resultDictionary[regionName]["Green"] %= 1000000;
                }
                if (resultDictionary[regionName]["Red"] >= 1000000)
                {
                    resultDictionary[regionName]["Black"] += resultDictionary[regionName]["Red"] / 1000000;
                    resultDictionary[regionName]["Red"] %= 1000000;
                }

                input = Console.ReadLine();
            }

            foreach (var result in resultDictionary.OrderByDescending(x => x.Value["Black"]).ThenBy(x => x.Key.Length).ThenBy(x => x.Key))
            {
                var regionName = result.Key;
                Console.WriteLine(regionName);
                foreach (var type in result.Value.OrderByDescending(x => x.Value))
                {
                    var typeName = type.Key;
                    var typeCount = type.Value;
                    Console.WriteLine($"-> {typeName} : {typeCount}");
                }
            }
        }
    }
}

namespace _04.NSA
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NSA
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var spyDict = new Dictionary<string, Dictionary<string, int>>();
            while (input != "quit")
            {
                var inputData = input
                    .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var countryName = inputData[0];
                var spyName = inputData[1];
                var daysInService = int.Parse(inputData[2]);

                if (!spyDict.ContainsKey(countryName))
                {
                    spyDict.Add(countryName, new Dictionary<string, int>() { {spyName, daysInService} });
                    //spyDict[countryName].Add(spyName, daysInService);
                }
                else
                {
                    if (!spyDict[countryName].ContainsKey(spyName))
                    {
                        spyDict[countryName].Add(spyName, daysInService);
                    }
                    else
                    {
                        spyDict[countryName][spyName] = daysInService;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var country in spyDict.OrderByDescending(x => x.Value.Count))
            {
                var countryName = country.Key;
                var spies = country.Value;

                Console.WriteLine($"Country: {countryName}");

                foreach (var spy in spies.OrderByDescending(x => x.Value))
                {
                    var spyName = spy.Key;
                    var daysInService = spy.Value;
                    Console.WriteLine($"**{spyName} : {daysInService}");
                }
            }
        }
    }
}

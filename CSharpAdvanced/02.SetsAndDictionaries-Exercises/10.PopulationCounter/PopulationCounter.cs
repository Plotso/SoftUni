namespace _10.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split('|');
            var dictionary = new Dictionary<string, Dictionary<string, long>>();
            
            while (input[0] != "report")
            {
                var city = input[0];
                var country = input[1];
                var population = long.Parse(input[2]);

                input = Console.ReadLine().Split('|');

                if (!dictionary.ContainsKey(country))
                {
                    dictionary[country] = new Dictionary<string, long>() { { city, population } };
                }
                else
                {
                    dictionary[country].Add(city, population);
                }
                

            }

            foreach (var country in dictionary.OrderByDescending(a => a.Value.Sum(d => d.Value)))
            {
                var countyName = country.Key;
                var countryPopulation = country.Value.Sum(a => a.Value);
                Console.WriteLine($"{countyName} (total population: {countryPopulation})");
                foreach (var city in country.Value.OrderByDescending(a => a.Value))
                {
                    var cityName = city.Key;
                    var cityPopulation = city.Value;
                    Console.WriteLine($"=>{cityName}: {cityPopulation}");
                }
            }
        }
    }
}

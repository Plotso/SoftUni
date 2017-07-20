using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<StringBuilder>>();
            var input = Console.ReadLine();

            while (input != "wubbalubbadubdub")
            {
                var sb = new StringBuilder();
                var split = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                if (split.Length == 1)
                {
                    if (dict.ContainsKey(input))
                    {
                        Console.WriteLine($"# {input}");
                        foreach (var item in dict[input])
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
                else
                {
                    var name = split[0];
                    var evolution = split[1];
                    var index = int.Parse(split[2]);
                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, new List<StringBuilder>());
                    }

                    sb.Append(evolution + " <-> " + index.ToString());
                    dict[name].Add(sb);
                }

                input = Console.ReadLine();
            }


            foreach (var item in dict)
            {
                Console.WriteLine(item.Key);
                foreach (var evolution in item.Value)
                {
                    Console.WriteLine(evolution);
                }
            }


            //foreach (var elements in grades)
            //{
            //    int sum = elements.Value.Sum(x => Convert.ToInt32(x));
            //    Console.WriteLine($"{elements.Key} -> {String.Join(" ", $"{elements.Value:f2}")} (avg: {sum:F2})");
            //}
        }
    }
}
//var input = Console.ReadLine();

//var dictionary = new Dictionary<string, Dictionary<string, int>>();

//            while (input != "wubbalubbadubdub")
//            {
//                if (input.Split().Length == 1)
//                {
//                    if (dictionary.ContainsKey(input))
//                    {
//                        var pokemonName = input;
//var pokemon = dictionary[input];
//Console.WriteLine($"# {pokemonName}");
//                        foreach (var evo in pokemon)
//                        {
//                            var evolutionType = evo.Key;
//var evolutionIndex = evo.Value;
//Console.WriteLine($"{evolutionType} <-> {evolutionIndex}");
//                        }
//                    }
//                }
//                else
//                {
//                    var inputTokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
//var pokemonName = inputTokens[0];
//var evolutionType = inputTokens[1];
//var evolutionIndex = int.Parse(inputTokens[2]);

//                    if (!dictionary.ContainsKey(pokemonName))
//                    {
//                        dictionary.Add(pokemonName, new Dictionary<string, int>() { { evolutionType, evolutionIndex } });
//                        //[pokemonName].Add(new Dictionary<string, int>() { { evolutionType, evolutionIndex } });
//                    }
//                    else
//                    {
//                        if (!dictionary[pokemonName].ContainsKey(evolutionType))
//                        {
//                            dictionary[pokemonName].Add(evolutionType, evolutionIndex);
//                        }
//                        else
//                        {
//                            dictionary[pokemonName].Add(new Dictionary<string, int>() { });
//                        }
                        
//                    }

//                }

//                input = Console.ReadLine();
//            }

//            foreach (var pokemon in dictionary)
//            {
//                var pokemonName = pokemon.Key;
//Console.WriteLine($"# {pokemonName}");
//                foreach (var evolutions in pokemon.Value.OrderByDescending(e => e.Value))
//                {
//                    var evolutionType = evolutions.Key;
//var evolutionIndex = evolutions.Value;
//Console.WriteLine($"{evolutionType} <-> {evolutionIndex}");
//                }
//            }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dafuq
{
    public class dafuq
    {
        public static void Main(string[] args)
        {

            var input = Console.ReadLine();
            //var list = new SortedList<int, string>();
            var dictionary = new Dictionary<string, new List<Dictionary<string, List<int>>>();

            while (input != "wubbalubbadubdub")
            {
                if (input.Split().Length == 1)
                {
                    if (dictionary.ContainsKey(input))
                    {
                        var pokemonName = input;
                        var pokemon = dictionary[input];
                        Console.WriteLine($"# {pokemonName}");
                        foreach (var evo in pokemon)
                        {
                            var evolutionType = evo.Key;
                            foreach (var evolutionIndex in evo.Value)
                            {
                                Console.WriteLine($"{evolutionType} <-> {evolutionIndex}");
                            }
                        }
                    }
                }
                else
                {
                    var inputTokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                    var pokemonName = inputTokens[0];
                    var evolutionType = inputTokens[1];
                    var evolutionIndex = int.Parse(inputTokens[2]);

                    if (!dictionary.ContainsKey(pokemonName))
                    {
                        dictionary.Add(pokemonName, new Dictionary<string, List<int>>());
                        //[pokemonName].Add(new Dictionary<string, int>() { { evolutionType, evolutionIndex } });
                    }
                    if (!dictionary[pokemonName].ContainsKey(evolutionType))
                    {
                        dictionary[pokemonName].Add(evolutionType, new List<int>());
                    }
                    dictionary[pokemonName][evolutionType].Add(evolutionIndex);
                }

                input = Console.ReadLine();
            }

            foreach (var pokemon in dictionary)
            {
                var pokemonName = pokemon.Key;
                Console.WriteLine($"# {pokemonName}");

                foreach (var evolutions in pokemon.Value)
                {
                    var evolutionType = evolutions.Key;
                    foreach (var evolutionIndex in evolutions.Value.OrderBy(x => x))
                    {

                        Console.WriteLine($"{evolutionType} <-> {evolutionIndex}");
                    }
                }
            }
        }
    }
}

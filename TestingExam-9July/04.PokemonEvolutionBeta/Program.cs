using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PokemonEvolutionBeta
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            //var list = new SortedList<int, string>();
            var dictionary = new Dictionary<string, SortedList<int, string>>();
            var dictionaryK = new Dictionary<string, List<Dictionary<string, int>>>();

            while (input != "wubbalubbadubdub")
            {
                if (input.Split().Length == 1)
                {
                    if (dictionaryK.ContainsKey(input))
                    {
                        var pokemonName = input;
                        var pokemon = dictionaryK[input];
                        Console.WriteLine($"# {pokemonName}");
                        foreach (var evolutions in pokemon)
                        {
                            foreach (var evo in evolutions)
                            {

                                var evolutionType = evo.Value;
                                var evolutionIndex = evo.Key;
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
                        dictionary.Add(pokemonName, new SortedList<int, string>());
                        //[pokemonName].Add(new Dictionary<string, int>() { { evolutionType, evolutionIndex } });
                    }
                    dictionary[pokemonName].Add(evolutionIndex, evolutionType);
                    if (!dictionaryK.ContainsKey(pokemonName))
                    {
                        dictionaryK.Add(pokemonName, new List<Dictionary<string, int>>());
                        
                    }

                    dictionaryK[pokemonName].Add(new Dictionary<string, int>() { { evolutionType, evolutionIndex } });

                }

                input = Console.ReadLine();
            }

            foreach (var pokemon in dictionary)
            {
                var pokemonName = pokemon.Key;
                Console.WriteLine($"# {pokemonName}");
                var listOfEvolutions = pokemon.Value;
                foreach (var evolutions in listOfEvolutions.OrderByDescending(e => e.Key))
                {
                    var evolutionType = evolutions.Value;
                    var evolutionIndex = evolutions.Key;
                    Console.WriteLine($"{evolutionType} <-> {evolutionIndex}");
                }
            }
        }
    }
}

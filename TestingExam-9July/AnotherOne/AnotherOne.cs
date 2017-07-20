using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherOne
{
    class AnotherOne
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var dictionaryOfPokemons = new Dictionary<string, List<string>>();
            var dictionaryOfEvolutions = new Dictionary<string, List<int>>();

            //var counter = 0;

            while (input != "wubbalubbadubdub")
            {
                if (input.Split().Length == 1)
                {
                    if (dictionaryOfPokemons.ContainsKey(input))
                    {
                        var pokemonName = input;
                        var pokemon = dictionaryOfPokemons[input];
                        Console.WriteLine($"# {pokemonName}");
                        foreach (var evolution in pokemon)
                        {
                            var evolutionType = evolution;
                            foreach (var index in dictionaryOfEvolutions[evolution])
                            {
                                var evolutionIndex = index;
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

                    if (!dictionaryOfPokemons.ContainsKey(pokemonName))
                    {
                        dictionaryOfPokemons.Add(pokemonName, new List<string>() { evolutionType });
                        dictionaryOfEvolutions.Add(evolutionType, new List<int>() { evolutionIndex });
                    }
                    else if ()
                    {

                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}

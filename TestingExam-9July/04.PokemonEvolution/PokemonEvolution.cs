namespace _04.PokemonEvolution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PokemonEvolution
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var dictionary = new Dictionary<string, Dictionary<string, int>>();

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
                            var evolutionIndex = evo.Value;
                            Console.WriteLine($"{evolutionType} <-> {evolutionIndex}");
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
                        dictionary.Add(pokemonName, new Dictionary<string, int>() { { evolutionType, evolutionIndex } });
                        //[pokemonName].Add(new Dictionary<string, int>() { { evolutionType, evolutionIndex } });
                    }
                    else
                    {
                        dictionary[pokemonName].Add(evolutionType, evolutionIndex);
                    }

                }

                input = Console.ReadLine();
            }

            foreach (var pokemon in dictionary)
            {
                var pokemonName = pokemon.Key;
                Console.WriteLine($"# {pokemonName}");
                foreach (var evolutions in pokemon.Value.OrderByDescending(e => e.Value))
                {
                    var evolutionType = evolutions.Key;
                    var evolutionIndex = evolutions.Value;
                    Console.WriteLine($"{evolutionType} <-> {evolutionIndex}");
                }
            }
        }
    }
}

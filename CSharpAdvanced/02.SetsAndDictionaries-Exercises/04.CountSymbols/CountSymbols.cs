namespace _04.CountSymbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountSymbols
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            var dictionary = new SortedDictionary<char, int>();

            foreach (var symbol in input)
            {
                if (!dictionary.ContainsKey(symbol))
                {
                    dictionary[symbol] = 1;
                }
                else
                {
                    dictionary[symbol]++;
                }
            }

            foreach (var item in dictionary)
            {
                var symbol = item.Key;
                var count = item.Value;
                Console.WriteLine($"{symbol}: {count} time/s");
            }

        }
    }
}

namespace _04.SpecialWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SpecialWords
    {
        public static void Main()
        {
            var speacialWords = Console.ReadLine().Split().ToArray();

            var dictionary = new Dictionary<string, int>();

            foreach (var speacialWord in speacialWords)
            {
                dictionary[speacialWord] = 0;
            }
            
            var text = Console.ReadLine().Split();

            foreach (var word in text)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
            }

            foreach (var speacialWord in dictionary)
            {
                var word = speacialWord.Key;
                var occurence = speacialWord.Value;

                Console.WriteLine($"{word} - {occurence}");
            }
        }
    }
}

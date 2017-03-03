using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class RandomiseWords
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(' ');
            //Random rnd = new Random();
            var rnd = new Random();
           // var result = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var randomIndex = rnd.Next(0, words.Length);

                var tempWord = words[randomIndex];
                words[i] = tempWord;
                words[randomIndex] = currentWord;
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}

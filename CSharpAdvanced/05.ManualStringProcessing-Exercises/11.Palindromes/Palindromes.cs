namespace _11.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Palindromes
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToArray();

            var palindromes = new List<string>();

            foreach (var word in text)
            {
                var isPalindrom = true;

                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] != word[word.Length - 1 - i])
                    {
                        isPalindrom = false;
                    }
                }

                if (isPalindrom)
                {
                    palindromes.Add(word);
                }
            }

            palindromes.Sort();

            Console.WriteLine($"[{string.Join(", ",palindromes)}]");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            var separators = new char[]
            {
                ',',';', ':' ,'.' ,'!','(', ')' ,'"', '\'', '\\', '/', '[', ']', ' '
            };
            var text = Console.ReadLine()
                .Split(separators,StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var lowerCaseWords = new List<string>();
            var upperCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();
            foreach (var word in text)
            {
                if (word[0] >= 'a' && word[0] <= 'z')
                {
                    bool isMixedCase = false;
                    for (int i = 1; i < word.Length; i++)
                    {
                        if (word[i] < 'a' || word[i] > 'z')
                        {
                            isMixedCase = true;
                        }
                    }
                    if (isMixedCase)
                    {
                        mixedCaseWords.Add(word);
                    }
                    else
                    {
                        lowerCaseWords.Add(word);
                    }
                }
               else if (word[0] >= 'A' && word[0] <= 'Z')
                {
                    bool isMixedCase = false;
                    for (int i = 1; i < word.Length; i++)
                    {
                        if (word[i] < 'A' || word[i] > 'Z')
                        {
                            isMixedCase = true;
                        }
                    }
                    if (isMixedCase)
                    {
                        mixedCaseWords.Add(word);
                    }
                    else
                    {
                        upperCaseWords.Add(word);
                    }
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseWords));

            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseWords));

            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseWords));
        }
    }
}

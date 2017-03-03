namespace CountSubstringOccurence_Kenov
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine().ToLower();
            var text = Console.ReadLine().ToLower();
            var index = 0;
            var count = 0;
            while (true)
            {
                var found = text.IndexOf(bannedWords, index);
                if (found >= 0)
                {
                    count++;
                    index = found + 1;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}

namespace _03.TextFilter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TextFilter
    {
        public static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();
            foreach (var word in bannedWords)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(
                    word, new string('*', word.Length));
                }
           //text = text.Replace(word,new string('*',word.Length)); - it can be done without the if case
           // and it works faster
            }
            Console.WriteLine(text);
           }
    }
}

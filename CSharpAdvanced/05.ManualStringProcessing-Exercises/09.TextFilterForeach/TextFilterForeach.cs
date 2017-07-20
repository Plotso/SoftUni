namespace _09.TextFilterForeach
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TextFilterForeach
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries );
            var text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}

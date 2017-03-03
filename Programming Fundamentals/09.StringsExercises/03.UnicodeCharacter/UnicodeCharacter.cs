namespace _03.UnicodeCharacter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UnicodeCharacter
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            foreach (var chr in input)
            {
                Console.Write("\\u{0:x4}", (int)chr);
            }

            Console.WriteLine();
        }
    }
}

﻿namespace _03.TextFilterWithFor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TextFilterWithFor
    {
        public static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine()
                .Split(new[] { ", " },StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();
            for (int i = 0; i < bannedWords.Length; i++)
            {
                text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
            }
            Console.WriteLine(text);
        }
    }
}

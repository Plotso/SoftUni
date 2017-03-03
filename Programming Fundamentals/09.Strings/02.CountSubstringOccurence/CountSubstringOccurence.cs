namespace _02.CountSubstringOccurence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountSubstringOccurence
    {
        public static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var searchString = Console.ReadLine().ToLower();
            var count = 0;
            var index = text.IndexOf(searchString);
            while (index != -1)
            {
                count++;
                index = text.IndexOf(searchString, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}

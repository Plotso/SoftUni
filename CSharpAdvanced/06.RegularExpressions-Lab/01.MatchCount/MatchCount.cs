namespace _01.MatchCount
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchCount
    {
        public static void Main()
        {
            var pattern/*regex*/ = Console.ReadLine();
            var input = Console.ReadLine();

            var regex = new Regex(pattern);
            MatchCollection match = regex.Matches(input);

            Console.WriteLine($"{ match.Count}");
        }
    }
}

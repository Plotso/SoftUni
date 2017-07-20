namespace _02.VowelCount
{
    using System;
    using System.Text.RegularExpressions;

    public class VowelCount
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var regex = new Regex(@"[AEIOUYaeiouy]");

            MatchCollection match = regex.Matches(input);

            Console.WriteLine($"Vowels: {match.Count}");
        }
    }
}

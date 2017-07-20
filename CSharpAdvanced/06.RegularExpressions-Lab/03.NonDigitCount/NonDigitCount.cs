namespace _03.NonDigitCount
{
    using System;
    using System.Text.RegularExpressions;

    public class NonDigitCount
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            Regex regex = new Regex(@"[^\d]"); //[^0-9]  [^0123456789] \D
            MatchCollection match = regex.Matches(input);

            Console.WriteLine($"Non-digits: {match.Count}");
        }
    }
}

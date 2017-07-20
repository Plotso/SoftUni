namespace _08.ExtractQuotations
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;

    public class ExtractQuotations
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            Regex regex = new Regex("('|\")(.+?)\\1");
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                var value = match.Groups[2].Value;
                Console.WriteLine(value);
            }
        }
    }
}

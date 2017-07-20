namespace _03.SeriesOfLetters
{
    using System;
    using System.Text.RegularExpressions;

    public class SeriesOfLetters
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();
            var pattern = "([A-Za-z])\\1+";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(inputString);
            string result = string.Empty;
            foreach (Match match in matches)
            {
                var replace = match.Groups[1].Value;
                result = Regex.Replace(inputString, pattern, replace);
                Console.WriteLine(result);
            }

            Console.WriteLine(result);
        }
    }
}

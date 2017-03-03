namespace _01.ExtractEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class ExtractEmails
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"[A-Za-z0-9](\.|-|_|[A-Za-z0-9])+[A-Za-z0-9]@[A-Za-z]+(\.|-)?[A-Za-z]+\.?\w+";
            Regex regex = new Regex(pattern);
            var matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}

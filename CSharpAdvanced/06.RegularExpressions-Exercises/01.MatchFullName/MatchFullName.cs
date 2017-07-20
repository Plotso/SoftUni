namespace _01.MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchFullName
    {
        public static void Main()
        {
            var names = Console.ReadLine();
            Regex regex = new Regex(@"[A-Z][a-z]+ [A-Z][a-z]+");

            while (names != "end")
            {

                MatchCollection matches = regex.Matches(names);

                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }

                names = Console.ReadLine();
            }

        }
    }
}

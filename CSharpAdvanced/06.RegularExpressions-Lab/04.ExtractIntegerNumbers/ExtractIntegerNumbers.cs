namespace _04.ExtractIntegerNumbers
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractIntegerNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            Regex regex = new Regex(@"[\d]+");
            MatchCollection match = regex.Matches(input);

            foreach (var number in match)
            {
                Console.WriteLine(number);
            }
        }
    }
}

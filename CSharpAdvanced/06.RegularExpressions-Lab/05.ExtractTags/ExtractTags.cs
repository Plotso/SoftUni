namespace _05.ExtractTags
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractTags
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            Regex regex = new Regex(@"<.+?>"); // <.*?>
           

            while (input != "END")
            {
                 MatchCollection matches = regex.Matches(input);

                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }

                input = Console.ReadLine();
            }

            
        }
    }
}

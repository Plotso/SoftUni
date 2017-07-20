namespace _06.ValidUsernames
{
    using System;
    using System.Text.RegularExpressions;

    public class ValidUsernames
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"^[\w-]{3,16}$");

            while (input != "END")
            {
                MatchCollection matches = regex.Matches(input);

                if (matches.Count > 0)  
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                input = Console.ReadLine();
            }
        }
    }
}

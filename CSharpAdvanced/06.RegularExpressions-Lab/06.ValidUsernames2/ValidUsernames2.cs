namespace _06.ValidUsernames2
{
    using System;
    using System.Text.RegularExpressions;

    public class ValidUsernames2
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            Regex regex = new Regex(@"^[\w-]{3,16}$");

            while (input != "END")
            {
                Match match = regex.Match(input);

                if (match.Success)
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

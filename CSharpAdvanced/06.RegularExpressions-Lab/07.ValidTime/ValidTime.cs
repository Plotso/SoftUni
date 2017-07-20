namespace _07.ValidTime
{
    using System;
    using System.Text.RegularExpressions;

    public class ValidTime
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            Regex regex = new Regex(@"([01][0-9]):([0-5][0-9]):([0-5][0-9]) (A|P)M");

            while (input != "END")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    if (IsValidTime(match/*.ToString())*/))
                    {
                        Console.WriteLine("valid");
                    }
                    else
                    {
                        Console.WriteLine("ivalid");
                    }
                }
                else
                {
                    Console.WriteLine("invalid");
                }
                input = Console.ReadLine();
            }
        }

        private static bool IsValidTime(Match clock)
        {
            var hours = int.Parse(clock.Groups[1].Value);
            var mins = int.Parse(clock.Groups[2].Value);
            var secs = int.Parse(clock.Groups[3].Value);

            if (hours >= 0 && hours < 13)
            {
                if (mins >= 0 && mins < 60)
                {
                    if (secs >= 0 && secs < 60)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

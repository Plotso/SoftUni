namespace _02.MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchPhoneNumber
    {
        public static void Main()
        {
            var phoneNumber = Console.ReadLine();
            Regex regex = new Regex(@"\+359(\s|-)2\1[\d+]{3}\1[\d+]{4}\b");

            while (phoneNumber != "end")
            {
                MatchCollection matches = regex.Matches(phoneNumber);

                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }

                phoneNumber = Console.ReadLine();
            }
        }
    }
}

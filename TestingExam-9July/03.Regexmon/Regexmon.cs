namespace _03.Regexmon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Regexmon
    {
        public static void Main(string[] args)
        {
            var BojomonsPattern = @"[A-Za-z]+-[A-Za-z]+";
            var DidimonsPattern = @"[^A-Za-z-]+";

            var BojoRegex = new Regex(BojomonsPattern);
            var DidiRegex = new Regex(DidimonsPattern);

            var input = Console.ReadLine();
            var length = input.Length;
            var i = 1;

            var keepOnGoing = true;
            while(keepOnGoing)
            {
                if (i % 2 != 0)
                {
                    Match match = DidiRegex.Match(input);
                    if (match.Success)
                    {
                        Console.WriteLine(match);
                        var toCharArray = match.ToString().ToCharArray();
                        var firstChar = toCharArray[0];
                        var index = input.IndexOf(firstChar) + match.Length - 1;
                        input = input.Remove(0, index + 1);
                        //input = input.Remove(0, match.Length);
                        i++;
                    }
                    else
                    {
                         keepOnGoing = false;
                    }
                }
                else
                {
                    Match match = BojoRegex.Match(input);
                    if (match.Success)
                    {
                        Console.WriteLine(match);
                        var toCharArray = match.ToString().ToCharArray();
                        var firstChar = toCharArray[0];
                        var index = input.IndexOf(firstChar) + match.Length - 1;
                        input = input.Remove(0, index + 1);
                        //input = input.Remove(0, match.Length);
                        i++;
                    }
                    else
                    {
                        keepOnGoing = false;
                    }
                }
            }
        }
    }
}

namespace _01.Regeh
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Regeh
    {
        public static void Main()
        {
            Regex regex = new Regex(@"\[[^\s||^\[]+<[\d]+REGEH[\d]+>[^\s]+\]");

            var input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);

            Regex secondRegex = new Regex(@"<(\d+)REGEH(\d+)>");

            var indexes = new List<int>();

            foreach (Match match in matches)
            {
                var extractedSubstring = match.ToString();
                MatchCollection newMatches = secondRegex.Matches(extractedSubstring);
                foreach (Match newMatch in newMatches)
                {
                    var firstIndex = int.Parse(newMatch.Groups[1].Value);
                    var secondIndex = int.Parse(newMatch.Groups[2].Value);
                    indexes.Add(firstIndex);
                    indexes.Add(secondIndex);
                }
            }

            var indexesAsTheyShouldBe = new List<int>();
            var indexMaybe = 0;
            foreach (var index in indexes)
            {
                indexMaybe += index;
                indexesAsTheyShouldBe.Add(indexMaybe);
            }
            //var charList = new List<char>();
            var sb = new StringBuilder();
            foreach (var index in indexesAsTheyShouldBe)
            {
                var inputTOCharArray = input.Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries).ToString().ToCharArray();
                var num = index;
                if (num > input.Length - 1)
                {
                    while (num > input.Length - 1)
                    {
                        num -= input.Length - 1;
                    }
                    //charList.Add(input[num]);
                    sb.Append(input[num]);
                }
                else
                {
                    //charList.Add(input[num]);
                    sb.Append(input[num]);
                }
            }

            Console.WriteLine(sb.ToString());

        }
    }
}

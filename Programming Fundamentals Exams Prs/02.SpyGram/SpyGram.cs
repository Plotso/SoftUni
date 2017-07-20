namespace _02.SpyGram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class SpyGram
    {
        public static void Main()
        {
            var privateKey = Console.ReadLine().ToCharArray();
            var input = Console.ReadLine();

            var regex = new Regex(@"TO: ([A-Z]+); MESSAGE: (.+);");
            var nums = new Queue<int>();
            //var encryptedMsgs = new List<string>();

            foreach (var character in privateKey)
            {
                nums.Enqueue(int.Parse(character.ToString()));
            }

            var resultDict = new Dictionary<string,string>();

            while (input != "END")
            {
                var numsQueue = new Queue<int>();

                foreach (var num in nums)
                {
                    numsQueue.Enqueue(num);
                }
                var matchesS = regex.Matches(input);
                var someone = string.Empty;
                foreach (Match matches in matchesS)
                {
                    someone = matches.Groups[1].Value;
                    var mas = matches.ToString();
                    var charArray = mas.ToCharArray();
                    var sb = new StringBuilder();
                    foreach (var character in charArray)
                    {
                        var c = character;
                        var numberNow = numsQueue.Dequeue();
                        for (int i = 0; i < numberNow; i++)
                        {
                            c++;
                        }
                        sb.Append(c);
                        numsQueue.Enqueue(numberNow);
                    }
                    //encryptedMsgs.Add(sb.ToString());
                    resultDict.Add(someone, sb.ToString());
                }

                input = Console.ReadLine();
            }
            foreach (var msg in resultDict.OrderBy(x => x.Key))
            {
                var message = msg.Value;
                Console.WriteLine(message);
            }
        }
    }
}

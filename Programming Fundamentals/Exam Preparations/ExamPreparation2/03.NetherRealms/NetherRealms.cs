namespace _03.NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    public class NetherRealms
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ", "},StringSplitOptions.RemoveEmptyEntries);
            var wordsRegex = new Regex(@"[A-Za-z]");//[^+\-*\/\.\d]
            var digitsRegex = new Regex(@"[-+]?([0-9]*\.[0-9]+|[0-9]+)");
            var astericsRegex = new Regex(@"\*");
            var slashRegex = new Regex(@"\/");
            var demonDictionary = new SortedDictionary<string, Dictionary<int, double>>();
            
            //var listOfAsterics = new List<string>();
            //var listOfSlashesh = new List<string>();

            foreach (var name in input)
            {
                demonDictionary.Add(name, new Dictionary<int, double>());

                var wordsMatch = wordsRegex.Matches(name);
                var digitsMatch = digitsRegex.Matches(name);
                var astericsMatch = astericsRegex.Matches(name);
                var slashesMatch = slashRegex.Matches(name);
                var wordsSum = 0;
                var digitsSum = 0.0;
                var astericsCount = 0;
                var slasheshCount = 0;
                
                var listOfLetters = new List<string>();
                var listOfDigits = new List<string>();
                //var health = wordsSum;
                var damage = 0.0;
                foreach (Match wordMatch in wordsMatch)
                {
                   
                    listOfLetters.Add(wordMatch.ToString());
                }
                foreach (Match digitMatch in digitsMatch)
                {
                    listOfDigits.Add(digitMatch.ToString());
                }
                foreach (Match astericMatch in astericsMatch)
                {
                    astericsCount++;

                }
                foreach (Match slashMatch in slashesMatch)
                {
                    slasheshCount++;
                }
                foreach (var letter in listOfLetters)
                {
                    wordsSum += letter[0];
                }
                var health = wordsSum;
                var HPD = new Dictionary<int, double>();
                HPD.Add(health, 0.0);
                demonDictionary[name] = HPD;
                foreach (var digit in listOfDigits)
                {
                    digitsSum += double.Parse(digit);
                }
                if (astericsCount != 0 && slasheshCount != 0)
                {
                    damage = digitsSum * (astericsCount * 2) / (slasheshCount * 2);
                }
                else if (astericsCount != 0 && slasheshCount == 0)
                {
                    damage = digitsSum * (astericsCount * 2);
                }
                else if (astericsCount == 0 && slasheshCount != 0)
                {
                    damage = digitsSum / (slasheshCount * 2);
                }
                else
                {
                    damage = digitsSum;
                }
                
                HPD[health] = damage;
                demonDictionary[name] = HPD;
                //demonDictionary[name][health] = damage;
            }
            foreach (var demon in demonDictionary)
            {
                var name = demon.Key;
                var stats = demon.Value;
                //Console.WriteLine($"{name} - {stats.Keys} health, {stats.Values:F2} damage");
                foreach (var stat in stats)
                {
                    Console.WriteLine($"{name} - {stat.Key} health, {stat.Value:F2} damage");
                }
            }
            
        }
    }
}

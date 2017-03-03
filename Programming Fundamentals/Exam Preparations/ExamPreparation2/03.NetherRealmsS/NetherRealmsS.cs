namespace _03.NetherRealmsS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class NetherRealmsS
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var wordsRegex = new Regex(@"[^+\-*\/\.\d]");
            var digitsRegex = new Regex(@"[-+]?([0-9]*\.[0-9]+|[0-9]+)");
            var slashasterixRegex = new Regex(@"(\/|\*)");

            var demonDictionary = new SortedDictionary<string, Dictionary<long, double>>();

            foreach (var name in names)
            {
                demonDictionary.Add(name, new Dictionary<long, double>());

                var wordMatches = wordsRegex.Matches(name);
                var digitsMatches = digitsRegex.Matches(name);
                var slashasterixMatches = slashasterixRegex.Matches(name);

                var asterixCount = 0;
                var slashCount = 0;

                var wordsList = new List<string>();
                var digitsList = new List<string>();

                foreach (var wordMatch in wordMatches)
                {
                    wordsList.Add(wordMatch.ToString());
                }
                foreach (var digitsMatch in digitsMatches)
                {
                    digitsList.Add(digitsMatch.ToString());
                }

                var health = 0L;//wordsCount

                foreach (var item in wordsList)
                {
                    health += item[0];
                }

                var healthDamage = new Dictionary<long, double>();
                healthDamage.Add(health, 0.0);

                demonDictionary[name] = healthDamage;

                var damage = 0.0;//digitsSum

                foreach (var item in digitsList)
                {
                    damage += Convert.ToDouble(item);
                }

                if (asterixCount != 0 && slashCount != 0)
                {
                    damage = (damage * asterixCount *  2) / (slashCount * 2);
                }
                else if (asterixCount != 0 && slashCount == 0)
                {
                    damage = damage * asterixCount *  2;
                }
                else if (asterixCount == 0 && slashCount != 0)
                {
                    damage = damage / (slashCount * 2);
                }

                foreach (var slashasterixMatch in slashasterixMatches)
                {
                    if (slashasterixMatch.ToString() == "/")
                    {
                        damage /= 2;
                    }
                    else
                    {
                        damage *= 2;
                    }
                }

                healthDamage[health] = damage;
                demonDictionary[name] = healthDamage;

            }

            foreach (var name in demonDictionary)
            {
                Console.Write($"{name.Key} - ");

                foreach (var item in name.Value)
                {
                    Console.Write($"{item.Key} health, ");
                    Console.Write($"{item.Value:f2} damage");
                    Console.WriteLine();
                }
            }

        }
    }
}

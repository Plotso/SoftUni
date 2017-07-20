namespace _08.HandsOfCardsLectorEdition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HandsOfCardsLectorEdition
    {
        public static void Main()
        {
            var players = new Dictionary<string, HashSet<string>>();
            var handout = Console.ReadLine();

            while (handout != "JOKER")
            {
                var handoutTokens = handout
                    .Split(':');
                var playersName = handoutTokens[0];
                var cards = handoutTokens[1]
                    .Split(',')
                    .Select(a => a.Trim())
                    .ToArray();

                if (players.ContainsKey(playersName))
                {
                    players[playersName].UnionWith(cards);
                }
                else
                {
                    players[playersName] = new HashSet<string>(cards);
                }

                handout = Console.ReadLine();
            }

            PrintPlayersAndScores(players);
        }

        private static void PrintPlayersAndScores(Dictionary<string, HashSet<string>> players)
        {
            foreach (var player in players)
            {
                var score = CalculateScore(player.Value);
                Console.WriteLine($"{player.Key}: {score}");
            }
        }

        private static object CalculateScore(HashSet<string> cards)
        {
            var totalScore = 0;
            foreach (var card in cards)
            {
                var type = card.Last();
                var power = card.Substring(0, card.Length - 1);

                int score;
                var isDigit = int.TryParse(power, out score);

                if (!isDigit)
                {
                    switch (power)
                    {
                        case "J":
                            score = 11;
                            break;
                        case "Q":
                            score = 12;
                            break;
                        case "K":
                            score = 13;
                            break;
                        case "A":
                            score = 14;
                            break;
                    }
                    
                }
                switch (type)
                {
                    case 'S':
                        score *= 4;
                        break;
                    case 'H':
                        score *= 3;
                        break;
                    case 'D':
                        score *= 2;
                        break;
                    case 'C':
                        score *= 1;
                        break;
                }
                totalScore += score;
            }
            return totalScore;
        }
    }
}

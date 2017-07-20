namespace _04.ChampionsLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ChampionsLeague
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            //var dictionary = new Dictionary<Dictionary<string, int>/*int*/, SortedDictionary<string,string>>();
            var teamAndOponents = new Dictionary<string, List<string>>(); //List<string>
            var teamAndWins = new Dictionary<string, int>();
            while (input != "stop")
            {

                var inputTokens = input.Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                var teamOne = inputTokens[0].Trim();
                var teamTwo = inputTokens[1].Trim();
                var goalsFirstGame = inputTokens[2].Split(':')      //.Split(new[] {":"},StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                
                var goalsSecondGame = inputTokens[3].ToString().Split(':').Select(int.Parse).ToArray();
                
                var winner = FindWinner(teamOne, teamTwo, goalsFirstGame, goalsSecondGame);
                
                if (teamOne == winner)
                {
                    if (!teamAndWins.ContainsKey(teamOne))
                    {
                        teamAndWins.Add(teamOne, 1);
                    }
                    else
                    {
                        teamAndWins[teamOne]++;
                    }
                    if (!teamAndWins.ContainsKey(teamTwo))
                    {
                        teamAndWins.Add(teamTwo, 0);
                    }
                    // -> 
                    if (!teamAndOponents.ContainsKey(teamOne))
                    {
                        teamAndOponents.Add(teamOne, new List<string> { teamTwo });
                    }
                    else
                    {
                        teamAndOponents[teamOne].Add(teamTwo);
                    }
                    if (!teamAndOponents.ContainsKey(teamTwo))
                    {
                        teamAndOponents.Add(teamTwo, new List<string> { teamOne });
                    }
                    else
                    {
                        teamAndOponents[teamTwo].Add(teamOne);
                    }
                }
                else if (teamTwo == winner)
                {
                    
                    if (!teamAndWins.ContainsKey(teamTwo))
                    {
                        teamAndWins.Add(teamTwo, 1);
                    }
                    else
                    {
                        teamAndWins[teamTwo]++;
                    }
                    if (!teamAndWins.ContainsKey(teamOne))
                    {
                        teamAndWins.Add(teamOne, 0);
                    }

                    //-> 

                    if (!teamAndOponents.ContainsKey(teamOne))
                    {
                        teamAndOponents.Add(teamOne, new List<string> { teamTwo });
                    }
                    else
                    {
                        teamAndOponents[teamOne].Add(teamTwo);
                    }
                    if (!teamAndOponents.ContainsKey(teamTwo))
                    {
                        teamAndOponents.Add(teamTwo, new List<string> { teamOne });
                    }
                    else
                    {
                        teamAndOponents[teamTwo].Add(teamOne);
                    }
                }
                
                
                input = Console.ReadLine();
            }

            foreach (var team in teamAndWins.OrderByDescending(x => x.Value).ThenBy( x => x.Key))
            {
                Console.WriteLine(team.Key);
                Console.WriteLine($"- Wins: {team.Value}");
                Console.WriteLine("- Opponents: {0}", string.Join(", ", teamAndOponents[team.Key].OrderBy(x => x)));
            }
        }

        private static string FindWinner(string teamOne, string teamTwo, int[] goalsFirstGame, int[] goalsSecondGame)
        {
            var firstGameTeam1Goals = goalsFirstGame[0];
            var firstGameTeam2Goals = goalsFirstGame[1];

            var secondGameTeam2Goals = goalsSecondGame[0];
            var secondGameTeam1Goals = goalsSecondGame[1];

            var firstTeamGoals = firstGameTeam1Goals + secondGameTeam1Goals;
            var secondTeamGoals = firstGameTeam2Goals + secondGameTeam2Goals;

            if (firstTeamGoals == secondTeamGoals)
            {
                return firstGameTeam2Goals < secondGameTeam1Goals ? teamOne : teamTwo;
            }

            return firstTeamGoals > secondTeamGoals ? teamOne : teamTwo;
        }
    }
}

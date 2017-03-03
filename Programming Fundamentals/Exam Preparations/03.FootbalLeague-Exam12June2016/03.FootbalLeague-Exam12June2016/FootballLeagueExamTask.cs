namespace _03.FootbalLeague_Exam12June2016
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
  
    public class FootballLeagueExamTask
    {
        public static void Main()
        {
            var key = Console.ReadLine();
            var encryptedInput = Console.ReadLine().Split();
            var leagueStanding = new SortedDictionary<string, int>();
            var topScoringTeams = new SortedDictionary<string, int>();
            var encryptedTeams = new string[2];
            var encryptedScore = new int[2];
            while (encryptedInput[0].ToLower() != "final")
            {
                var matchScore = new SortedDictionary<string, int>();
                encryptedScore = encryptedInput[2].Split(':').Select(int.Parse).ToArray();
            }

        }
    }
}

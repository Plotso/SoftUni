namespace _09.UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UserLogs
    {
        public static void Main()
        {
            var users = new SortedDictionary<string, Dictionary<string, int>>();
            var line = Console.ReadLine();

            while (line != "end")
            {
                var messageTokens = line.Split();

                var ip = messageTokens[0].Replace("IP=", "");
                var username = messageTokens[2].Replace("user=", "");

                if (users.ContainsKey(username))
                {
                    if (users[username].ContainsKey(ip))
                    {
                        users[username][ip] += 1;
                    }
                    else
                    {
                        users[username][ip] = 1;
                    }
                }
                else
                {
                    users[username] = new Dictionary<string, int>() { { ip, 1 } };
                }

                line = Console.ReadLine();
            }

            PrintUsersAndIps(users);
        }

        private static void PrintUsersAndIps(SortedDictionary<string, Dictionary<string, int>> users)
        {
            foreach (var user in users)
            {
                var username = user.Key;
                Console.WriteLine($"{username}: ");
                Console.WriteLine("{0}.",
                    string.Join(", ", user.Value.Select(a => $"{a.Key} => {a.Value}"))) ;
            }
        }
    }
}

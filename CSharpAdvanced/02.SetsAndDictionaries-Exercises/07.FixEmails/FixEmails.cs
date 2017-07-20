namespace _07.FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FixEmails
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<string, string>();
            var prevName = string.Empty;
            while (input != "stop")
            {
                if (!input.Contains("@"))
                {
                    prevName = input;
                    dictionary[prevName] = "";
                }
                else
                {
                    if (input.EndsWith("uk") || input.EndsWith("us"))
                    {
                        dictionary.Remove(prevName);
                    }
                    else
                    {
                        dictionary[prevName] = input;
                    }
                    
                }
                input = Console.ReadLine();
            }

            foreach (var person in dictionary)
            {
                var name = person.Key;
                var email = person.Value;

                Console.WriteLine($"{name} -> {email}");
            }
        }
    }
}

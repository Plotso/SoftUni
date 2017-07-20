namespace _05.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Phonebook
    {
        public static void Main()
        {
            //not working!!!
            var input = Console.ReadLine().Split().ToArray();
            var phonebook = new Dictionary<string, string>();

            while (input[0] != "search")
            {
                if (input.Contains("-"))
                {
                    var name = input[0];
                    var number = input[2];

                    //if (!phonebook.ContainsKey(name))
                    //{
                    //    phonebook[name] = number;
                    //}
                    //else
                    //{
                    //    phonebook[name] = number;
                    //}
                    phonebook[name] = number;
                }

                input = Console.ReadLine().Split().ToArray();
            }
            while (input[0] != "stop")
            {
                input = Console.ReadLine().Split().ToArray();
                if (!phonebook.ContainsKey(input[0]) || input[0] != "stop")
                {
                    Console.WriteLine($"Contact {input[0]} does not exist.");
                }
                else
                {
                    //Console.WriteLine($"{input[0]} -> {phonebook[input[0]]}");
                    foreach (var person in phonebook)
                    {
                        var name = person.Key;
                        var phone = person.Value;

                        if (input[0] == name)
                        {
                            Console.WriteLine($"{name} -> {phone}");
                        }
                    }
                }

                
            }
        }
    }
}

namespace _01.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
   public class Phonebook
    {
        public static void Main()
        {
            var phonebook = new Dictionary<string, string>();
            

            for (int i = 0; i < int.MaxValue; i++)
            {
                var information = Console.ReadLine().Trim().Split(' ').ToList();
                //var name = information[1];
                //var number = information[2];
                if (information[0] == "END")
                {
                    break;
                }
                else if (information[0] == "A")
                {
                    phonebook[information[1]] = information[2];
                }
                else if (information[0] == "S" && phonebook.ContainsKey(information[1]))
                {
                    Console.WriteLine($"{information[1]} -> {phonebook[information[1]]}");
                }
                else
                {
                    Console.WriteLine($"Contact {information[1]} does not exist.");
                }
            }
        }
    }
}

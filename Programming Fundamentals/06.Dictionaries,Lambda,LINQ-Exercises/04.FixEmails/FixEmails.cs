namespace _04.FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class FixEmails
    {
        public static void Main()
        {
            var emails = new Dictionary<string, string>();

            string inputName = Console.ReadLine();

            while (inputName != "stop")
            {
                var inputMail = Console.ReadLine();

                string ending = inputMail.Substring(inputMail.Length - 2, 2).ToLower();
                if (ending != "uk" && ending != "us")
                {
                    emails.Add(inputName, inputMail);
                }

                inputName = Console.ReadLine();
            }

            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

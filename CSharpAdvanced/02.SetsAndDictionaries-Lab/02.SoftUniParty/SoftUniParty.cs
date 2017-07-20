namespace _02.SoftUniParty
{
    using System;
    using System.Collections.Generic;

    public class SoftUniParty
    {
        public static void Main()
        {
            var vip = new HashSet<string>();
            var regular = new SortedSet<string>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "PARTY")
                {
                    break;
                }
                if (IsVip(input))
                {
                    vip.Add(input);
                }
                else
                {
                    regular.Add(input);
                }
            }
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                if (IsVip(input))
                {
                    vip.Remove(input);
                }
                else
                {
                    regular.Remove(input);
                }
            }
            regular.UnionWith(vip);
            Console.WriteLine(regular.Count);
            foreach (var guest in regular)
            {
                Console.WriteLine(guest);
            }
        }

        public static bool IsVip(string input)
        {
            int number;
            var isDigit = int.TryParse(input[0].ToString(), out number);
            if (isDigit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

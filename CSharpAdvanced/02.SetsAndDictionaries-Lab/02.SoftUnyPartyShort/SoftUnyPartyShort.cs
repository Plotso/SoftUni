namespace _02.SoftUnyPartyShort
{
    using System;
    using System.Collections.Generic;

    public class SoftUnyPartyShort
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var invitedGuests = new SortedSet<string>();

            while (input != "PARTY")
            {
                invitedGuests.Add(input);

                input = Console.ReadLine();
            }

            while (input != "END")
            {
                invitedGuests.Remove(input);

                input = Console.ReadLine();
            }

            Console.WriteLine(invitedGuests.Count);

            foreach (var guest in invitedGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}

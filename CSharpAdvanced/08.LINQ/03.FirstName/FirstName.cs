namespace _03.FirstName
{
    using System;
    using System.Linq;

    public class FirstName
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split().ToArray();
            var letters = Console.ReadLine()
                .Split()
                .OrderBy(w => w);

            foreach (var letter in letters)
            {
                var result = names
                    .Where(w => w.ToLower().StartsWith(letter.ToLower()))
                    .FirstOrDefault();
                   //.FirstOrDefault(w => w.ToLower().StartsWith(letter.ToLower()));

                if (result != null)
                {
                    Console.WriteLine(result);
                    return;
                }
            }

            Console.WriteLine("No match");
        }
    }
}

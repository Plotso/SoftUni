namespace _06.FindAndSumIntegers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var numbers = input
                .Split()
                .Select(w =>
                {
                    long value;
                    bool success = long.TryParse(w, out value);
                    return new { value, success };
                })
                .Where(s => s.success)
                .Select(n => n.value)
                .ToList();

            if ( numbers.Count != 0)
            {
                var sum = numbers.Sum();
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No match");
            }

        }
    }
}

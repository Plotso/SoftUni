namespace _07.BoundedNumbers
{
    using System;
    using System.Linq;

    public class BoundedNumbers
    {
        public static void Main()
        {
            var bounds = Console.ReadLine().Split().Select(int.Parse).ToList();
            var lowerBound = bounds[0];
            var upperBound = bounds[1];
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(n => lowerBound <= n && n <= upperBound) // bounds.Min() <= n && n <= bounds.Max()
                .ToList();

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}

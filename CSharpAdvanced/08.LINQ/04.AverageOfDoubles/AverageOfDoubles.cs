namespace _04.AverageOfDoubles
{
    using System;
    using System.Linq;

    public class AverageOfDoubles
    {
        public static void Main()
        {
            var numbersAvg = Console.ReadLine().Split().Select(double.Parse).Average();
            Console.WriteLine($"{numbersAvg:f2}");
        }
    }
}

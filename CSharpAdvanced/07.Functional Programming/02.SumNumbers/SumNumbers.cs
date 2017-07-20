namespace _02.SumNumbers
{
    using System;
    using System.Linq;
    public class SumNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                   .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse);

            Console.WriteLine(input.Count());
            Console.WriteLine(input.Sum());
        }
    }
}

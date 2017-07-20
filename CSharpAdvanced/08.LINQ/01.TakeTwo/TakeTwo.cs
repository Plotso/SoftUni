namespace _01.TakeTwo
{
    using System;
    using System.Linq;

    public class TakeTwo
    {
        public static void Main()
        {
            //var numbers = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToList();

            //numbers.Where(n => 10 <= n && n <= 20)
            //    .Distinct()
            //    .Take(2)
            //    .ToList()
            //    .ForEach(n => Console.Write(n + " "));

            var numbers = Console.ReadLine();

            numbers.Split()
                .Select(int.Parse)
                .Where(n => 10 <= n && n <= 20)
                .Distinct()
                .ToList()
                .Take(2)
                .ToList()
                .ForEach(n => Console.Write(n + " "));
                
        }
    }
}

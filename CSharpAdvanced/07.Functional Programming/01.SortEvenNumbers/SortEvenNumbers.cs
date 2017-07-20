namespace _01.SortEvenNumbers
{
    using System;
    using System.Linq;

    public class SortEvenNumbers
    {
        public static void Main()
        {
            //var numbers = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(NumberParser)
            //    .Where(n => n % 2 == 0)
            //    .OrderBy(n => n)
            //    .ToList();

            //Console.WriteLine(string.Join(", ",numbers));

            Func<string, int> NumberParser = n => int.Parse(n); // it should be with lowercase first letter
            Console.WriteLine(string.Join(", ", Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(NumberParser)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToList()));
        }

        //public static int NumberParser(string n)
        //{
        //    return int.Parse(n);
        //}
        
    }
}

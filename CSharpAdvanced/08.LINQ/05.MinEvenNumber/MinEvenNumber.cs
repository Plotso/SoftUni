namespace _05.MinEvenNumber
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine($"{Console.ReadLine().Split().Select(double.Parse).Where(n => n % 2 == 0).Min():f2}");
            }
            catch (Exception e)
            {

                Console.WriteLine("No match");
            }
        }
    }
}

//var numbers = Console.ReadLine()
//    .Split()
//    .Select(double.Parse)
//    .Where(n => n % 2 == 0)
//    .ToList();

namespace _01.ReverseString
{
    using System;
    using System.Linq;

    public class ReverseString
    {
        public static void Main()
        {
            //var input = Console.ReadLine().Reverse();

            //Console.WriteLine(string.Join("", input));

            Console.WriteLine(string.Join("", Console.ReadLine().Reverse()));
        }
    }
}

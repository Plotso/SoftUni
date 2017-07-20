namespace _02.UpperStrings
{
    using System;
    using System.Linq;

    public class UpperStrings
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            input.Select(w => w.ToUpper()).ToList().ForEach(w => Console.Write(w + " "));

            //var inputAgain = Console.ReadLine().ToUpper();
            //Console.WriteLine(inputAgain);
        }
    }
}

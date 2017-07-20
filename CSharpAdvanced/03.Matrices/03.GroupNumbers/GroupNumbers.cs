namespace _03.GroupNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GroupNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var zero = numbers.Where(n => Math.Abs(n) % 3 == 0)/*.ToArray()*/;
            var one = numbers.Where(n => Math.Abs(n) % 3 == 1)/*.ToArray()*/;
            var two = numbers.Where(n => Math.Abs(n) % 3 == 2)/*.ToArray()*/;

            Console.WriteLine(string.Join(" ",zero));
            Console.WriteLine(string.Join(" ",one));
            Console.WriteLine(string.Join(" ",two));

            //var outputMatrice = new int[3][];

            //for (int i = 0; i < numbers.Length - 1; i++)
            //{
            //    var number = numbers[i];

            //    if (number % 3 == 0)
            //    {
            //        outputMatrice[0][0] = numbers[i];
            //    }
            //    else if (number % 3 == 1)
            //    {
            //        outputMatrice[0][1] = numbers[i];
            //    }
            //    else if (number % 3 == 2)
            //    {
            //        outputMatrice[0][2] = numbers[i];
            //    }
            //}

            //foreach (var row in outputMatrice)
            //{
            //    Console.WriteLine(string.Join(" ", row));
            //}

        }
    }
}

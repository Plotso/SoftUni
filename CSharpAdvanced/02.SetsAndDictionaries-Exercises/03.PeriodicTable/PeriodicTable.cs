namespace _03.PeriodicTable
{
    using System;
    using System.Collections.Generic;

    public class PeriodicTable
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var set = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                foreach (var element in input)
                {
                    set.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ",set));
        }
    }
}

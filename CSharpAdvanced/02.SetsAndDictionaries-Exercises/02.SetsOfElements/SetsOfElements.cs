namespace _02.SetsOfElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SetsOfElements
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = input[0];
            var m = input[1];

            var setN = new HashSet<int>();
            var setM = new HashSet<int>();
            var finalSet = new HashSet<int>();

            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                setN.Add(number);
            }
            for (int i = 1; i <= m; i++)
            {
                var number = int.Parse(Console.ReadLine());
                setM.Add(number);
            }
            //setN.UnionWith(setM);

            foreach (var num in setN)
            {
                foreach (var number in setM)
                {
                    if (num == number)
                    {
                        finalSet.Add(number);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", finalSet));
        }
    }
}

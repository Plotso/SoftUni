namespace _02.BasicStackOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicStackOperations
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = input[0];
            var s = input[1];
            var x = input[2];

            
            var numbers = Console.ReadLine().Split().Select(int.Parse);

            var stack = new Stack<int>(numbers);

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                stack.OrderBy(t => t);
                Console.WriteLine(stack.Pop());
            }
        }
    }
}

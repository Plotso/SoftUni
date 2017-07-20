namespace _01.ReverseNumbersWithaStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseNumbersWithaStack
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var stack = new Stack<int>(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(stack.Pop() + " ");
            }
        }
    }
}

namespace _04.MatchingBracketsWithStack
{
    using System;
    using System.Collections.Generic;

    public class MatchingBracketsWithStack
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                if (input[i] == ')')
                {
                    var startingIndex = stack.Pop();
                    var reminder = input.Substring(startingIndex, i - startingIndex + 1);
                    Console.WriteLine(reminder);
                }
            }
        }
    }
}

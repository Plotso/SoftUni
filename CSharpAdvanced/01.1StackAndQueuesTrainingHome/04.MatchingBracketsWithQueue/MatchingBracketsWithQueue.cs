namespace _04.MatchingBracketsWithQueue
{
    using System;
    using System.Collections.Generic;

    public class MatchingBracketsWithQueue
    {
        public static void Main()
        {
            // Gets only 60/100
            var input = Console.ReadLine();
            var queue = new Queue<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    queue.Enqueue(i);
                }
                if (input[i] == ')')
                {
                    var startingIndex = queue.Dequeue();
                    var reminder = input.Substring(startingIndex, i - startingIndex + 1);
                    Console.WriteLine(reminder);
                }
            }
        }
    }
}

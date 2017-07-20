namespace _03.MaximumElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaximumElements
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();
            var maxNumStack = new Stack<int>();
            var maxValue = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var query = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (query[0] == 1)
                {
                    stack.Push(query[1]);
                    if (maxValue < query[1])
                    {
                        maxValue = query[1];
                        maxNumStack.Push(maxValue);
                    }
                }
                else if (query[0] == 2)
                {
                    if (stack.Pop() == maxValue)
                    {
                        maxNumStack.Pop();
                        if (maxNumStack.Count() != 0) // maxNumStack.Any()
                        {
                            maxValue = maxNumStack.Peek();
                        }
                        else
                        {
                            maxValue = int.MinValue;
                        }
                    }
                }
                else if (query[0] == 3)
                {
                    Console.WriteLine(maxValue);
                }
            }
        }
    }
}

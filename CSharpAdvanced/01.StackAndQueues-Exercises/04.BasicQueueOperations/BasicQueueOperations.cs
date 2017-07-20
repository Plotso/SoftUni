namespace _04.BasicQueueOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicQueueOperations
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = input[0];
            var s = input[1];
            var x = input[2];

            var numbers = Console.ReadLine().Split().Select(int.Parse);
            var queue = new Queue<int>(numbers);

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                //queue.OrderBy(t => t);
                Console.WriteLine(queue.Min());
            }
        }
    }
}

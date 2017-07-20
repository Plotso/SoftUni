namespace _01.ReverseStringWithQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseStringWithQueue
    {
        public static void Main()
        {
            Console.WriteLine(string.Join("",Console.ReadLine().Reverse()));
            //var input = Console.ReadLine();
            //var queue = new Queue<char>(input);

            //for (int i = 1; i < input.Length; i++)
            //{
            //    queue.Enqueue(queue.Dequeue());
            //}
            //for (int i = 1; i < input.Length; i++)
            //{
            //    Console.Write(queue.Dequeue());
            //}
        }
    }
}

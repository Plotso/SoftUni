namespace _05.CalculateSequenceWithQueue
{
    using System;
    using System.Collections.Generic;

    public class CalculateSequenceWithQueue
    {
        public static void Main()
        {
            var start = long.Parse(Console.ReadLine());

            var elements = new Queue<long>();
            elements.Enqueue(start);

            var dequeueCount = 50;

            for (int i = 0; i < dequeueCount; i++)
            {
                var currentElement = elements.Dequeue();
                Console.Write(currentElement + " ");
                elements.Enqueue(currentElement + 1);
                elements.Enqueue(currentElement * 2 + 1);
                elements.Enqueue(currentElement + 2);
            }
        }
    }
}

﻿namespace _06.MathPotatoWithQueue
{
    using System;
    using System.Collections.Generic;

    public class MathPotatoWithQueue
    {
        public static void Main()
        {
            var children = Console.ReadLine().Split();
            var number = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(children);

            var cycle = 1;

            while (queue.Count != 1)
            {
                for (int i = 1; i < number; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                if (PrimeTool.isPrime(cycle))
                {
                    Console.WriteLine($"Prime {queue.Peek()}");
                }
                else
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }

                cycle++;
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
    public class PrimeTool
    {
        public static bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}

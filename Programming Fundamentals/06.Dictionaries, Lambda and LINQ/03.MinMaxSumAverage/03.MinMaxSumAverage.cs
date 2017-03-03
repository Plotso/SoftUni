using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.MinMaxSumAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var listNumbers = new List<int>();
            var sum = 0;
            var 
            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                listNumbers.Add(currentNumber);
            }
            Console.WriteLine("Sum = " + listNumbers.Sum());
            Console.WriteLine("Min = " + listNumbers.Min());
            Console.WriteLine("Max = " + listNumbers.Max());
            Console.WriteLine("Average = " + listNumbers.Average());
        }
    }
}

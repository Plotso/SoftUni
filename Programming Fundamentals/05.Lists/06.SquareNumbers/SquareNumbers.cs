using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            var listOfInteger = Console.ReadLine()
                .Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            var squareNumbers = new List<int>();
            foreach (var number in listOfInteger)
            {
                if (Math.Sqrt(number) % 1 == 0)
                {
                    squareNumbers.Add(number);
                }
            }
            //squareNumbers.OrderByDescending(n => n);
            squareNumbers.Sort();
            squareNumbers.Reverse();
            Console.WriteLine(string.Join(" ",squareNumbers));

        }
    }
}

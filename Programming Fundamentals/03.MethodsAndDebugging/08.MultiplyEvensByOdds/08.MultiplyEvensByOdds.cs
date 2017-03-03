using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());         
            Console.WriteLine(MultipleOfEvenAndOdds(n));
        }
        static int MultipleOfEvenAndOdds (int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdds = GetSumOfOddDigits(n);
            return Math.Abs(sumEvens * sumOdds);
        }
        static int GetSumOfEvenDigits (int n)
        {
            var sum = 0;
            foreach (var symbol in n.ToString()) // var digit in n.ToString())
            {
                var digit = symbol - '0';
                //var digit = n % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
            }
            return sum;
        }
        static int GetSumOfOddDigits (int n)
        {
            var sum = 0;
            foreach (var symbol in n.ToString()) // var digit in n.ToString())
            {
                var digit = symbol - '0';
                //var digit = n % 10;
                if (digit % 2 == 1)
                {
                    sum += digit;
                }
            }
            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            var roundedNumbers = numbers.Split(' ').Select(double.Parse).ToArray();

            foreach (var number in roundedNumbers)
            {
                int finalResult = (int)Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}",number,finalResult);
            }

            
        }
    }
}
//string[] arr = { "one", "two", "three", "four", "five" };
//            // Process all array elements
//            for (int index = 0; index<arr.Length; index++)
//            {
//                // Print each element on a separate line
//                Console.WriteLine("arr[{0}] = {1}", index, arr[index]);
//            }
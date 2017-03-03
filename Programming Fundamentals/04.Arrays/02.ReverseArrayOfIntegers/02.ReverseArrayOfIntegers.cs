using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseArrayOfIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class Program
    {
       public static void Main(string[] args)
        {
            var numberOfElements = int.Parse(Console.ReadLine());
            var numbers = new int[numberOfElements];
            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
            }
            for (int i = numbers.Length - 1; i >= 0 ; i--)
            {
                Console.Write("{0} ",numbers[i]);
            }
            Console.WriteLine();
        }
    }
}

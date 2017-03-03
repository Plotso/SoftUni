using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfInteger = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = arrayOfInteger.Length;
            int[] result;
            if (n == 1)
            {
                result = new int[1];
                result[0] = arrayOfInteger[0];
                Console.WriteLine(string.Join(", ", result));
            }
            else if (n % 2 == 0)
            {
                result = new int[2];
                result[0] = arrayOfInteger[n / 2 - 1];
                result[1] = arrayOfInteger[n / 2];
                Console.WriteLine(string.Join(", ", result));
            }
            else if (n % 2 != 0)
            {
                result = new int[3];
                result[0] = arrayOfInteger[n / 2 - 1];
                result[1] = arrayOfInteger[n / 2];
                result[2] = arrayOfInteger[n / 2 + 1];
                Console.WriteLine(string.Join(", ", result));
            }

            
            
        }
       
        
    }
}

namespace _01.ConvertFromBase10ToBaseN
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    
    public class ConvertFromBase10ToBaseN
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(BigInteger.Parse).ToList();
            var baseN = (int)input[0];
            BigInteger number = input[1];
            BigInteger remainder;
            string result = string.Empty;
            if (baseN >= 2 && baseN<= 50)
            {
                while (number > 0)
                {
                    remainder = number % baseN;
                    number /= baseN;
                    result = remainder.ToString() + result;
                   // Console.WriteLine(result);
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }
            
        }
    }
}

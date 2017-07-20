namespace _05.ConvertFromBaseNToBase10
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class ConvertFromBaseNToBase10
    {
        public static void Main()
        {
            var  input = Console.ReadLine().Trim().Split();
            int baseN = int.Parse(input[0]);
            var number = input[1].ToCharArray();
            BigInteger result = new BigInteger(0);
            for (int i = number.Length - 1, n = 0; i >= 0; i--, n++)
            {
                BigInteger num = new BigInteger(char.GetNumericValue(number[n]));
                BigInteger forSum = BigInteger.Multiply(num, BigInteger.Pow(new BigInteger(baseN), i));
                result += forSum;
            }
            Console.WriteLine(result.ToString());
        }
    }
}

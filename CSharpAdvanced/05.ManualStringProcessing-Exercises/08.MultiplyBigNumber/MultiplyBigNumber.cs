namespace _08.MultiplyBigNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MultiplyBigNumber
    {
        public static void Main()
        {
            var bigNumber = Console.ReadLine().TrimStart(new char[] { '0' }) ;
            var multiplier = int.Parse(Console.ReadLine());

            if (bigNumber == "0" || multiplier == 0 || bigNumber == "")
            {
                Console.WriteLine(0);
                return;
            }

            var result = new StringBuilder();

            var numberInMind = 0;
            var remainder = 0;
            var product = 0;

            for (int i = bigNumber.Length - 1; i >=  0; i--)
            {
                product = (int.Parse(bigNumber[i].ToString()) * multiplier) + numberInMind;
                numberInMind = /*(int)(*/product / 10/*)*/;
                remainder = product % 10;

                result.Append(remainder);

                if (i == 0 && numberInMind != 0)
                {
                    result.Append(numberInMind);
                }
            }
            var resultToCharArray = result.ToString().ToCharArray();
            Array.Reverse(resultToCharArray);
            Console.WriteLine(string.Join("",resultToCharArray));

        }
    }
}

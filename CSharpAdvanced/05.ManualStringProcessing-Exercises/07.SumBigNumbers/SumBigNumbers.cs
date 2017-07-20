namespace _07.SumBigNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SumBigNumbers
    {
        public static void Main()
        {
            var bigNumber1 = Console.ReadLine().TrimStart(new char[] { '0' });
            var bigNumber2 = Console.ReadLine().TrimStart(new char[] { '0' });

            var maxLength = Math.Max(bigNumber1.Length, bigNumber2.Length);

            var result = new StringBuilder();

            var sum = 0;
            var numberInHead = 0;
            var remainder = 0;

            bigNumber1 = bigNumber1.PadLeft(maxLength , '0');
            bigNumber2 = bigNumber2.PadLeft(maxLength , '0');

            for (int i = maxLength - 1; i >= 0; i--)
            {
                sum = int.Parse(bigNumber1[i].ToString()) + int.Parse(bigNumber2[i].ToString()) + numberInHead;
                numberInHead = sum / 10;
                remainder = sum % 10;

                result.Append(remainder);

                if (i == 0 && numberInHead != 0)
                {
                    result.Append(numberInHead);
                }

            }
            var resultToCharArray = result.ToString().ToCharArray();
            Array.Reverse(resultToCharArray);
            Console.WriteLine(string.Join("", resultToCharArray));
        }
    }
}

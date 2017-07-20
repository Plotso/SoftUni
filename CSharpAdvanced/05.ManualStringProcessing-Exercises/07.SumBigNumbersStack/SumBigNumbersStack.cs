namespace _07.SumBigNumbersStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SumBigNumbersStack
    {
        public static void Main()
        {
            var firstNumber = new Stack<Char>(Console.ReadLine());
            var secondtNumber = new Stack<Char>(Console.ReadLine());
            var result = new StringBuilder();

            var sum = 0;

            while (firstNumber.Count != 0 || secondtNumber.Count != 0)
            {
                sum = sum / 10;
                if (firstNumber.Count != 0)
                {
                    sum += int.Parse(firstNumber.Pop().ToString());
                }
                if (secondtNumber.Count != 0 )
                {
                    sum += (int)char.GetNumericValue(secondtNumber.Pop());
                }

                //var digit = sum % 10;
                result.Insert(0, sum % 10);
            }

            if (sum > 9)
            {
                result.Insert(0, sum / 10);
            }

            Console.WriteLine(result.ToString().TrimStart('0'));
        }
    }
}

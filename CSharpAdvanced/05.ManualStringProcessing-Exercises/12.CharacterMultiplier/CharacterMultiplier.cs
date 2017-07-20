namespace _12.CharacterMultiplier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CharacterMultiplier
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var str1 = input[0];
            var str2 = input[1];

            var minLen = Math.Min(str1.Length, str2.Length);
            var maxLen = Math.Max(str1.Length, str2.Length);
            var sum = 0;

            for (int i = 0; i < minLen; i++)
            {
                sum = str1[i] * str2[i];
            }
            if (str1.Length != str2.Length)
            {
                string longerInput = str1.Length > str2.Length ? longerInput = str1 : longerInput = str2;
                for (int i = minLen; i < maxLen; i++)
                {
                    sum += longerInput[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}

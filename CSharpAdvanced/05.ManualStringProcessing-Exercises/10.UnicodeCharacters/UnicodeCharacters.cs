namespace _10.UnicodeCharacters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            foreach (var chr in input)

            {

                Console.Write("\\u{0:x4}", (int)chr);

            }

            Console.WriteLine();

            //var a = 'a';
            //var b = 'b';

            //int sum = a * b;

            //Console.WriteLine(sum);
        }
    }
}

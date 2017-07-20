namespace _03.FormattingNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FormattingNumbers
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var a = int.Parse(input[0]);
            var b = double.Parse(input[1]);
            var c = double.Parse(input[2]);

            Console.WriteLine(string.Format($"|{a,-10:X}|{Convert.ToString(a, 2).PadLeft(10, '0'):#.##}|{b,10:f2}|{c,-10:f3}|"));
        }
    }
}

namespace _02.StringLength
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StringLength
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            if (input.Length < 20)
            {
                Console.WriteLine(input.PadRight(20, '*'));
            }
            else
            {
                Console.WriteLine(input.Substring(0,20));
                //var sb = new StringBuilder(20);
                //for (int i = 0; i < 20; i++)
                //{
                //    sb.Append(input[i]);
                //}
                //Console.WriteLine(sb);
            }
        }
    }
}

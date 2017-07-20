namespace _01.ReverseStringSB
{
    using System;
    using System.Linq;
    using System.Text;

    public class ReverseStringSB
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            Console.WriteLine(ReverseString(input));
            
        }
        public static string ReverseString(string s)
        {
            var sb = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }
    }
}

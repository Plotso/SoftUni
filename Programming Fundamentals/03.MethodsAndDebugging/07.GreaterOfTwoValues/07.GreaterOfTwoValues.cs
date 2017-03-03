using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char max = GetMax(first,second);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string max = GetMax(first, second);
                Console.WriteLine(max);
            }
        }
        static int GetMax(int a,int b)
        {
            return Math.Max(a, b);  // if (a <= b) return b; else if (a > b) return a
        }
        static char GetMax(char a,char b)
        {
            return (char)GetMax((int)a,(int) b);  
            //return (char)GetMax(a,(int) b); /same
        }
        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) < 0 )
            {
                return b;
            }
            else 
            {
                return a;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawAFilledSquare
{
    class Program
    {
        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n ; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }
        static void PrintTopBottomRows(int n)
        {
            Console.WriteLine(new string ('-',n * 2));
           


        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopBottomRows(n);
            for (int i = 0; i < n-2; i++)
            {
                PrintMiddleRow(n);
            }
            
            PrintTopBottomRows(n);
        }
    }
}

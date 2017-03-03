using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintingTriangle
{
    class Program
    {
        static void PrintTriangle(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{col} ");
                    //Console.Write(col + " ");
                }
                Console.WriteLine();             
            }
            for (int row = n-1; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{col} ");
                    //Console.Write(col + " ");
                }
                Console.WriteLine();
            }
            
        }
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number); //(int.Parse(Console.ReadLine()));
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfFrame
{
    class SquareOfFrame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
                Console.Write("+");
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write(" -");

                }
                Console.WriteLine(" +");
            for (int m = 0; m < n - 2; m++)
            {
                Console.Write("|");
                for (int i = 0; i < n-2; i++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }
            Console.Write("+");
            for (int b = 0; b < n-2; b++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");

            
        }
    }
}

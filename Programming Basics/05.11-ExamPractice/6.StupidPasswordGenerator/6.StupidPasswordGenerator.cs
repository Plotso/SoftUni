﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
             int l = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (char k = 'a'; k < 'a' + l; k++)
                    {
                        for (char m  = 'a'; m  <'a' + l; m ++)
                        {
                            for (int o = Math.Max(i,j) + 1; o <=n; o++)
                            {
                                Console.Write($"{i}{j}{k}{m}{o}");
                            }
                        }
                    }
                }
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            
            var name = Console.ReadLine();
            Console.Write("Hello, {0}!", name);
        }
    }
}

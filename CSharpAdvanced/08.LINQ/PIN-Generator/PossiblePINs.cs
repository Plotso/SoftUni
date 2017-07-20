using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIN_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, here are all possible PINs: ");

            var counter = 0;

            for (int a = 0; a <= 9; a++)
            {
                for (int b = 0; b <=9; b++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 0; d <=9; d++)
                        {
                            if (a == b && b == c && c == d)
                            {
                                Console.WriteLine($"{a}{b}{c}{d} IS NOT A GOOD ENOUGH PIN!");
                            }
                            else
                            {
                                Console.WriteLine($"{a}{b}{c}{d}");
                                counter++;
                            }
                            
                        }
                    }
                }
            }
            Console.WriteLine($"There are {counter} STRONG PIN's!");
        }
    }
}

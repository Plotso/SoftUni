using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGeneratorSoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;

            Random rnd = new Random();
            Console.WriteLine(rnd.Next(min , max ));
            Console.ReadLine();

        }
    }
}

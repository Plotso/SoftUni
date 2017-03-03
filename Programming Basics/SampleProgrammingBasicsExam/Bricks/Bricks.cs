using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Bricks
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());

            var c = x / (w * m);
            Console.WriteLine(Math.Ceiling(c));
        }
    }
}

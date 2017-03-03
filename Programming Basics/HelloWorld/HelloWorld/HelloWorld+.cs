using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            

            int x = 10;
            int y = 3;
            int result = x + y;

            Console.WriteLine("result =" + result);
            Console.WriteLine(" {0} + {1} = {2}", x, y, (x + y));
            Console.ReadLine();
        }
    }
}

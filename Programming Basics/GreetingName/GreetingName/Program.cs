using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Greetings {0}", name );
        }
    }
}

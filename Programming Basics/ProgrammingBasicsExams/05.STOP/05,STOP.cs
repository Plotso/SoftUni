using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.STOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('.',n + 1) + new string('_',2 * n + 1) + new string('.',n + 1));
            for (int i = 0; i <= n-1  ; i++)
            {
                Console.WriteLine(new string('.',n-i) + "//" + new string ('_',n * 4 + 3- (2*( n- i)) - 4) + 
                    "\\\\" + new string ('.',n-i) );
            }
            Console.WriteLine("//" + new string('_',n * 2 - 3) + "STOP!" + new string('_',n * 2 -3) + "\\\\");
            for (int i = 0; i <= n-1; i++)
            {
                Console.WriteLine(new string('.',i)+ "\\\\" + new string('_',n * 4 + 3 - (2*i)-4) + "//" + new string('.',i));
            }
        }
    }
}

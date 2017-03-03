using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());
            for (int i = M; i >= N; i--)
            {
                if (i % 3 == 0 && i % 2 == 0)
                {
                    if (i == S)
                    {
                        break;
                    }
                    Console.Write("{0} ",i);
                }
            }
        }
    }
}

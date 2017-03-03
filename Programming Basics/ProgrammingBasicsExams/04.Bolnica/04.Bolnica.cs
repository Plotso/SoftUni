using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Bolnica
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            var tP = 0;
            var uP = 0;
            var doc = 7;
            for (int i = 0; i < d; i++)
            {
                int p = int.Parse(Console.ReadLine());

                if (p > doc)
                {
                    tP += doc;
                    uP = p - doc;
                }
                 if (i % 3 == 0 && uP > tP)
                {
                    doc++;
                }
                else
                {
                    tP += p;
                }
            }
            Console.WriteLine("Treated patients: {0}.",tP);
            Console.WriteLine("Untreated patients: {0}.",uP);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double skp = double.Parse(Console.ReadLine());
            double ccp = double.Parse(Console.ReadLine());
            double pkg = double.Parse(Console.ReadLine());
            double skg = double.Parse(Console.ReadLine());
            double mkg = double.Parse(Console.ReadLine());
            double pp = skp + 0.60 * skp;
            double sp = ccp + 0.80 * ccp;
            
            var po = pkg * pp;
            var so = skg * sp;
            var mo = mkg * 7.50;
            var money = po + so + mo;
            Console.WriteLine("{0:f2}", money);
        }
    }
}

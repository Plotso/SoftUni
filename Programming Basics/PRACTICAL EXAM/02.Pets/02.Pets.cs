using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int fkg = int.Parse(Console.ReadLine());
            double dfkg = double.Parse(Console.ReadLine());
            double cfkg = double.Parse(Console.ReadLine());
            double tfg = double.Parse(Console.ReadLine());
            var dfo = dfkg * d;
            var cfo = cfkg * d;
            var tfo = (tfg * d) / 1000 ;
            var totalfoodtoeat = dfo + cfo + tfo;
            if (fkg >= totalfoodtoeat)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Truncate(fkg - totalfoodtoeat));
            }
            else if (fkg < totalfoodtoeat)
            {
                Console.WriteLine("{0} more kilos of food are needed.",Math.Ceiling(totalfoodtoeat - fkg));
            }
        }
    }
}

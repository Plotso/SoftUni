using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bc = int.Parse(Console.ReadLine());
            int cu = int.Parse(Console.ReadLine());
            var com = double.Parse(Console.ReadLine()) / 100 ;
            double bcInLv = bc * 1168.0;
            double cuToUSD = cu * 0.15;
            double USDTOLv = cuToUSD * 1.76;
            var lv = bcInLv + USDTOLv;
            var eur = lv / 1.95;
            eur -= com * eur;
            Console.WriteLine(eur);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            double twc = 0;
            double twmb = 0;
            double twsb = 0;
            double twbb = 0;
            double twt = 0;
            double totalPpl = 0;
            double ttwc = 0;
            double ttwmb = 0;
            double ttwsb = 0;
            double ttwbb = 0;
            double ttwt = 0;

            for (int i = 1; i <= groups; i++)
            {
                int pplInGroup = int.Parse(Console.ReadLine());
                totalPpl += pplInGroup;
                if (pplInGroup <= 5)
                {
                    twc += pplInGroup;
                    
                }
                if (pplInGroup >= 6 && pplInGroup <= 12)
                {
                    twmb += pplInGroup;
                    ttwmb += twmb;
                    ttwmb++;
                }
                if (pplInGroup >= 13 && pplInGroup <= 25)
                {
                    twsb += pplInGroup;
                    
                }
                if (pplInGroup >= 26 && pplInGroup <= 40)
                {
                    twbb += pplInGroup;
                    
                }
                if (pplInGroup >= 41)
                {
                    twt += pplInGroup;
                    
                }
                
            }
            Console.WriteLine("{0:f2}%", (twc / totalPpl) * 100);
            Console.WriteLine("{0:f2}%", (twmb / totalPpl) * 100);
            Console.WriteLine("{0:f2}%", (twsb / totalPpl) * 100);
            Console.WriteLine("{0:f2}%", (twbb / totalPpl) * 100);
            Console.WriteLine("{0:f2}%", (twt / totalPpl) * 100);

        }
    }
}

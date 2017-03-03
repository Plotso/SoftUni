using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HotelskaStaq
{
    class Program
    {
        static void Main(string[] args)
        {
            string m = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            double sP = 0;
            double aP = 0;
           
            if (m == "May" || m == "October")
            {
                sP += 50;
                aP += 65;
                if (n > 7 && n <= 14)
                {
                    sP = sP - (0.05 * sP);
                  
                }
                else if (n > 14)
                {
                    sP = sP - (0.30 * sP);
                    aP = aP - (0.10 * aP);
                }
            }
            else if (m == "June" || m == "September")
            {
                sP += 75.20;
                aP += 68.70;
                if (n > 14)
                {
                    sP = sP - (0.20 * sP);
                    aP = aP - (0.10 * aP);
                }
            }
            else if (m == "July" || m == "August")
            {
                sP += 76;
                aP += 77;
                if (n > 14)
                {
                    aP = aP - (0.10 * aP);
                }
            }
            double aPT = aP * n;
            double sPT = sP * n;
            Console.WriteLine("Apartment: {0:f2} lv.",aPT);
            Console.WriteLine("Studio: {0:f2} lv.", sPT);
        }
    }
}

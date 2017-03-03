using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            m = m + 15;

            if (m < 10)
            {
                Console.WriteLine(h + ":0" + m);
            }
            else if (m >= 60)
            {
                h = h + 1;
                m = m - 60;
                Console.WriteLine(h + ":0" + m);
               
            }
            else if (h > 23)
            {
                h = h % 24;
                Console.WriteLine("{0}:{01:00}",h,m);
            }
            else
            {
                Console.WriteLine( "{0}:{1}",h,m);
            }
             
        }
    }
}

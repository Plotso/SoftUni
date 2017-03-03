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


            if (m > 59)
            {
                h = h + 1;
                m = m - 60;
            }
            if (h > 23)
            {
                h = 0;
            }

            Console.WriteLine("{0}:{1}", h, m.ToString().PadLeft(2, '0'));
        }
    }
}

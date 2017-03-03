using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConventor
{
    class MetricConventor
    {
        static void Main(string[] args)
        {
           double length = double.Parse(Console.ReadLine());
            string inputParam = Console.ReadLine();
            string outputParam = Console.ReadLine();

            double lengthInMeters = 0;
            if (inputParam == "mm")
            {
                lengthInMeters = length / 1000;
            }
            else if (inputParam == "cm")
            {
                lengthInMeters = lengthInMeters / 100;
            }
            else if (inputParam == "mil")
            {
                lengthInMeters = lengthInMeters / 0.000621371192;
            }
            else if (inputParam == "in")
            {
                lengthInMeters = lengthInMeters/ 39.3700787;
            }
            else if (inputParam == "km")
            {
                lengthInMeters = lengthInMeters / 0.001;
            }
            else if (inputParam == "ft")
            {
                lengthInMeters = lengthInMeters / 3.2808399;
            }
            else
            {
                lengthInMeters = lengthInMeters / 1.0936133;
            }
        }
    }
}

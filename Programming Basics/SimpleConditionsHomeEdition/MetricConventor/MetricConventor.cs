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
            double distance = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            // double m = 1.0;
            double mm =  1000;
            double cm =  100;
            double mi = 0.000621371192;
            double inch = 39.3700787;
            double km = 0.001;
            double ft = 3.2808399;
            double yd = 1.0936133;

            if (input == "mm")
            {
                distance /= mm;
            }
            else if (input == "cm")
            {
                distance /= cm;
            }
            else if (input == "mi")
            {
                distance /= mi;
            }
            else if (input == "in")
            {
                distance /= inch;
            }
            else if (input == "km")
            {
                distance /= km;
            }
            else if (input == "ft")
            {
                distance /= ft;
            }
            else if (input == "yd")
            {
                distance /= yd;
            }
            double outputLength = distance;
            if (output == "mm")
            {
                outputLength *= mm;
            }
            else if (output == "cm")
            {
                outputLength *= cm;
            }
            else if (output == "mi")
            {
                outputLength *= mi;
            }
            else if (output == "in")
            {
                outputLength *= inch;
            }
            else if (output == "km")
            {
                outputLength *= km;
            }
            else if (output == "ft")
            {
                outputLength *= ft;
            }
            else if (output == "yd")
            {
                outputLength *= yd;
            }
            Console.WriteLine(outputLength);




        }
    }
}

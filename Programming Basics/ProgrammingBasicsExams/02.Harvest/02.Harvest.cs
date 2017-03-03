using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var z = double.Parse(Console.ReadLine());
            var w = int.Parse(Console.ReadLine());
            var totalG = x * y;
            var wine = 40 / 100 * totalG / 2.5;
            double extraWine = 0;
            double wineForWorkers = 0;
            double missingWine = 0;
            if (wine >= z)
            {
                extraWine = wine - z;
                wineForWorkers = extraWine / w;
                Console.WriteLine("Good harvest this year!Total wine: {0} liters.",Math.Truncate(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.",Math.Ceiling(extraWine),Math.Ceiling(wineForWorkers));
            }
            else
            {
                missingWine = z - wine;
                Console.WriteLine("It will be a tough winter!More {0} liters wine needed.",Math.Truncate(missingWine));
            }
        }
    }
}

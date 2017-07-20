namespace _01.HornetWings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HornetWings
    {
        public static void Main(string[] args)
        {
            var wingsFlaps = int.Parse(Console.ReadLine());
            var distancePer1000Flaps = double.Parse(Console.ReadLine()); // in meters , 1m = 1000wingsFlaps
            var endurance = int.Parse(Console.ReadLine()); // how many flaps before rest for 5s
            // makes 100 wings flaps for 1s
            
            var totalDistance = (wingsFlaps / 1000) * distancePer1000Flaps;
            var flyingSeconds = wingsFlaps / 100;
            var restSeconds = (wingsFlaps / endurance) * 5;
            var totalSeconds = flyingSeconds + restSeconds;

            Console.WriteLine($"{totalDistance:F2} m.");
            Console.WriteLine($"{totalSeconds} s.");


        }
    }
}

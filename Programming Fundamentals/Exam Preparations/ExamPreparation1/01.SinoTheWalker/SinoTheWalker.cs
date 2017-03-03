namespace _01.SinoTheWalker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;
    
    public class SinoTheWalker
    {
        public static void Main()
        {
            var startingTime = DateTime.ParseExact(
                Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            var numberOfSteps = int.Parse(Console.ReadLine());
            var secondsPerStep = int.Parse(Console.ReadLine());
            var secondToAdd = numberOfSteps * secondsPerStep;

            for (int i = 0; i < numberOfSteps; i++)
            {
                startingTime = startingTime.AddSeconds(secondsPerStep);
                if (startingTime.Year > 8000)
                {
                    startingTime = new DateTime(1, 1, 1, startingTime.Hour, startingTime.Minute, startingTime.Second);
                }
            }
            Console.WriteLine($"Time Arrival: { startingTime.ToString("HH:mm:ss")}");
        }
    }
}

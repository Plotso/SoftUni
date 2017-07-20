namespace _01.SplinterTrip
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplinterTrip
    {
        public static void Main()
        {
            var distance = double.Parse(Console.ReadLine());
            var fuelTankCapacity = double.Parse(Console.ReadLine());
            var milesSpentInHeavyWinds = double.Parse(Console.ReadLine());

            var normalConsumption = 25.0;
            var consumptionInWinds = normalConsumption * 1.5;

            var fuelNeededInHeavyWinds = milesSpentInHeavyWinds * consumptionInWinds;
            var fueldNeededOtherTime = (distance - milesSpentInHeavyWinds) * normalConsumption;
            var fuelNeededForTheWholeTrip = fuelNeededInHeavyWinds + fueldNeededOtherTime;

            var fuelInsurance = fuelNeededForTheWholeTrip * 0.05;
            var totalFuelConsumption = fuelNeededForTheWholeTrip + fuelInsurance;

            Console.WriteLine($"Fuel needed: {totalFuelConsumption:f2}L");

            if (fuelTankCapacity >= totalFuelConsumption)
            {
                var remainingFuel = fuelTankCapacity - totalFuelConsumption;
                Console.WriteLine($"Enough with {remainingFuel:f2}L to spare!");
            }
            else
            {
                var fuelNeeded = totalFuelConsumption - fuelTankCapacity;
                Console.WriteLine($"We need {fuelNeeded:f2}L more fuel.");
            }
        }
    }
}

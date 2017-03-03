namespace _01.CharityMarathon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CharityMarathon
    {
        public static void Main()
        {
            var lengthOfMarathonInDays = int.Parse(Console.ReadLine());
            var numberOfRunners = long.Parse(Console.ReadLine());
            var avgNumOfLaps = int.Parse(Console.ReadLine());
            var lengthOfTrack = long.Parse(Console.ReadLine());
            var capacityOfTrack = int.Parse(Console.ReadLine());
            var amoundOfMoneyDonatedPerKM = double.Parse(Console.ReadLine());
            var maxCapacityOfRunners = (long)lengthOfMarathonInDays * capacityOfTrack;
            if (maxCapacityOfRunners >= numberOfRunners)
            {
                maxCapacityOfRunners = numberOfRunners;
            }
            var totalMeters = maxCapacityOfRunners * avgNumOfLaps * lengthOfTrack;
            var totalKM = totalMeters / 1000;
            var totalMoneyRaised = amoundOfMoneyDonatedPerKM * totalKM;
            Console.WriteLine($"Money raised: {totalMoneyRaised:F2}");

        }
    }
}

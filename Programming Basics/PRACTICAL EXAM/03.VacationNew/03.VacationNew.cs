using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.VacationNew
{
    class Program
    {
        static void Main(string[] args)
        {
            int oldPeople = int.Parse(Console.ReadLine());
            int youngPeople = int.Parse(Console.ReadLine());
            int nightsSpent = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();
            double ticketpriceOldPeople = 0;
            double ticketpriceYoungPeople = 0;
            double ticketpriceBothWays = 0;
            double allNightsCost = nightsSpent * 82.99;
            double totalCostWithoutCom = 0;
            double totalCost = 0;
            if (transport == "train")
            {
                ticketpriceOldPeople += 24.99;
                ticketpriceYoungPeople += 14.99;
                if (oldPeople + youngPeople >= 50)
                {
                    ticketpriceOldPeople *= 0.50;
                    ticketpriceYoungPeople *= 0.50;
                }
                ticketpriceBothWays = ((oldPeople * ticketpriceOldPeople) + (youngPeople * ticketpriceYoungPeople)) * 2;
                totalCostWithoutCom = ticketpriceBothWays + allNightsCost;
                totalCost = totalCostWithoutCom + 0.10 * totalCostWithoutCom;
                Console.WriteLine("{0:f2}",totalCost);
                
            }
            else if (transport == "bus")
            {
                ticketpriceOldPeople += 32.50;
                ticketpriceYoungPeople += 28.50;
                ticketpriceBothWays = ((oldPeople * ticketpriceOldPeople) + (youngPeople * ticketpriceYoungPeople)) * 2;
                totalCostWithoutCom = ticketpriceBothWays + allNightsCost;
                totalCost = totalCostWithoutCom + 0.10 * totalCostWithoutCom;
                Console.WriteLine("{0:f2}", totalCost);
            }
            else if (transport == "boat")
            {
                ticketpriceOldPeople += 42.99;
                ticketpriceYoungPeople += 39.99;
                ticketpriceBothWays = ((oldPeople * ticketpriceOldPeople) + (youngPeople * ticketpriceYoungPeople)) * 2;
                totalCostWithoutCom = ticketpriceBothWays + allNightsCost;
                totalCost = totalCostWithoutCom + 0.10 * totalCostWithoutCom;
                Console.WriteLine("{0:f2}", totalCost);
            }
            else if (transport == "airplane")
            {
                ticketpriceOldPeople += 70.00;
                ticketpriceYoungPeople += 50.00;
                ticketpriceBothWays = ((oldPeople* ticketpriceOldPeople) + (youngPeople* ticketpriceYoungPeople)) * 2;
                totalCostWithoutCom = ticketpriceBothWays + allNightsCost;
                totalCost = totalCostWithoutCom + 0.10 * totalCostWithoutCom;
                Console.WriteLine("{0:f2}", totalCost);
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double transportPrice = 0;
            double ticketprice = 0;
            if (people <= 4)
            {
                transportPrice += 75 / 100 * budget;
                budget -= transportPrice;
                if (ticketType == "VIP")
                {
                    ticketprice += people * 499.99;
                }
                else
                {
                    ticketprice += people * 249.99;
                }
                if (budget >= ticketprice)
                {
                    Console.WriteLine("Yes! You have {0} leva left.", budget - ticketprice);
                }
                else if (budget < ticketprice)
                {
                    Console.WriteLine("Not enough money! You need {0} leva",ticketprice - budget);
                }
            }
            else if (people >= 5 && people <= 9)
            {
                transportPrice += 60 / 100 * budget;
                budget -= transportPrice;
                if (ticketType == "VIP")
                {
                    ticketprice += people * 499.99;
                }
                else
                {
                    ticketprice += people * 249.99;
                }
                if (budget >= ticketprice)
                {
                    Console.WriteLine("Yes! You have {0} leva left.", budget - ticketprice);
                }
                else if (budget < ticketprice)
                {
                    Console.WriteLine("Not enough money! You need {0} leva", ticketprice - budget);
                }
            }
            else if (people >= 10 && people <= 24)
            {
                transportPrice += 50 / 100 * budget;
                budget -= transportPrice;
                if (ticketType == "VIP")
                {
                    ticketprice += people * 499.99;
                }
                else
                {
                    ticketprice += people * 249.99;
                }
                if (budget >= ticketprice)
                {
                    Console.WriteLine("Yes! You have {0} leva left.", budget - ticketprice);
                }
                else if (budget < ticketprice)
                {
                    Console.WriteLine("Not enough money! You need {0} leva", ticketprice - budget);
                }
            }
            else if (people >= 25 && people <= 49)
            {
                transportPrice += 40 / 100 * budget;
                budget -= transportPrice;
                if (ticketType == "VIP")
                {
                    ticketprice += people * 499.99;
                }
                else
                {
                    ticketprice += people * 249.99;
                }
                if (budget >= ticketprice)
                {
                    Console.WriteLine("Yes! You have {0} leva left.", budget - ticketprice);
                }
                else if (budget < ticketprice)
                {
                    Console.WriteLine("Not enough money! You need {0} leva", ticketprice - budget);
                }
            }
            else if (people >= 50 )
            {
                transportPrice += 25 / 100 * budget;
                budget -= transportPrice;
                if (ticketType == "VIP")
                {
                    ticketprice += people * 499.99;
                }
                else
                {
                    ticketprice += people * 249.99;
                }
                if (budget >= ticketprice)
                {
                    Console.WriteLine("Yes! You have {0} leva left.", budget - ticketprice);
                }
                else if (budget < ticketprice)
                {
                    Console.WriteLine("Not enough money! You need {0} leva", ticketprice - budget);
                }
            }
        }
    }
}

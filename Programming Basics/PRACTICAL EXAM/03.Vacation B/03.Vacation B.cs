using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation_B
{
    class Program
    {
        
            static void Main(string[] args)
            {
                int op = int.Parse(Console.ReadLine());
                int yp = int.Parse(Console.ReadLine());
                int period = int.Parse(Console.ReadLine());
                string transport = Console.ReadLine();
                double ticketpriceOP = 0;
                double ticketpriceYP = 0;
                double moneyO = 0;
                double groupNP = period * 82.99;
                double ticketpriceO = 0;
                if (transport == "train")
                {
                    ticketpriceOP += 24.99;
                    ticketpriceYP += 14.99;
                    if (op + yp > 50)
                    {
                        ticketpriceOP *= 0.50;
                        ticketpriceYP *= 0.50;
                    }
                    ticketpriceO = (ticketpriceOP + ticketpriceYP) * 2;
                    moneyO = ticketpriceO + groupNP;
                    moneyO += 0.10 * moneyO;
                    Console.WriteLine("{0:f2}", moneyO);
                }
                else if (transport == "bus")
                {
                    ticketpriceOP += 32.50;
                    ticketpriceYP += 28.50;
                    ticketpriceO = (ticketpriceOP + ticketpriceYP) * 2;
                    moneyO = ticketpriceO + groupNP;
                    moneyO += 0.10 * moneyO;
                    Console.WriteLine("{0:f2}", moneyO);
                }
                else if (transport == "boat")
                {
                    ticketpriceOP += 42.99;
                    ticketpriceYP += 39.99;
                    ticketpriceO = (ticketpriceOP + ticketpriceYP) * 2;
                    moneyO = ticketpriceO + groupNP;
                    moneyO += 0.10 * moneyO;
                    Console.WriteLine("{0:f2}", moneyO);
                }
                else if (transport == "airplane")
                {
                    ticketpriceOP += 70.00;
                    ticketpriceYP += 50.00;
                    ticketpriceO = (ticketpriceOP + ticketpriceYP) * 2;
                    moneyO = ticketpriceO + groupNP;
                    moneyO += 0.10 * moneyO;
                    Console.WriteLine("{0:f2}", moneyO);
                }
            }
        }
    }



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string currencyFirst = Console.ReadLine();
            string currencySecond = Console.ReadLine();
            double result = 0.0;
            double BGN = 1.0;
            double EUR = 1.95583;
            double GBP = 2.53405;
            double USD = 1.79549;
            if (currencyFirst == "BGN")
            {
                if (currencySecond == "EUR")
                {
                    result = value / EUR;
                }
                else if (currencySecond == "GBP")
                {
                    result = value / GBP;
                }
                else
                {
                    result = value / USD;
                }
            }
            else if (currencyFirst == "EUR")
            {
                if (currencySecond == "BGN")
                {
                    result = value * EUR;
                }
                else if (currencySecond == "GBP")
                {
                    result = (value * EUR) / GBP;
                }
                else
                {
                    result = (value * EUR) / USD;
                }
            }
            else if (currencyFirst == "GBP")
            {
                if (currencySecond == "EUR")
                {
                    result = (value * GBP) / EUR;
                }
                else if (currencySecond == "BGN")
                {
                    result = value * GBP;
                }
                else
                {
                    result = (value * GBP) / USD;
                }
            }
            else
            {
                if (currencySecond == "EUR")
                {
                    result = (value * USD) / EUR;
                }
                else if (currencySecond == "GBP")
                {
                    result = (value * USD) / GBP;
                }
                else
                {
                    result = value * USD;
                }
            }
            Console.WriteLine(Math.Round(result, 2));
            
        }
    }
}

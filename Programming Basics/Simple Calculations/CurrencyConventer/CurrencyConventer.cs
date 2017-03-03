using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConventer
{
    class CurrencyConventer
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string currencyFirst = Console.ReadLine();
            string currencySecond = Console.ReadLine();

            double result = 0.0;

            if ( currencyFirst == "BGN")
            {
                if (currencySecond == "EUR")
                {
                    result = money / 1.95583;  
                }
                else if (currencySecond == "GBP")
                {
                    result = money / 2.53405;
                }
                else
                {
                    result = money / 1.79549;
                }
            }
            else if (currencyFirst == "EUR")
            {
                if (currencySecond == "BGN")
                {
                    result = money * 1.95583;
                }
                else if (currencySecond == "GBP")
                {
                    result = (money * 1.95583) / 2.53405;
                }
                else
                {
                    result = (money * 1.95583) * 1.79549;
                }
            }
            else if (currencyFirst == "GBP")
            {
                if (currencySecond == "EUR")
                {
                    result = (money * 2.53405) / 1.95583;
                }
                else if (currencySecond == "BGN")
                {
                    result = money * 2.53405;
                }
                else
                {
                    result = (money * 2.53405) / 1.79549;
                }
            }
            else
            {
                if (currencySecond == "EUR")
                {
                    result = (money * 1.79549) / 1.95583;
                }
                else if (currencySecond == "GBP" )
                {
                    result = (money * 1.79549) / 2.53405;
                }
                else
                {
                    result = money * 1.79549;
                }
            }
            Console.WriteLine(Math.Round(result,2) + " " + currencySecond);
        }
    }
}

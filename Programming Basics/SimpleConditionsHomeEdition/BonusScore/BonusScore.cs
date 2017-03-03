using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var bonusScore = 0.0;
            if (num <= 100)
            {
                bonusScore = 5;
            }
            else if (num >100 && num <= 1000)
            {
                bonusScore = num * 20/100;
            }
            else if (num > 1000)
            {
                bonusScore = num * 10/100;
            }

            if (num %2 == 0)
            {
                bonusScore = bonusScore + 1;
            }
            if (num %10 ==5)
            {
                bonusScore = bonusScore + 2;
            }
            Console.WriteLine(bonusScore);
            Console.WriteLine(num + bonusScore);
        }
    }
}

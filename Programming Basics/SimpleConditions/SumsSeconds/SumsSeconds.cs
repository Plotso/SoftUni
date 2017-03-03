using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumsSeconds
{
    class SumsSeconds
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = num1 + num2 + num3;
            int seconds = sum % 60;
            int minutes = sum / 60;

            if (seconds >= 10)
            {
                Console.WriteLine("{0}:{1}",minutes,seconds);
            }
            else
            {
                Console.WriteLine("{0}:0{1}",minutes,seconds);
            }        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());

            var sum = num1 + num2 + num3;
            var seconds = sum % 60;
            var minutes = sum / 60;

            if (seconds < 10 )
            {
                Console.WriteLine("{0}:0{1}",minutes,seconds);
            }
            else
            {
                Console.WriteLine("{0}:{1}",minutes,seconds);
            }

            
        }
    }
}

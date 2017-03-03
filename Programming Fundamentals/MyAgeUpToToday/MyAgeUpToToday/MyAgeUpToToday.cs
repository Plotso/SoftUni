using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAgeUpToToday
{
    class MyAgeUpToToday
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth date in format - year/month/day :");
            var bDay = DateTime.Parse(Console.ReadLine());
            var age = GetAge(bDay);
            //var age = GetAge(new DateTime(1990, 11, 4));
            Console.WriteLine(age);
        }
        static int GetAge(DateTime dateOfBirth)
        {
            var now = DateTime.Now;
            TimeSpan result = now - dateOfBirth;
           // Console.WriteLine(result.Days / 365.2422);
            return (int)(result.Days / 365.2422);
            //return 1;

        }
    }
}

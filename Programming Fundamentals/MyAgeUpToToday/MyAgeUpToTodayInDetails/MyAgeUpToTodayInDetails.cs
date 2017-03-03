using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAgeUpToTodayInDetails
{
    class MyAgeUpToTodayInDetails
    {
        // WITHOUT TimeSpan
        static void Main(string[] args)
        {
            var age = getAge(1990,11,4);
            Console.WriteLine(age);
        }
        static int getAge(int year,int month,int day)
        {
            var now = DateTime.Now;
            var currentYear = now.Year;
            var currentMonth = now.Month;
            var currentDay = now.Day;
            var age = currentYear - year;
            if (currentMonth < month || (currentMonth == month && currentDay < day))
            {
                age--;
            }
           
            return age;
        }
    }
}

namespace _01.DaysOfWeek
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] days = 
                {
                "Monday", "Tuesday", "Wednesday", "Thursday",
                "Friday", "Saturday", "Sunday"
                };
            int day = int.Parse(Console.ReadLine());
            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[day - 1]);
            }
            //var dayss = new string[]{ "fg"};
        }
    }
}

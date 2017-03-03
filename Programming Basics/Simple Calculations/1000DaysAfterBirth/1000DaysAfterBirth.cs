using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            string date2 = (DateTime.ParseExact(date, "dd-MM-yyyy", null).AddDays(999)).ToString("dd-MM-yyyy");
            Console.WriteLine(date2);
            

        }
    }
}

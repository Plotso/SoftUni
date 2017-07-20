namespace _08.MapDistricts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MapDistricts
    {
        public static void Main()
        {
            var rnd = new Random();

            var firstDigit = rnd.Next(0, 9);
            var secondDigit = rnd.Next(0, 9);
            var thirdDigit = rnd.Next(0, 9);
            var fourthDigit = rnd.Next(0, 9);
            
            Console.WriteLine($"Generated PIN: {firstDigit}{secondDigit}{thirdDigit}{fourthDigit}");
        }
    }
}

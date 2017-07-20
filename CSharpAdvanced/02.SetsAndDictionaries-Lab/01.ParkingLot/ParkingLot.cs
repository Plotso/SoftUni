namespace _01.ParkingLot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ParkingLot
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var parking = new SortedSet<string>();
            while (input != "END")
            {
                var inputParams = Regex.Split(input, ", ");
                if (inputParams[0] == "IN")
                {
                    parking.Add(inputParams[1]);
                }
                else if (inputParams[0] == "OUT")
                {
                    parking.Remove(inputParams[1]);
                }
                input = Console.ReadLine();
            }
            if (parking.Any())
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}

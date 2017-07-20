namespace _05.RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        // this is task 8 from the exercises

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var carInfo = Console.ReadLine().Split().ToArray();
                var model = carInfo[0];
                var engineSpeed = int.Parse(carInfo[1]);
                var enginePower = int.Parse(carInfo[2]);
                var cargoWeight = int.Parse(carInfo[3]);
                var cargoType = carInfo[4];
                var tyre1Pressure = double.Parse(carInfo[5]);
                var tyre1Age = int.Parse(carInfo[6]);
                var tyre2Pressure = double.Parse(carInfo[7]);
                var tyre2Age = int.Parse(carInfo[8]);
                var tyre3Pressure = double.Parse(carInfo[9]);
                var tyre3Age = int.Parse(carInfo[10]);
                var tyre4Pressure = double.Parse(carInfo[11]);
                var tyre4Age = int.Parse(carInfo[12]);

                cars.Add(new Car(model,
                    new Engine(engineSpeed, enginePower),
                    new Cargo(cargoType,cargoWeight),
                    new List<Tyre> { new Tyre(tyre1Pressure,tyre1Age), new Tyre(tyre2Pressure,tyre2Age), new Tyre(tyre3Pressure,tyre3Age), new Tyre(tyre4Pressure,tyre4Age)}));
            }

            var command = Console.ReadLine();

            if (command == "fragile")
            {
                cars.Where(c => c.cargo.type == "fragile")
                    .Where(c => c.tires.Any(t => t.pressure < 1))
                    .Select(c => c.model)
                    .ToList()
                    .ForEach(m => Console.WriteLine(m));
            }
            else
            {
                cars.Where(c => c.cargo.type == "flamable")
                    .Where(c => c.engine.power > 250)
                    .Select(c => c.model)
                    .ToList()
                    .ForEach(m => Console.WriteLine(m));
            }
        }
    }
}

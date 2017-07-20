namespace _04.FollowingExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var cars = new List<Car>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputTokens = Console.ReadLine().Split();
                var model = inputTokens[0];
                var fuelAmount = double.Parse(inputTokens[1]);
                var fuelConsumptionPer1Km = double.Parse(inputTokens[2]);

                cars.Add(new Car(model, fuelAmount, fuelConsumptionPer1Km));
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var commandTokens = command.Split();
                var model = commandTokens[1];
                var ammountOfKm = double.Parse(commandTokens[2]);

                cars.Where(c => c.model == model).ToList().ForEach(c => c.Drive(ammountOfKm));
            }

            foreach (Car car in cars)
            {
                var model = car.model;
                var fueldAmount = car.fuelAmount;
                var distanceTraveled = car.distanceTraveled;
                Console.WriteLine($"{model} {fueldAmount:f2} {distanceTraveled}");
            }
        }
    }
}

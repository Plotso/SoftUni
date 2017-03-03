namespace JustRandomStuff
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class JustRandomStuff
    {
        public static void Main(string[] args)
        {
            var cars = new List<Car> {
            new Car {
                CarModel = "R8",
                Company = "Audi",
                ReleaseYear = 2016,
                horsePowers = 530,
                Doors = 2,
                Price = 200000,
                Colour = "red"
            },
            new Car
            {
                CarModel = "R8",
                Company = "Audi",
                ReleaseYear = 2017,
                horsePowers = 550,
                Doors = 2,
                Price = 220000,
                Colour = "black"
            },
            new Car
            {
                CarModel = "R8",
                Company = "Audi",
                ReleaseYear = 2016,
                horsePowers = 515,
                Doors = 4,
                Price = 210000,
                Colour = "yellow"
            },
            new Car
            {
                CarModel = "M6",
                Company = "BMW",
                ReleaseYear = 2016,
                horsePowers = 560,
                Doors = 2,
                Price = 280000,
                Colour = "silver"
            },
            new Car
            {
                CarModel = "M6",
                Company = "BMW",
                ReleaseYear = 2017,
                horsePowers = 570,
                Doors = 2,
                Price = 300000,
                Colour = "white"
            },
            new Car
            {
                CarModel = "M6",
                Company = "BMW",
                ReleaseYear = 2017,
                horsePowers = 570,
                Doors = 2,
                Price = 300000,
                Colour = "black"
            },
            new Car
            {
                CarModel = "AMG",
                Company = "Mercedes",
                ReleaseYear = 2016,
                horsePowers = 500,
                Doors = 2,
                Price = 250000,
                Colour = "purple"
            },
            new Car
            {
                CarModel = "AMG",
                Company = "Mercedes",
                ReleaseYear = 2016,
                horsePowers = 500,
                Doors = 2,
                Price = 250000,
                Colour = "pink"
            },
            new Car
            {
                CarModel = "Celica",
                Company = "Toyota",
                ReleaseYear = 2011,
                horsePowers = 200,
                Doors = 2,
                Price = 30000,
                Colour = "silver"
            },
            new Car
            {
                CarModel = "Celica",
                Company = "Toyota",
                ReleaseYear = 2001,
                horsePowers = 120,
                Doors = 2,
                Price = 5000,
                Colour = "black"
            },
            new Car
            {
                CarModel = "Niva",
                Company = "Lada",
                ReleaseYear = 1980,
                horsePowers = 100,
                Doors = 4,
                Price = 15000,
                Colour = "black"
            },
            new Car
            {
                CarModel = "Niva",
                Company = "Lada",
                ReleaseYear = 1980,
                horsePowers = 100,
                Doors = 4,
                Price = 15000,
                Colour = "white"
            },
            new Car
            {
                CarModel = "M5",
                Company = "BMW",
                ReleaseYear = 2017,
                horsePowers = 500,
                Doors = 2,
                Price = 250000,
                Colour = "black"
            }
            };

            var groupedCars = cars
                .GroupBy(c => c.Company);
            Console.Write("YOU ARE WELCOME!");
            foreach (var group in groupedCars)
            {
                
                Console.WriteLine("     \\_(^_^)_/     ");
                Console.WriteLine();
                Console.WriteLine(group.Key);
                foreach (var microGroup in group)
                {
                    Console.WriteLine("THE NEXT CAR BY THIS COMPANY IS :");
                    Console.WriteLine($"Car Model -> {microGroup.CarModel}");
                    Console.WriteLine($"Released -> {microGroup.ReleaseYear}");
                    Console.WriteLine($"HP -> {microGroup.horsePowers}");
                    Console.WriteLine($"Doors -> {microGroup.Doors}");
                    Console.WriteLine($"Colour -> {microGroup.Colour}");
                    Console.WriteLine($"Price -> {microGroup.Price}");
                    Console.WriteLine("YOU LIKED THIS ONE,DIDN'T YOU?");
                    Console.WriteLine("\\\\\\\\\\\\\\\\\\//////////");
                    Console.WriteLine();

                }
                Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
                Console.WriteLine("|||||||||||||||||||||||||||||||");
                Console.WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
                Console.WriteLine("THANKS FOR SEING THIS MODEL!!!");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

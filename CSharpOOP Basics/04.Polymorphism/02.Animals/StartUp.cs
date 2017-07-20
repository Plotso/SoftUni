using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {

        //Animal animal = new Animal(); -> This cannot be done because Animal is ABSTRACT class and the type of
        // animal should be defined in order to create a reference to the Animal class
        Dog dog = new Dog("Gosho", "Meat");
        Cat cat = new Cat("Pesho", "Whiskas");
        Animal catAnimal = new Cat("Ivan", "Java");
        Animal dogAnimal = new Dog("Koche", "Leb");

        var listOfAnimals = new List<Animal>();
        listOfAnimals.Add(dogAnimal);
        listOfAnimals.Add(catAnimal);

        Console.WriteLine(dog.ExplainMyself());
        Console.WriteLine(cat.ExplainMyself());
        Console.WriteLine(catAnimal.ExplainMyself());
        Console.WriteLine(dogAnimal.ExplainMyself());

        Print(listOfAnimals);
    }

    public static void Print(List<Animal> animals)
    {
        Console.WriteLine("Print from Method 'Print'");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.ExplainMyself());
        }
    }
}


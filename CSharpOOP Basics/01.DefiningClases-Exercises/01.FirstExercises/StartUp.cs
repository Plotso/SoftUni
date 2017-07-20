namespace _01.FirstExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class StartUp
    {
        public static void Main()
        {
            var people = new List<Person>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var person = Console.ReadLine().Split();
                var name = person[0];
                var age = int.Parse(person[1]);

                people.Add(new Person(name,age));

            }

            foreach (var person in people.Where(x => x.age > 30).OrderBy(x => x.name))
            {
                Console.WriteLine($"{person.name} - {person.age}");
            }
        }
    }
}

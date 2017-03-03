namespace _11.DragonArmy_Normal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var numberOfDragons = int.Parse(Console.ReadLine());
            var dictionaryOfDragons = new Dictionary<string, SortedDictionary<string, int[]>>();
            for (int i = 0; i < numberOfDragons; i++)
            {
                var input = Console.ReadLine().Split();

                var type = input[0];
                var name = input[1];
                var damage = 0;
                if (input[2] != "null")
                {
                    damage = int.Parse(input[2]);
                }
                else
                {
                    damage = 45;
                }
                var health = 0;
                if (input[3] != "null")
                {
                    health = int.Parse(input[3]);
                }
                else
                {
                    health = 250;
                }
                var armor = 0;
                if (input[4] != "null")
                {
                    armor = int.Parse(input[4]);
                }
                else
                {
                    armor = 10;
                }

                if (!dictionaryOfDragons.ContainsKey(type))
                {
                    dictionaryOfDragons[type] = new SortedDictionary<string, int[]>();
                }
                dictionaryOfDragons[type][name] = new int[] { damage, health, armor };
            }
            foreach (var type in dictionaryOfDragons)
            {
                var typeName = type.Key;
                var dragonsByType = type.Value;

                var averageDamage = dragonsByType.Values.Average(a => a[0]);
                var averageHealth = dragonsByType.Values.Average(a => a[1]);
                var averageArmor = dragonsByType.Values.Average(a => a[2]);
                Console.WriteLine($"{typeName}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})");
                foreach (var dragon in dragonsByType)
                {
                    var name = dragon.Key;
                    var stats = dragon.Value;
                    var damage = stats[0];
                    var health = stats[1];
                    var armor = stats[2];

                    Console.WriteLine($"-{name} -> damage: {damage}, health: {health}, armor: {armor}");
                }
            }
        }
    }
}

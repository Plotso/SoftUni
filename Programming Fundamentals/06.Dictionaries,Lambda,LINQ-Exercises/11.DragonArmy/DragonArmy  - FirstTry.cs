namespace _11.DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DragonArmy
    {
       public static void Main(string[] args)
        {
            var numberOfDragons = int.Parse(Console.ReadLine());
            int n;
            var dictionary = new Dictionary<string, int>();
            var dragonTypeName = new Dictionary<string, string>();
            var dragonStatsTotal = new Dictionary<int, Dictionary<int, int>>();
            var dragonHPArmor = new Dictionary<int, int>();
            //var input;
            
            for (int i = 0; i < numberOfDragons; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                var type = input[0];
                var name = input[1];
                var damage = input[2];
                if (damage == "null")
                {
                    damage = "45";
                }
                var health = input[3];
                if (health == "null")
                {
                    health = "250";
                }
                var armor = input[4];
                if (armor == "null")
                {
                    armor = "10";
                }

                if (!dragonTypeName.ContainsKey(type))
                {
                    dragonTypeName.Add(type, name);
                    dragonHPArmor.Add(Convert.ToInt32(health), Convert.ToInt32(armor));
                    dragonStatsTotal.Add(Convert.ToInt32(damage), dragonHPArmor);
                }
                else if (dragonTypeName.ContainsKey(type) && !dragonTypeName.ContainsValue(name))
                {
                    dragonTypeName.Add(type, name);
                    dragonHPArmor.Add(Convert.ToInt32(health), Convert.ToInt32(armor));
                    dragonStatsTotal.Add(Convert.ToInt32(damage), dragonHPArmor);
                }
                else if (dragonTypeName.ContainsKey(type) && dragonTypeName.ContainsValue(name))
                {
                    dragonTypeName[type] = name;
                    dragonHPArmor[Convert.ToInt32(health)] = Convert.ToInt32(armor);
                    dragonStatsTotal[Convert.ToInt32(damage)] = dragonHPArmor;
                }
            }
            
           
        }
    }
}


namespace _03.AMinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq; 

    public class AMinerTask
    {
        public static void Main()
        {
            // rewrote the code i saw from Internet after i changed it a little bit

            var resources = new Dictionary<string, int>();
            int value;
            var material = Console.ReadLine();

            while (material != "stop")
            {
                value = int.Parse(Console.ReadLine());
                if (resources.ContainsKey(material))
                {
                    resources[material] += value;
                }
                else
                {
                    resources.Add(material, value);
                }
                material = Console.ReadLine();
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

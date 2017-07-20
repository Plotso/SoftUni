namespace _06.AMinersTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AMinersTask
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<string, int>();
            var counter = 1;
            var resource = string.Empty;
            while (input != "stop")
            {
                if (counter % 2 != 0)
                {
                    if (!dictionary.ContainsKey(input))
                    {
                        dictionary[input] = 0;
                        resource = input;
                    }
                }
                else
                {
                    dictionary[resource] += int.Parse(input);
                }
                counter++;
                input = Console.ReadLine();
            }

            foreach (var res in dictionary)
            {
                var name = res.Key;
                var quantity = res.Value;

                Console.WriteLine($"{name} -> {quantity}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AMinerTaskFromNet
{
    class AMinerTaskFromNet
    {
        static void Main(string[] args)
        {
            //a code i saw on the net and changed a little bit

           var dictionary = new Dictionary<string, int>();
            int value;
            string material = Console.ReadLine()
              .Trim();


            while (material != "stop")
            {
                value = int.Parse(Console.ReadLine()
                  .Trim());

                if (dictionary.ContainsKey(material))
                {
                    dictionary[material] += value;
                }
                else
                {
                    dictionary.Add(material, value);
                }

                material = Console.ReadLine();
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}

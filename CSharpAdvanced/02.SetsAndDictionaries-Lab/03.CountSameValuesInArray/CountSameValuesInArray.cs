namespace _03.CountSameValuesInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class CountSameValuesInArray
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            var dictionary = new SortedDictionary<double, int>();

            foreach (var element in input)
            {
                if (!dictionary.ContainsKey(element))
                {
                    dictionary.Add(element, 1);
                }
                else
                {
                    dictionary[element]++;
                } 
            }
            foreach (var element in dictionary)
            {
                var num = element.Key;
                var met = element.Value;
                Console.WriteLine($"{num} - {met} times");
            }
        }
    }
}

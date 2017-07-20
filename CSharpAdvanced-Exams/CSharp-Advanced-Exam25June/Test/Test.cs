using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var resultList = new List<string>();
            foreach (var item in input)
            {
                resultList.Add(item);
            }
            foreach (var item in resultList.OrderByDescending(x => int.Parse(x.Substring(0, x.Length - 1))).ThenByDescending(x => x.Substring(x.Length - 1)))
            {
                Console.WriteLine(item);
            }
        }
    }
}

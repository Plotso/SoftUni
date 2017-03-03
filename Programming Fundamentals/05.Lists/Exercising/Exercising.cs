using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercising
{
    class Exercising
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', ',');
            var list = new List<int>();
            foreach (var num in input)
            {
                list.Add(int.Parse(num));
            }
            Console.WriteLine(string.Join(" ",list));

        }
    }
}

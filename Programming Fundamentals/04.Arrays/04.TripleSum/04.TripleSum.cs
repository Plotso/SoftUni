using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesElements
{
    class TripleElements
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();

            string[] items = values.Split(' ');

            int[] arr = new int[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                arr[i] = int.Parse(items[i]);
            }

            bool isitTrue = false;

            for (int a = 0; a < arr.Length; a++)
            {
                var sum = 0;
                for (int b = a + 1; b < arr.Length; b++)
                {
                    sum = arr[a] + arr[b];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] == sum)
                        {
                            Console.WriteLine($"{arr[a]} + {arr[b]} == {sum}");
                            isitTrue = true;
                            break;
                        }
                    }
                }
            }
            if (!isitTrue)
            {
                Console.WriteLine("No");
            }
        }
    }
}

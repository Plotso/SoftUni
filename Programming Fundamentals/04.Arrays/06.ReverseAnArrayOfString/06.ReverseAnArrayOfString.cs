using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseAnArrayOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            //var strings = Console.ReadLine().Split(' ').ToArray();
            var strings = Console.ReadLine().Split(' ') ; // string strings = Console.ReadLine();
            var array = new string[strings.Length];
            //Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
               // array[i] = array;
                Console.Write(array[i]);
            }
        }
    }
}

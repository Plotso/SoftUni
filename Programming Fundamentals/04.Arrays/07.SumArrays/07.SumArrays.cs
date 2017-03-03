using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int len1 = arr1.Length;
            //int len2 = arr2.Length;
            int len = Math.Max(arr1.Length, arr2.Length);//Math.Max(len1,len2);
            var result = new int[len];
            for (int i = 0; i < len; i++)
            {
                result[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}

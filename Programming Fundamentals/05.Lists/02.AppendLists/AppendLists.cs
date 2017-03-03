using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            var lists = Console.ReadLine().Split('|').ToList();
            lists.Reverse();
            var result = new List<int>();
            foreach (var list in lists)
            {
                var nums = list.Split(new [] { ' ' },StringSplitOptions.RemoveEmptyEntries) // new char[]{' '},StringSplitOptions...
                    .Select(int.Parse).ToList();
                result.AddRange(nums);
            }
            
            Console.WriteLine(string.Join(" ",result));
        }
    }
}

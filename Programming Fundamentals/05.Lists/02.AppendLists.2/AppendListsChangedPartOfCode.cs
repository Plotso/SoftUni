using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendLists._2
{
    class AppendListsChangedPartOfCode
    {
        static void Main(string[] args)
        {
            List<string> lists = Console.ReadLine().Split('|').ToList();
            lists.Reverse();
            var result = new List<string>();
            foreach (var list in lists)
            {
                var nums = list.Split(' ').ToList();
                foreach (var num in nums)
                {
                    if (num != "")
                    {
                        result.Add(num);
                    }
                }
               
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
//Seen from Nakov
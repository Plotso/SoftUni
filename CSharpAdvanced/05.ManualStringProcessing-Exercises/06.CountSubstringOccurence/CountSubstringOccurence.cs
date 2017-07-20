namespace _06.CountSubstringOccurence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountSubstringOccurence
    {
        public static void Main()
        {
            //var text = Console.ReadLine();
            //var  subString = Console.ReadLine();

            //var count = text.Select((c, i) => text.Substring(i))
            //    .Count(x => x.StartsWith(subString, StringComparison.CurrentCultureIgnoreCase));

            //Console.WriteLine(count);

            var text = Console.ReadLine().ToLower();
            var searchString = Console.ReadLine().ToLower();
            var count = 0;
            var index = text.IndexOf(searchString);
            while (index != -1)
            {
                count++;
                index = text.IndexOf(searchString, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}

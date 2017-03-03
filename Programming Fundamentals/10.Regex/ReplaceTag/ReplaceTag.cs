using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceTag
{
    public class ReplaceTag
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"<a.*href=(.*)>(.*)<\/a>";
            //var patternn = @"<a.*href=("" | ').*\1>.*?<\/a>";
            //var regex = new Regex(pattern);
            var replacement = @"[URL href=$1]$2[/URL]";
            while (input != "end")
            {
                var replaced = Regex.Replace(input,pattern,replacement);
                Console.WriteLine(replaced);
                input = Console.ReadLine();
            }
            
        }
    }
}

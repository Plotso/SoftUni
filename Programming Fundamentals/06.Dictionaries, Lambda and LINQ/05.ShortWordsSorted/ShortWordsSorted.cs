namespace _05.ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShortWordsSorted
    {
        public static void Main()
        {
            var separators = new char [] 
            {'.', ',', ':' ,';' ,'(', ')','[', ']' ,'"', '\'', '\\', '/', '!', '?', ' '};
            var input = Console.ReadLine()
                .Split(separators,StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .Where(x => x.Length < 5)
                .OrderBy(x => x)
                .Distinct()
                ;
            Console.WriteLine(string.Join(", ", input));

        }
    }
}

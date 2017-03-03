namespace _01.ReverseString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class ReverseString
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();
            var reverseString = inputString.Reverse();
            Console.WriteLine(string.Join("",reverseString));
        }
    }
}

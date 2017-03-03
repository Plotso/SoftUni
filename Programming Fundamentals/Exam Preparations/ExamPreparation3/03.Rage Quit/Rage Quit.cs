namespace _03.Rage_Quit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var stringInInput = Regex.Split(input, @"[0-9]+");
            var numbersInInput = new List<int>();
            //var lengthOf
            foreach (var item in stringInInput)
            {
                var exactPositionOfNumber = input.Skip(item.Length).Take(1);//.Select(int.Parse); 
                //numbersInInput.Add(input[exactPositionOfNumber]);

            }
        }
    }
}

namespace _04.AddVAT
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AddVAT
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            input.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n *= 1.2)
                .ToList()
                .ForEach(n => Console.WriteLine($"{n:f2}")); 
        }
    }
}

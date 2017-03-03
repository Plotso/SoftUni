using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RoundingNumbersAwayFromZero2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var readNumbers = double.Parse(Console.ReadLine());
            string readNumbers = Console.ReadLine();
            double[] nums = double.Parse(Console.ReadLine());
            var roundedNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
                roundedNums[i] = (int)Math.Round(nums[i],
                MidpointRounding.AwayFromZero);

            for (int i = 0; i < nums.Length; i++)
                Console.WriteLine($"{nums[i]} -> {roundedNums[i]}");

        }
    }
}

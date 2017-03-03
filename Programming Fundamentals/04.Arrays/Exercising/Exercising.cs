using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercising
{
    class Exercising
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var splitText = text.Split(',', ' ');//.Select(int.Parse).ToArray();
            var numbers = new int[splitText.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                var currentText = splitText[i];
                var currentNumber = int.Parse(currentText);
                numbers[i] = currentNumber;
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
// int n = int.Parse(Console.ReadLine());
// var numbers = new int[n];
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = int.Parse(Console.ReadLine());


// }
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine("numbers[{0}] -> {1}", i, numbers[i]);
// }
//// Console.WriteLine(string.Join("\n",numbers));






//var numbers = new int[int.Parse(Console.ReadLine())];
//            for (int i = 0; i<numbers.Length; i++)
//            {
//                numbers[i] = int.Parse(Console.ReadLine());
//            }
//            for (int i = 0; i<numbers.Length; i++)
//            {
//                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
//            }


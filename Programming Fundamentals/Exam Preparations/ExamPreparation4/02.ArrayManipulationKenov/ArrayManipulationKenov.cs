namespace _02.ArrayManipulationKenov
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ArrayManipulationKenov
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                var commandParts = command
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (commandParts[0])
                {
                    case "exchange":
                        input = Exchange(input, int.Parse(commandParts[1]));
                        break;
                    case "max":
                    case "min":
                        MaxAndMin(input, commandParts[0], commandParts[1]);
                        break;
                    case "first":
                    case "last":
                        FirstAndLast(input, commandParts[0], int.Parse(commandParts[1]),commandParts[2]);
                        break;
                }
            }
            //var inputAsString = string.Join(", ",input);

            //Console.WriteLine($"[{inputAsString}]");
            PrintArray(input);
        }

        private static void FirstAndLast(int[] input, string command, int count, string evenOrOdd)
        {
            if (count > input.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            var filter = FilterEvenOrOdd(input, evenOrOdd);

            int[] result;

            if (command == "first")
            {
                result = filter.Take(count).ToArray();
            }
            else
            {
                result = filter.Reverse().Take(count).Reverse().ToArray();
            }
            PrintArray(result);
        }

        private static void MaxAndMin(int[] input, string command, string evenOrOdd)
        {
            //var filter = evenOrOdd == "even"
            //    ? // izpulni kakvo se sluchva tuk ako e even // true
            //    : // izpulni drugoto // false
            //    ;
            //Func<int,bool> filter = n => evenOrOdd == "even" //iznesen .Where()
            //    ? n % 2 == 0
            //    : n % 2 == 1 
            //    ;
            //var filter = input
            //    .Where(n => evenOrOdd == "even"
            //           ? n % 2 == 0
            //           : n % 2 == 1);

            var filter = FilterEvenOrOdd(input, evenOrOdd);

            if (!filter.Any())
            {
                Console.WriteLine("No matches");
                return;
            }

            var result = command == "max"
                ? filter.Max()
                : filter.Min();

            Console.WriteLine(Array.LastIndexOf(input,result));
        }

        private static int[] Exchange(int[] input, int index)
        {
            if (index < 0 || index >= input.Length)
            {
                Console.WriteLine("Invalid index");
                return input;
            }
            var left = input.Take(index + 1);
            var right = input.Skip(index + 1);
            return right.Concat(left).ToArray();
        }

        private static int[] FilterEvenOrOdd(int[] input,string evenOrOdd)
        {
            return  input
                .Where(n => evenOrOdd == "even"
                       ? n % 2 == 0
                       : n % 2 == 1)
                .ToArray();
        }
        private static void PrintArray(int[] input)
        {
            var inputAsString = string.Join(", ", input);

            Console.WriteLine($"[{inputAsString}]");
        }
    }
}

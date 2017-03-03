namespace _02.CommandInterpreterWithMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CommandInterpreterWithMethods
    {
        public static void Main()
        {
            var inputArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                var commandToDo = command[0];

                switch (commandToDo)
                {
                    case "reverse":
                        var start = int.Parse(command[2]);
                        var count = int.Parse(command[4]);

                        if (IsValid(inputArray,start,count))
                        {
                            //Reverse(inputArray, start, count);
                            inputArray.Reverse(start, count);
                            //Console.WriteLine($"[{string.Join(", ",inputArray)}]");
                            
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                            
                        }
                        break;
                    case "sort":
                        var startS = int.Parse(command[2]);
                        var countS = int.Parse(command[4]);

                        if (IsValid(inputArray, startS, countS))
                        {
                            //Sort(inputArray, startS, countS);

                            inputArray.Sort(startS, countS,StringComparer.InvariantCulture);
                            //Console.WriteLine($"[{string.Join(", ", inputArray)}]");
                            
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                            
                        }
                        break;
                    case "rollLeft":
                        var rollLeftCount = int.Parse(command[1]);

                        RollLeft(inputArray, rollLeftCount);
                        break;
                    case "rollRight":
                        var rollRightCount = int.Parse(command[1]);

                        RollRight(inputArray, rollRightCount);
                        break;

                }
                command = Console.ReadLine().Split();
            }
            PrintArray(inputArray);
        }

        private static void RollRight(List<string> inputArray, int rollRightCount)
        {
            if (rollRightCount < 0)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            rollRightCount = rollRightCount % inputArray.Count;
            for (int i = 0; i < rollRightCount; i++)
            {
                var lastElem = inputArray[inputArray.Count - 1];
                inputArray.RemoveAt(inputArray.Count - 1);
                inputArray.Insert(0, lastElem);
                
            }
        }

        private static void RollLeft(List<string> inputArray, int rollLeftCount)
        {
            if (rollLeftCount < 0)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            rollLeftCount = rollLeftCount % inputArray.Count;
            for (int i = 0; i < rollLeftCount; i++)
            {
                var firstElem = inputArray[0];
                for (int j = 0; j < inputArray.Count - 1; j++)
                {
                    inputArray[j] = inputArray[j + 1];
                }
                inputArray[inputArray.Count - 1] = firstElem;

                //inputArray[inputArray.Count - 1] = firstElem;

            }

        }

        private static void Sort(List<string> inputArray, int startS, int countS)
        {
            var numsToChange = inputArray.Skip(startS).Take(countS).OrderBy(n => n).ToList();
            inputArray.RemoveRange(startS, countS);
            inputArray.InsertRange(startS, numsToChange);
        }

        private static void Reverse(string[] inputArray, int start, int count)
        {
            //var numsToChange = inputArray.Skip(start).Take(count).Reverse().ToList();
            //inputArray.RemoveRange(start, count);
            //inputArray.InserRange(start, count);
            //Console.WriteLine(string.Join(" ", inputArray));

            
        }

        private static bool IsValid(List<string> inputArray, int start, int count)
        {
            var finalPositionIndex = start + count;
            //In truth it is the final position,but it is not the final position index 
            //because when you START from index 3 and COUNT 5 you count indexes 3,4,5,6,7
            //which means finalPositionIndexIs 7 ,however, in truth it is just the sum of
            //start and count that must be less or equal to the array or list length/count
            //in order for the input and operation to be valid :)
            if (finalPositionIndex > inputArray.Count 
                || start < 0 
                || start >= inputArray.Count 
                || count < 0)
            {
                
                return false;
            }
            return true;
        }
        private static void PrintArray(List<string> inputArray)
        {
            var inputAsString = string.Join(", ", inputArray);

            Console.WriteLine($"[{inputAsString}]");
        }
    }
}

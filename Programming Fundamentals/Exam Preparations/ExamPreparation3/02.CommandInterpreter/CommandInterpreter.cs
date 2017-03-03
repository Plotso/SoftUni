namespace _02.CommandInterpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CommandInterpreter
    {
        public static void Main()
        {
            var inputNums = Console.ReadLine()
                .Split(new char[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries).ToList();

            var command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "reverse")
                {
                    var startNum = int.Parse(command[2]);
                    var count = int.Parse(command[4]);

                    if (startNum < 0 || startNum >= inputNums.Count || count < 0 || startNum + count > inputNums.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine().Split();
                        continue;
                    }

                    var numsToChange = inputNums.Skip(startNum).Take(count).Reverse().ToList();

                    inputNums.Reverse(startNum, count);
                    command = Console.ReadLine().Split();
                    continue;
                }

                else if (command[0] == "sort")
                {
                    var startNum = int.Parse(command[2]);
                    var count = int.Parse(command[4]);

                    if (startNum < 0 || startNum >= inputNums.Count || count < 0 || startNum + count > inputNums.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine().Split();
                        continue;
                    }

                    var numsToChange = inputNums.Skip(startNum).Take(count).OrderBy(n => n).ToList();

                    inputNums.RemoveRange(startNum, count);
                    inputNums.InsertRange(startNum, numsToChange);

                    command = Console.ReadLine().Split();
                    continue;
                }

                else if (command[0] == "rollLeft")
                {
                    var count = int.Parse(command[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine().Split();
                        continue;
                    }

                    count = count % inputNums.Count;

                    for (int i = 0; i < count; i++)
                    {
                        var numberToPutAtTheEnd = inputNums[0];
                        inputNums.Add(numberToPutAtTheEnd);
                        inputNums.RemoveAt(0);
                    }
                    command = Console.ReadLine().Split();
                    continue;
                }

                else if (command[0] == "rollRight")
                {
                    var count = int.Parse(command[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine().Split();
                        continue;
                    }

                    count = count % inputNums.Count;

                    for (int i = 0; i < count; i++)
                    {
                        var numberToPutAtTheBeginning = inputNums[inputNums.Count - 1];
                        inputNums.Insert(0, numberToPutAtTheBeginning);
                        inputNums.RemoveAt(inputNums.Count - 1);
                    }
                    command = Console.ReadLine().Split();
                    continue;
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", inputNums));

        }
    }
}

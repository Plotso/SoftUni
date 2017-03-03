namespace _02.LadyBugs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            var sizeOfField = int.Parse(Console.ReadLine());
            var fieldArray = new int[sizeOfField];

            var positionOfLB = Console.ReadLine()
                .Split();       
            var command = Console.ReadLine()
                .Split()
                .ToArray();

            var justListOfLBS = new List<int>();
            for (int i = 0; i < positionOfLB.Length; i++)
            {
                justListOfLBS.Add(int.Parse(positionOfLB[i]));
            }
            foreach (var lb in justListOfLBS)
            {
                if (fieldArray.Length >= lb + 1)
                {
                    fieldArray[lb] = 1;
                }
                else
                {
                    continue;
                }
            }

            while (command[0] != "end")
            {
                
                
                var commandLBI = int.Parse(command[0]);
                var commandLBD = command[1];
                var commandLBFlyLength = int.Parse(command[2]);
                if (fieldArray.Length < commandLBI + 1)
                {
                    //continue;
                }
                else if (fieldArray[commandLBI] == 0)
                {
                    //continue;
                }
                else
                {
                    if (commandLBD == "left")
                    {
                        var newPositionIndex = commandLBI - commandLBFlyLength;
                        if (newPositionIndex < 0)
                        {
                            //continue;
                        }
                        else if (fieldArray.Length > newPositionIndex + 1)
                        {
                            fieldArray[commandLBI] = 0;
                        }
                        else
                        {
                            
                            if (fieldArray[newPositionIndex] == 1)
                            {
                                newPositionIndex += commandLBFlyLength;
                                if (fieldArray[newPositionIndex] == 1)
                                {
                                    newPositionIndex += 1;
                                    fieldArray[commandLBI] = 0;
                                    fieldArray[newPositionIndex] = 1;
                                }
                                fieldArray[commandLBI] = 0;
                                fieldArray[newPositionIndex] = 1;
                            }
                        }
                    }
                    else if (commandLBD == "right")
                    {
                        var newPositionIndex = commandLBI + commandLBFlyLength;
                        if (fieldArray.Length >= newPositionIndex + 1)
                        {
                            if (fieldArray[newPositionIndex] == 1)
                            {
                                newPositionIndex += commandLBFlyLength;
                                if (fieldArray.Length > newPositionIndex + 1)
                                {
                                    fieldArray[commandLBI] = 0;
                                    //continue;
                                }

                                else if (fieldArray[newPositionIndex] == 1 && fieldArray.Length <= newPositionIndex + 1)
                                {
                                    newPositionIndex += commandLBFlyLength;
                                    fieldArray[commandLBI] = 0;
                                    fieldArray[newPositionIndex] = 1;
                                }
                               
                                fieldArray[commandLBI] = 0;
                                fieldArray[newPositionIndex] = 1;
                            }
                        }
                        else if (fieldArray.Length > newPositionIndex + 1)
                        {
                            fieldArray[commandLBI] = 0;
                        }
                        else
                        {
                            //continue;
                        }
                    }
                }

                
                command = Console.ReadLine().Split().ToArray();
            }
            
            Console.WriteLine(string.Join(" ",fieldArray));
        }
    }
}

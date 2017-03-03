namespace _02.ArrayManipulation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ArrayManipulation
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            var command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                if (command[0] == "exchange")
                {
                    var givenIndex = int.Parse(command[1]);
                    if (input.Count <= givenIndex)
                    {
                        Console.WriteLine($"Invalid index");
                        command = Console.ReadLine().Split();
                        continue;
                    }
                    else if (givenIndex == 0)
                    {
                        Console.WriteLine("0");
                        command = Console.ReadLine().Split();
                        continue;
                    }
                    else
                    {
                        var countOfInput = input.Count- 1;
                        var numsToMove = input.Take(givenIndex + 1).ToList();
                        input.RemoveRange(0, givenIndex + 1);
                        input.InsertRange(countOfInput - givenIndex, numsToMove);

                        
                        command = Console.ReadLine().Split();
                        continue;
                    }
                }
                else if (command[0] == "max")
                {
                    if (command[1] == "odd")
                    {
                        var inputInNum = input.Select(int.Parse).ToList();
                        //var oddNumbers = new List<int>();

                        var maxOddNum = 0;
                        var maxIndex = 0;

                        for (int i = 0; i < inputInNum.Count; i++)
                        {
                            if (inputInNum[i] % 2 != 0)
                            {
                                //oddNumbers.Add(inputInNum[i]);
                                if (inputInNum[i] >= maxOddNum)
                                {
                                    maxOddNum = inputInNum[i];
                                    if (i > maxIndex)
                                    {
                                        maxIndex = i;
                                    }
                                }
                            }
                        }

                        if (maxIndex == 0)
                        {
                            Console.WriteLine("No matches");
                        }

                        //var result = oddNumbers.OrderByDescending(n =>n ).Take(1);
                        //var finalResult = input.FindIndex(result => result);

                        Console.WriteLine(maxIndex);
                        command = Console.ReadLine().Split();
                        continue;
                    }
                    else if (command[1] == "even")
                    {
                        var inputInNum = input.Select(int.Parse).ToList();
                        

                        var maxEvenNum = 0;
                        var maxIndex = 0;

                        for (int i = 0; i < inputInNum.Count; i++)
                        {
                            if (inputInNum[i] % 2 == 0)
                            {
                                
                                if (inputInNum[i] >= maxEvenNum)
                                {
                                    maxEvenNum = inputInNum[i];
                                    if (i > maxIndex)
                                    {
                                        maxIndex = i;
                                    }
                                }
                            }
                        }

                        if (maxIndex == 0)
                        {
                            Console.WriteLine("No matches");
                        }

                        Console.WriteLine(maxIndex);
                        command = Console.ReadLine().Split();
                        continue;
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "odd")
                    {
                        var inputInNum = input.Select(int.Parse).ToList();
                        

                        var minOddNum = 0;
                        var minIndex = 0;

                        for (int i = 0; i < inputInNum.Count; i++)
                        {
                            if (inputInNum[i] % 2 != 0)
                            {
                                
                                if (inputInNum[i] <= minOddNum)
                                {
                                    minOddNum = inputInNum[i];
                                    if (i > minIndex)
                                    {
                                        minIndex = i;
                                    }
                                }
                            }
                        }

                        if (minIndex == 0)
                        {
                            Console.WriteLine("No matches");
                        }

                        
                        Console.WriteLine(minIndex);
                        command = Console.ReadLine().Split();
                        continue;
                    }
                    else if (command[1] == "even")
                    {
                        var inputInNum = input.Select(int.Parse).ToList();


                        var minEvenNum = 0;
                        var minIndex = 0;

                        for (int i = 0; i < inputInNum.Count; i++)
                        {
                            if (inputInNum[i] % 2 != 0)
                            {

                                if (inputInNum[i] <= minEvenNum)
                                {
                                    minEvenNum = inputInNum[i];
                                    if (i > minIndex)
                                    {
                                        minIndex = i;
                                    }
                                }
                            }
                        }

                        if (minIndex == 0)
                        {
                            Console.WriteLine("No matches");
                        }


                        Console.WriteLine(minIndex);
                        command = Console.ReadLine().Split();
                        continue;
                    }

                }
                else if (command[0] == "first")
                {
                    var count = int.Parse(command[1]);
                    var inputInNum = input.Select(int.Parse).ToList();
                    if (count > inputInNum.Count)
                    {
                        Console.WriteLine("Invalid Count");
                        command = Console.ReadLine().Split();
                        continue;
                    }
                    var countNumList = new List<int>();
                    if (command[2] == "odd")
                    {
                        var counter = 0;
                        for (int i = 0; i < inputInNum.Count; i++)
                        {
                            if (inputInNum[i] % 2 != 0)
                            {
                                counter++;
                                if (counter > count)
                                {
                                    break;
                                }
                                countNumList.Add(inputInNum[i]);
                                
                            }
                        }
                        if (countNumList.Count < count && countNumList.Count != 0)
                        {
                            countNumList.Clear();
                            for (int i = 0; i < inputInNum.Count; i++)
                            {
                                if (inputInNum[i] % 2 != 0)
                                {
                                    countNumList.Add(inputInNum[i]);
                                }
                            }
                            //Console.WriteLine($"[{string.Join(", ", inputInNum)}]");
                            command = Console.ReadLine().Split();
                            continue;
                        }
                        else if (countNumList.Count == 0)
                        {
                            Console.WriteLine($"[]");
                            command = Console.ReadLine().Split();
                            continue;
                        }
                        Console.WriteLine($"[{string.Join(", ",countNumList)}]");
                        command = Console.ReadLine().Split();
                        continue;
                    }
                    else if (command[2] == "even")
                    {
                        var counter = 0;
                        for (int i = 0; i < inputInNum.Count; i++)
                        {
                            if (inputInNum[i] % 2 == 0)
                            {
                                counter++;
                                if (counter > count)
                                {
                                    break;
                                }
                                countNumList.Add(inputInNum[i]);
                                
                            }
                        }
                        if (countNumList.Count < count && countNumList.Count != 0)
                        {
                            Console.WriteLine($"[{string.Join(", ", inputInNum)}]");
                            command = Console.ReadLine().Split();
                            continue;
                        }
                        else if (countNumList.Count == 0)
                        {
                            Console.WriteLine($"[]");
                            command = Console.ReadLine().Split();
                            continue;
                        }
                        Console.WriteLine($"[{string.Join(", ", countNumList)}]");
                        command = Console.ReadLine().Split();
                        continue;
                    }
                }
                else if (command[0] == "last")
                {
                    var count = int.Parse(command[1]);
                    var inputInNum = input.Select(int.Parse).ToList();
                    if (count > inputInNum.Count)
                    {
                        Console.WriteLine("Invalid Count");
                        command = Console.ReadLine().Split();
                        continue;
                    }
                    var countNumList = new List<int>();
                    if (command[2] == "odd")
                    {

                    }
                    else if (command[2] == "even")
                    {

                    }
                }
            }
            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
    }
}

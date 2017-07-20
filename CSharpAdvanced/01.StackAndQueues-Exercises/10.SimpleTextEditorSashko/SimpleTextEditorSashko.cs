namespace _10.SimpleTextEditorSashko
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SimpleTextEditorSashko
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                var commands = Console.ReadLine().Split();

                switch (commands[0])
                {
                    case "1":
                        if (!stack.Any())
                        {
                            stack.Push(commands[1]);
                        }
                        else
                        {
                            stack.Push(stack.Peek() + commands[1]);
                        }
                        break;
                    case "2":
                        var count = int.Parse(commands[1]);
                        var current = stack.Peek();
                        stack.Push(current.Substring(0, current.Length - count));
                        break;
                    case "3":
                        var index = int.Parse(commands[1]);
                        Console.WriteLine(stack.Peek()[index - 1]);
                        break;
                    case "4":
                        stack.Pop();
                        break;
                }
            }
        }
    }
}

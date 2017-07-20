namespace _02.SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SimpleCalculator
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var stack = new Stack<string>(/*input.Reverse()*/);

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                var op = stack.Pop();
                var second = int.Parse(stack.Pop());

                switch (op)
                {
                    case "+":
                        stack.Push((first + second).ToString());
                        break;
                    case "-":
                        stack.Push((first - second).ToString());
                        break;
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}

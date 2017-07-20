﻿namespace _07.BalancedParentheses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BalancedParentheses
    {
        public static void Main()
        {
            var paranthesisLine = Console.ReadLine();

            var openedParanthesis = new Stack<char>();
            var openingCases = new char[] { '{', '[', '(' };
            var mismatch = false;

            for (int i = 0; i < paranthesisLine.Length; i++)
            {
                if (openingCases.Contains(paranthesisLine[i]))
                {
                    openedParanthesis.Push(paranthesisLine[i]);
                }
                else
                {
                    if (openedParanthesis.Count() == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    switch (paranthesisLine[i])
                    {
                        case '}':
                            if (openedParanthesis.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ']':
                            if (openedParanthesis.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ')':
                            if (openedParanthesis.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}

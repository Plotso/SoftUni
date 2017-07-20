﻿namespace _02.DateModifier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DateModifier
    {
        public static void DatesDifference(string firstDate, string secondDate)
        {
            int[] d1 = firstDate.Split(new char[0], StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] d2 = secondDate.Split(new char[0], StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            DateTime dateOne = new DateTime(d1[0], d1[1], d1[2]);

            DateTime dateTwo = new DateTime(d2[0], d2[1], d2[2]);

            TimeSpan difference = dateOne.Subtract(dateTwo);

            Console.WriteLine(Math.Abs(difference.TotalDays));
        }
    }
}

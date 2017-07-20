namespace _02.DateModifier
{
    using System;
    public class StartUp
    {
        //this is the 5th task from the homework
        static void Main(string[] args)
        {
            var date1 = Console.ReadLine();

            var date2 = Console.ReadLine();

            DateModifier.DatesDifference(date1, date2);
        }
    }
}

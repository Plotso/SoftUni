namespace _04.DistanceBetweenPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DistanceBetweenPoints
    {
       public static void Main()
        {
            var firstInput = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var firstPoint = new Point
            {
                X = firstInput[0],
                Y = firstInput[1]
            };
            var secondInput = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var secondPoint = new Point
            {
                X = secondInput[0],
                Y = secondInput[1]
            };

            var result = CalculateDistane(firstPoint, secondPoint);
            Console.WriteLine($"{result:f3}");


        }
        public static double CalculateDistane(Point firstPoint,Point secondPoint)
        {
            var diffX = firstPoint.X - secondPoint.X;
            var diffY = firstPoint.Y - secondPoint.Y;

            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);
        }
    }
}

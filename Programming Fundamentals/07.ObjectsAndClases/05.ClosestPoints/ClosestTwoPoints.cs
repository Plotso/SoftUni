namespace _05.ClosestPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    //public class Point
    //{
    //    public double X { get; set; }

    //    public double Y { get; set; }
    //}

    public class ClosestTwoPoints
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var points = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                var currentPointParts = Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToList();

                var currentPoint = new Point
                {
                    X = currentPointParts[0],
                    Y = currentPointParts[1]
                };
                //points.Add(new Point
                //{
                //    X = currentPointParts[0],
                //    Y = currentPointParts[1]
                //});
                points.Add(currentPoint);
            }
            var minDistanceSoFar = double.MaxValue;
            Point firstPointMin = null;
            Point secondPointMin = null;
            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];

                    var currentDistance = CalculateDistane(firstPoint, secondPoint);
                    if (currentDistance < minDistanceSoFar)
                    {
                        minDistanceSoFar = currentDistance;
                        firstPointMin = firstPoint;
                        secondPointMin = secondPoint;
                    }
                }
            }
            Console.WriteLine($"({minDistanceSoFar:f3})");
            Console.WriteLine($"({firstPointMin.X}, {firstPointMin.Y})");
            Console.WriteLine($"({secondPointMin.X}, {secondPointMin.Y})");
        }
        public static double CalculateDistane(Point firstPoint, Point secondPoint)
        {
            var diffX = firstPoint.X - secondPoint.X;
            var diffY = firstPoint.Y - secondPoint.Y;

            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);
        }
    }
}

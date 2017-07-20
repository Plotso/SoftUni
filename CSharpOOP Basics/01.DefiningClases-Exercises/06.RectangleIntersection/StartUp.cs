namespace _06.RectangleIntersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rectangles = new List<Rectangle>();

            for (int i = 0; i < input[0]; i++)
            {
                var rectanleTokens = Console.ReadLine().Split().ToArray();
                var id = rectanleTokens[0];
                var width = double.Parse(rectanleTokens[1]);
                var height = double.Parse(rectanleTokens[2]);
                var x = double.Parse(rectanleTokens[3]);
                var y = double.Parse(rectanleTokens[4]);

                rectangles.Add(new Rectangle(id, width, height, x, y));
            }

            for (int i = 0; i < input[1]; i++)
            {
                var pairs = Console.ReadLine().Split();
                var rectangle1 = pairs[0];
                var rectangle2 = pairs[1];
                Rectangle rect1 = rectangles.Where(r => r.id == rectangle1).First();
                Rectangle rect2 = rectangles.Where(r => r.id == rectangle2).First();
                Console.WriteLine(rect1.Intersects(rect2));
            }
        }
    }
}

namespace _06.RectanglePosition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class RectanglePosition
    {
        public static void Main()
        {
            var firstRectangleInput = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var firstRectangle = new Rectangle
            {
                Left = firstRectangleInput[0],
                Top = firstRectangleInput[1],
                Width = firstRectangleInput[2],
                Height = firstRectangleInput[3]
            };
            var secondRectangleInput = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondRectangle = new Rectangle
            {
                Left = secondRectangleInput[0],
                Top = secondRectangleInput[1],
                Width = secondRectangleInput[2],
                Height = secondRectangleInput[3]
            };
            if (FirstIsInsideSecond(firstRectangle,secondRectangle))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }

        }
        public static bool FirstIsInsideSecond(
            Rectangle first,
            Rectangle second)
        {
            var leftIsCorrect = first.Left >= second.Left;
            var rightIsCorrect = first.Right <= second.Right;
            var topIsCorrect = first.Top >= second.Top;
            var bottomIsCorrect = first.Bottom <= second.Bottom;
            return leftIsCorrect
                && rightIsCorrect
                && topIsCorrect
                && bottomIsCorrect;
        }
    }
    //public class Rectangle
    //{
    //    public int Top { get; set; }

    //    public int Left { get; set; }

    //    public int Width { get; set; }

    //    public int Height { get; set; }

    //    public int Bottom => Top - Height;
    //    //{
    //    //    get
    //    //    {
    //    //        return
    //    //    } 
    //    //}

    //    public int Right => Left + Width;

    //    public int Area()
    //    {
    //        return Width * Height;
    //    }
    //}
}

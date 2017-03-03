namespace _06.RectanglePosition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Rectangle
    {
        public int Top { get; set; }

        public int Left { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Bottom => Top - Height;
        //{
        //    get
        //    {
        //        return
        //    } 
        //}

        public int Right => Left + Width;

        public int Area()
        {
            return Width * Height;
        }
    }
}

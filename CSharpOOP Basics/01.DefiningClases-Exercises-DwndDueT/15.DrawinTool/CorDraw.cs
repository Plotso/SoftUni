﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.DrawinTool
{
    public class CorDraw
    {
        public Rectangle rectangle;

        public Square square;



        public CorDraw(Rectangle rectangle)

        {

            this.rectangle = rectangle;

        }



        public CorDraw(Square square)

        {

            this.square = square;

        }
    }
}

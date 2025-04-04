﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impl
{
    internal class Myrectangle
    {
        private Rectangle rect;
        private Color clr;

        public Rectangle Rect { get { return rect; } set { rect = value; } }
        public Color Clr { get { return clr; }  }

        public Myrectangle(Rectangle r)
        {
            rect = r;
            Random rnd= new Random();
            clr = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }
    }
}

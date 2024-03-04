using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class MyRectangle
    {

        private Rectangle rect;
        private Color color;

        public Rectangle Rect { get { return rect; } set { rect = value; } }
        public Color RectColor { get { return color; } }

        public MyRectangle(Rectangle rect)
        {
            Random rnd = new Random();
            this.rect = rect;
            color = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

    }
}

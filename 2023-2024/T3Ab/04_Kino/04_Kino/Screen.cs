using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Kino
{
    internal class Screen : Label
    {
        public Screen(int seatCount)
        {
            Location = new Point(20, 60);
            BackColor = Color.White;
            TextAlign = ContentAlignment.MiddleCenter;
            Text = "Screen";
            Width = (seatCount * 31) + ((seatCount - 1) * 10);
            Height = 30;
        }
    }
}

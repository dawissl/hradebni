using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _04_Kinosal
{
    internal class Platno : Label
    {
        public Platno(int size)
        {
            Location = new Point(20, 110);
            Width = (30 * size) + ((size - 1) * 10);
            Height = 30;
            BackColor = Color.White;
            Text = "Plátno";
            TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}

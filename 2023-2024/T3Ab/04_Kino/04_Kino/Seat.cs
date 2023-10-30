using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Kino
{
    internal class Seat : Label
    {
        public Seat(int x, int y)
        {
            BackColor = Color.Aqua;
            Width = 20;
            Height = 20
              ;
            Location = new Point(x, y);
            TextAlign = ContentAlignment.MiddleCenter;
            Click += new EventHandler(Seat_Click);

        }

        private void Seat_Click(object? sender, EventArgs e)
        {
            if(BackColor == Color.Aqua)
            {
                BackColor = Color.DeepPink;
            }
            else
            {
                MessageBox.Show($"Sedadlo {Text} je obsazené, vyberte prosím jiné.");
                
            }
        }
    }
}

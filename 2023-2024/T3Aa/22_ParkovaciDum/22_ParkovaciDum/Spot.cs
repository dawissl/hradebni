using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_ParkovaciDum
{
    public class Spot : Label
    {
        private Status stat;
        public Status SpotStatus { get { return stat; } set { stat = value; ChangeColour(); } }
        public Spot(int x, int y)
        {
            Location = new Point(10 + 60 * x, 10 + 60 * y);
            Width = 50;
            Height = 50;
            BackColor = Color.Green;
            stat = Status.FREE;
            MouseClick += new MouseEventHandler(SpotClick);
        }

        private void SpotClick(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (SpotStatus)
                {
                    case Status.FREE:
                        stat = Status.OCCUPIED;
                        break;
                    case Status.OCCUPIED:
                        stat = Status.FREE;
                        break;
                    case Status.BLOCKED:
                        MessageBox.Show("Misto je blokované");
                        break;
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                switch (SpotStatus)
                {
                    case Status.FREE:
                        stat = Status.BLOCKED;
                        break;
                    case Status.OCCUPIED:
                        MessageBox.Show("Misto je obsazené, nelze zablokovat");
                        break;
                    case Status.BLOCKED:
                        stat = Status.FREE;
                        break;
                }
            }
            ChangeColour();


        }
        private void ChangeColour()
        {
            switch (SpotStatus)
            {
                case Status.FREE:
                    BackColor = Color.Green;
                    break;
                case Status.OCCUPIED:
                    BackColor = Color.Red;
                    break;
                case Status.BLOCKED:
                    BackColor = Color.Orange;
                    break;
            }
        }

        public enum Status { FREE, OCCUPIED, BLOCKED };
    }
}
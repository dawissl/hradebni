using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grf
{

    public partial class Form1 : Form
    {
        private int x = 0;
        private int y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grf = e.Graphics;

            Point p1 = new Point(100, 20);
            Point p2 = new Point(20, 100);

            grf.DrawLine(Pens.Magenta, p1, p2);

            //x = Convert.ToInt32(axeX.Value);
            //y = Convert.ToInt32(axeY.Value);

            grf.FillRectangle(Brushes.YellowGreen, x, y, 100, 200);

            PointF p = new PointF(50, 50);
            PointF[] triangle =
            {
                p, new PointF(300,120), new PointF(120,30), p
            };
            grf.FillPolygon(Brushes.Red, triangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void axeX_ValueChanged(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void axeY_ValueChanged(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;
            panel1.Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            y++;
            panel1.Refresh();
        }
    }
}

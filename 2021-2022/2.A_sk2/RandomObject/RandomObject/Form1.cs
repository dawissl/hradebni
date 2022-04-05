using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Random rnd = new Random();
            int x, y, w, h;
            Graphics g = e.Graphics;
            if (CheckCircle.Checked)
            {
                x = rnd.Next(0, panel1.Width);
                y = rnd.Next(0, panel1.Height);
                w = rnd.Next(0, panel1.Width);
                h = rnd.Next(0, panel1.Height);
                g.FillEllipse(Brushes.Blue, x, y, w, h);
            }

            if (CheckSquare.Checked)
            {
                x = rnd.Next(0, panel1.Width);
                y = rnd.Next(0, panel1.Height);
                w = rnd.Next(0, panel1.Width);
                g.FillRectangle(Brushes.Red, x, y, w, w);
            }
            if (CheckTriangle.Checked)
            {
                Point p = new Point(
                    rnd.Next(0, panel1.Width),
                    rnd.Next(0, panel1.Height)
                    );
                Point[] points =
                {
                    p,
                    new Point (
                        rnd.Next(0, panel1.Width),
                        rnd.Next(0, panel1.Height)
                    ),
                    new Point (
                        rnd.Next(0, panel1.Width),
                        rnd.Next(0, panel1.Height)
                    ),
                    p
                };
                g.FillPolygon(Brushes.Yellow, points);
            }


        }
    }
}

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
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grf = e.Graphics;

            grf.FillRectangle(Brushes.LightBlue,
                Convert.ToInt32(coordX.Value),
                Convert.ToInt32(coordY.Value), 100, 300);


            grf.DrawEllipse(Pens.Red, 30, 30, 200, 200);

            Point p = new Point(100, 110);

            Point[] body = { p,
                new Point(300,100),
                new Point(30,30),
                p};

            grf.DrawLines(Pens.Green, body);
        }

        private void BtnRepaint_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void coordX_ValueChanged(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void coordY_ValueChanged(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
    }
}

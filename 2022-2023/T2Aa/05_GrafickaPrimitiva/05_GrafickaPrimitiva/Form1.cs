using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_GrafickaPrimitiva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            PanelDraw.Refresh();
        }

        private void PanelDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics grf = e.Graphics;

            if (CheckBoxCircle.Checked)
            {
                grf.DrawEllipse(Pens.Red, 10, 10, 100, 50);
            }


            if (CheckBoxTriangle.Checked)
            {
                Point[] body =
                            {
                new Point(0,0),
                new Point(120,60),
                new Point( 100,100),
                new Point(40,200),
                new Point(500,30),
                new Point(250,250),
                new Point(0,0)
            };
                grf.FillPolygon(Brushes.YellowGreen, body);

                grf.DrawLines(Pens.Blue, body);

                grf.DrawLine(Pens.Green, 30, 30, 50, 50);
                grf.DrawLine(Pens.Green, 50, 50, 120, 60);
                grf.DrawLine(Pens.Green, 120, 60, 30, 30);
            }


            if (CheckBoxSquare.Checked)
            {
                grf.FillRectangle(Brushes.Aquamarine, 200, 50, 120, 250);

            }








        }
    }
}

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
            Random rnd = new Random();
            if (CheckRectangle.Checked)
            {
                grf.FillRectangle(
                    PickBrush(),
                    rnd.Next(0, PanelDraw.Width),
                    rnd.Next(0, PanelDraw.Height),
                    rnd.Next(0, PanelDraw.Width), rnd.Next(0, PanelDraw.Height)
                    );

            }

            if (CheckEllipse.Checked)
            {
                grf.FillEllipse(Brushes.Green, 20, 20, 120, 250);
                grf.DrawEllipse(Pens.Red, 20, 20, 120, 250);
            }

            if (CheckPolygon.Checked)
            {
                grf.DrawLine(Pens.YellowGreen, 300, 300, 400, 20);
                grf.DrawLine(Pens.YellowGreen, 400, 20, 150, 150);
                grf.DrawLine(Pens.YellowGreen, 150, 150, 300, 300);

                Point[] body =
                {
                new Point(0,0),
                new Point(200,200),
                new Point(180,300),
                new Point(50,3),
                new Point(320,150),
                new Point(0,0)
            };

                grf.DrawLines(Pens.Black, body);
            }



        }

        private Brush PickBrush()
        {
            switch (new Random().Next(0, 4))
            {
                case 0:
                    return Brushes.Red;
                case 1:
                    return Brushes.Blue;
                case 2:
                    return Brushes.Green;
                default:
                    return Brushes.White;
            }
        }
    }
}

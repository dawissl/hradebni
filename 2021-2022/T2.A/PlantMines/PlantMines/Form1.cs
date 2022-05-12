using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantMines
{
    public partial class Form1 : Form
    {
        int x = -1, y = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point mouseClick = Cursor.Position;

            x = mouseClick.X;
            y = mouseClick.Y;
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (x != -1 && y != -1)
                g.FillRectangle(Brushes.Red, x, y, 20, 20);

            Kruh k = new Kruh(6);

            switch (k.T)
            {
                Tvar.KRUH:
                   g.FillEllipse(Brushes.Blue,0,0,)
            }
        }       
    }

  abstract class ClassTvar {

        private Tvar t;

        public Tvar T { get { return t; } set { t = value; } }

        public abstract double Obvod();
        public abstract double Obsah();
      
    }

    class NejakyTvar : ClassTvar
    {
        private double x;
        public NejakyTvar(double x)
        {
            this.x = x;
            T = Tvar.XXX;
        }

        public override double Obsah()
        {
            return x + x * 10;
        }

        public override double Obvod()
        {
            return 71 * x;
        }
    }

    class Kruh: ClassTvar
    {
        private double r;

    public double Polomer { get { return r; } }

        public Kruh(double polomer)
        {
            r = polomer;
            T = Tvar.KRUH;
        }

        public override double Obsah()
        {
            return Math.PI * r * r;
        }

        public override double Obvod()
        {
            return Math.PI * 2 * r;
        }
    }
    

    enum Tvar { OBDELNIK, CTVEREC, KRUH, TROJUHELNIK, XXX}
}

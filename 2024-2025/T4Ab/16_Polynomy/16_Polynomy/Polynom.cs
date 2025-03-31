using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Polynomy
{
    class Polynom
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private Pen line;

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }
        public double D { get => d; set => d = value; }
        public Pen Line { get => line;  }

        public Polynom(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            line = GetLineColor((int)Math.Abs(d),(int)Math.Abs(c), (int)Math.Abs(b));

        }

        private Pen GetLineColor(int d, int c, int b)
        {
            return new Pen(Color.FromArgb((d * 15) % 255, (c * 15) % 255, (b * 15) % 255));
        }

        private Point ValueY(double x)
        {
            double y = a * (x * x * x) + b * (x * x) + c * x + d;
            return new Point((int)x + 200,(int)y + 200);// počátek je ve středu
        }

        public Point[] GetFunction()
        {
            List<Point> result = new List<Point>();
            for(int i = -100; i <= 100; i++)
            {
                result.Add(ValueY(i));
            }
            return result.ToArray();
        }
        public override string ToString()
        {
            return $"{a}x^3+{b}x^2+{c}x+{d}";
        }

    }
}

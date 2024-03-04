using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Kamiony
{
    public class JizdaKamionu
    {
        private List<Point> jizda;
        private string nazev;
        private double rychlost;
        private double vzdalenost;
        private double casJizdy;

        public List<Point> Jizda { get { return jizda; } }
        public string Nazev { get { return nazev; } }

        public JizdaKamionu(List<Point> body, string nazevK)
        {
            jizda = body;
            nazev = nazevK;
            casJizdy = body.Count - 1;
            vzdalenost = SpocitejVzdalenost(body);
            rychlost = vzdalenost / casJizdy;
        }

        private double SpocitejVzdalenost(List<Point> body)
        {
            double vzdalenost = 0;
            for (int i = 0; i < body.Count - 1; i++)
            {
                double a = (body[i + 1].X - body[i].X) * (body[i + 1].X - body[i].X);
                double b = (body[i + 1].Y - body[i].Y) * (body[i + 1].Y - body[i].Y);

                vzdalenost += Math.Sqrt(a + b);
            }
            return vzdalenost;
        }
    }
}

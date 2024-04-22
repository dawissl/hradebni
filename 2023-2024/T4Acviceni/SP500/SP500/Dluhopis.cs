using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP500
{
    public class Dluhopis
    {
        private int delkaZadrzeni;
        private string nazev;
        private double rocniUrok;
        private long investice;
        private double vynos;

        public string Nazev { get { return nazev; } }
        public int DelkaZadrzeni
        {
            get { return delkaZadrzeni; }
            set { delkaZadrzeni = value; }
        }
        public double Urok { get { return rocniUrok; } }
        public double Vynos { get { return vynos; } }
        public long Investice { get { return investice; } }

        public Dluhopis(string naz, double urok, long invest, int delka)
        {
            nazev = naz;
            rocniUrok = urok;
            investice = invest;
            delkaZadrzeni = delka;
            vynos = invest;
        }

        public void Uroceni()
        {
            vynos += vynos * (1 + rocniUrok / 12);
            DelkaZadrzeni--;
            if (DelkaZadrzeni == 0)
            {
                Prodlouzeni();
            }
        }

        public double CistyVynos()
        {
            return vynos - investice;
        }

        private void Prodlouzeni()
        {
            DialogResult prodluz = MessageBox.Show("Chcete prodloužit dobu držení?", "Info", MessageBoxButtons.YesNo);
            if (prodluz != DialogResult.Yes)
            {
                DelkaZadrzeni = 12;
            }
        }
    }
}

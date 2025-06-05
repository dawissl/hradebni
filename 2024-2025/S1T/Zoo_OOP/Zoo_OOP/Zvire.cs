using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_OOP
{
    internal class Zvire
    {
        // zapouzdření atributů třídy
        private string jmeno;
        private int vek;
        private double vaha;

        public string Jmeno { get { return jmeno; } }
        // get / set ovlivňuje možnost čtení / editace vlastnosti objektu
        public double Vaha
        {
            get { return vaha; }
            set { vaha = value; }
        }
        // konstruktor třídy
        public Zvire(string name, int vek, double vaha)
        {
            this.vek = vek;
            this.jmeno = name;
            this.vaha = vaha;
        }

        public Zvire(string name, double vaha)
        {
            // new Zvire(name, 0, vaha);
            this.jmeno = name;
            this.vaha = vaha;
            vek = 0;
        }

        public void Promluv()
        {
            MessageBox.Show("Ahoj");
        }

        // reimplementace virutální funkce ToString ze třídy Object
        // ve tříde Object má funkce hlavičku public virtual string ToString()
        // demonstrace polymorfismu - nejedná se o přetížení metod
        public override string ToString()
        {
            return $"{jmeno} [{vek}], vaha: {vaha}";
        }
    }
}

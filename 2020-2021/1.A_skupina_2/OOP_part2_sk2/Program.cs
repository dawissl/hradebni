using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_part2_sk2
{
    class Program
    {
        static void Main(string[] args)
        {
            // trida clovek - jmeno, vek, vysku, vahu
            //        trida sportovec - disciplina, obdobi
            //              trida atlet - trenovanost
            //              trida maratonec - casBehu
            //       trida zamestnanec - plat, opraveneni
            //              trida sef - pocet zamestnancu
            //              trida uklizecka - prezdivka
        }
    }

    class Clovek
    {
        private string jmeno;
        private int vek;
        private double vyska;
        private double vaha;

        public Clovek(string j, double vys, double vah, int v)
        {
            jmeno = j;
            vyska = vys;
            vaha = vah;
            vek = v;
        }
    }

    class Sportovec : Clovek
    {
        private string disciplina;
        private string obdobi;

        public Sportovec(string j, double vys, double vah, int v, string ob, string dis): base(j, vys, vah, v)
        {
            disciplina = dis;
            obdobi = ob;
        }
    }

    class Zamestnanec : Clovek
    {
        private double plat;
        private string opravneni;
        public Zamestnanec(string j, double vys, double vah, int v, double p, string opr) : base(j, vys, vah, v)
        {
            plat = p;
            opravneni = opr;
        }
    }

    class Atlet : Sportovec
    {
        private double trenovanost;

        public Atlet(string j, double vys, double vah, int v, string dis, string ob, double tr) : base(j, vys, vah, v, dis, ob)
        {
            trenovanost = tr;
        }
    }

    class Maratonec : Sportovec
    {
        private double casBehu;

        public Maratonec(string j, double vys, double vah, int v, string dis, string ob, double cas) : base(j, vys, vah, v, dis, ob)
        {
            casBehu = cas;
        }
    }

    class Sef : Zamestnanec
    {
        private int pocetZamestnancu;
        public Sef(string j, double vys, double vah, int v,double p, string opr, int poc): base(j, vys, vah, v, p, opr)
        {
             pocetZamestnancu = poc;
        }
    }

    class Uklizecka : Zamestnanec
    {
        private string prezdivka;
        public Uklizecka(string j, double vys, double vah, int v, double p, string opr, string prezd) : base(j, vys, vah, v, p, opr)
        {
            prezdivka = prezd;
        }
    }
}

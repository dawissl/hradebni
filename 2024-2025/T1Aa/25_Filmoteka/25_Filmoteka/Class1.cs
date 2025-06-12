using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Filmoteka
{
    class Class1
    {
    }

    class Clovek
    {
        private string jmeno;
        private string prijmeni;
        private int vek;
        public string PredstavSe()
        {
            return $"Těší mě, jsem {jmeno} {prijmeni}";
        }
    }
    class Student : Clovek
    {
        private double prumer;
        public double Prumer() { return prumer; }
    }
    class Zamestnanec : Clovek
    {
        private int plat;
        public int ZobrazPlat() { return plat; }
    }

    class HlavniTrida
    {
        private int id;
        public HlavniTrida(int id)
        {
            this.id = id;
        }
    }
    class PodradnaTrida : HlavniTrida
    {
        private int year;
        public PodradnaTrida(int id, int year) : base(id)
        {

            this.year = year;
        }
    }
}

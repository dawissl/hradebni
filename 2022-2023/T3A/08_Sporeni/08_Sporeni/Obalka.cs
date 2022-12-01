using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Sporeni
{
    internal class Obalka
    {
        private double money;
        private int percent;
        private string note;

        public double Money { get { return money; } set { money += value; } }
        public int Percent { get { return percent; } set { percent = value; } }
        public string Note { get { return note; } }

        public Obalka(int p, string n)
        {
            money = 0;
            percent = p;
            note = n;
        }
        public override string ToString()
        {
            return $"Obálka: {money}, ({percent}%), {note}";
        }
    }
}

using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SestavaTymu
{
    public class Hrac : IComparable<Hrac>
    {
        private string name;
        private FieldPosition position;
        private int number;
        private int attack;
        private int defense;
        private int stamia;
        private double overalStatistic;

        public double Overal { get { return overalStatistic; } }
        public FieldPosition Position { get { return position; } }
        public Hrac(string n, FieldPosition fp, int num, int a, int d, int s)
        {
            name = n;
            position = fp;
            number = num;
            attack = a;
            defense = d;
            stamia = s;
            overalStatistic = ComputeOveral();
        }

        public int CompareTo(Hrac? other)
        {
            double res = overalStatistic - other.Overal;
            if (res == 0) { return 0; }
            return (res > 0) ? -1 : 1;
        }

        private double ComputeOveral()
        {
            // striker has privileged attack stats
            if (position == FieldPosition.STRIKER)
            {
                return attack + stamia * (2.0 / 3) + defense * (1.0 / 3);
            }
            else
            {
                return defense + stamia * (2.0 / 3) + attack * (1.0 / 3);
            }
        }

        public override string ToString()
        {
            string pos = "";
            if (position == FieldPosition.STRIKER) { pos = "ST"; }
            if (position == FieldPosition.GOALKEEPER) { pos = "GK"; }
            if (position == FieldPosition.DEFENDER) { pos = "DF"; }
            return $"{name} #{number} ({pos}) CLK: {Math.Round(overalStatistic, 0)}";
        }
    }

    public enum FieldPosition { GOALKEEPER, STRIKER, DEFENDER }
}

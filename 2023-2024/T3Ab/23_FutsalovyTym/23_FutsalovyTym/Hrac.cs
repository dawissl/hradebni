using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace _23_FutsalovyTym
{
    public class Hrac : IComparable<Hrac>
    {
        private string _name;
        private string _surname;
        private int _number;
        private int _attack;
        private int _defense;
        private int _stamia;
        private Position _position;
        private double _overall;

        public double Overall { get { return Math.Round(_overall, 2); } }
        public Position GetPosition { get { return _position; } }

        public Hrac(string name, string surname, int number, int attack, int defense, int stamia, Position position)
        {
            _name = name;
            _surname = surname;
            _number = number;
            _attack = attack;
            _defense = defense;
            _stamia = stamia;
            _position = position;
            _overall = ComputeOverall();
        }

        private double ComputeOverall()
        {
            switch (_position)
            {
                case Position.ST:
                    return _attack + (2.0 / 3) * _stamia + (1.0 / 3) * _defense;
                case Position.DF:
                    return _defense + (2.0 / 3) * _stamia + (1.0 / 3) * _attack;
                case Position.GK:
                    return (4.0 / 3) * _defense + (1.0 / 3) * _stamia + (1.0 / 3) * _attack;
                default: return 0;
            }
        }

        public override string ToString()
        {
            return $"#{_number} {_name} {_surname} [{_position}] ({Overall})";
        }

        public int CompareTo(Hrac? other)
        {
            if (other == null) throw new ArgumentNullException("other");
            double diff = _overall - other._overall;
            double error = 0.001;
            if (diff < error && diff > -error) return 0;
            return (int)diff;
        }
    }

    public enum Position { ST, DF, GK }
}

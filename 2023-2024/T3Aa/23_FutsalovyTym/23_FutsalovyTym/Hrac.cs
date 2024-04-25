using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
        private double _overall;
        private Positioin _position;

        public double Overall { get { return Math.Round(_overall, 2); } }
        public Positioin Position { get { return _position; } }

        public Hrac(string name, string surname, int number, int attack, int defense, int stamia, Positioin position)
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

        public int CompareTo(Hrac? other)
        {
            if (other == null) throw new ArgumentNullException("other");
            double errorValue = Math.Abs(_overall - other._overall);
            if (errorValue < 0.001) { return 0; }
            return (int)(_overall - other._overall);
        }

        private double ComputeOverall()
        {
            switch (_position)
            {
                case Positioin.STRIKER:
                    return _attack + (2.0 / 3) * _stamia + (1.0 / 3) * _defense;
                case Positioin.DEFFENDER:
                    return _defense + (2.0 / 3) * _stamia + (1.0 / 3) * _attack; ;
                case Positioin.GOALKEEPER:
                    return (1.0 / 3) * _attack + (1.0 / 3) * _stamia + (4.0 / 3) * _defense;
                default: return 0;
            }
        }

        public override string ToString()
        {
            return $"#{_number} {_name} {_surname} ({_position}) [{Overall}]";
        }
    }

    public enum Positioin { STRIKER, DEFFENDER, GOALKEEPER }
}

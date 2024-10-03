using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MotoGP
{
    public class Rider
    {
        private string name;
        private short number;
        private double experience;
        private double time = 0;
        public string Name { get { return name; } }
        public short Number { get { return number; } }
        public double Experience { get { return experience; } set { experience = value; } }
        public double Time { get { return time; } set { time = value; } }
        public Rider(string _name, short _number, double xp)
        {
            name = _name;
            number = _number;
            experience = xp;
        }
        public override string ToString()
        {
            // TODO format time hh:mm:ss
            return $"#{number} {name} - {FormatTime()}";
        }

        private string FormatTime()
        {
            // MM : SS
            int minutes = (int) time / 60;
            int seconds = (int) time % 60;
            string min = (minutes < 10) ? $"0{minutes}" : $"{minutes}";
            string sec = (seconds < 10) ? $"0{seconds}" : $"{seconds}";
            return $"{min} : {sec}";
        }
    }
}

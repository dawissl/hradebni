using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Katalog
{
    public class Polozka
    {
        private string _name, _desc;
        private int _count;

        public Polozka(string name, int count, string description = "")
        {
            _name = name;
            _count = count;
            _desc = description;
        }

        public override string ToString()
        {
            //  return "name: " + _name + " count: " + _count;
            return $"{_name} ({_count})";
        }
    }
}

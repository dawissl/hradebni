using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortObjects
{
    internal class Company: IComparable<Company>
    {
        private string name;
        private int count;
        private string color;
        private bool valid;
        
        public string Name { get { return name; } }
        public int Count { get { return count; } set { count = value; } }
        public bool Valid { get { return valid; } set { valid = value; } }


        public Company(string name, string color) {
            this.color = color;
            this.name = name;
            count = 0;
            valid = false;
        }

        public override string ToString()
        {
            return $" {name} {count} [{(valid ? "PLATNÁ" : "NEPLATNÁ")}]";
        }

        public int CompareTo(Company? other)
        {
            return count.CompareTo(other.Count)*-1;
        }
    }
}

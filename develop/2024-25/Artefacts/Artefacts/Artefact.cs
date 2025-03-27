using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artefacts
{
    internal class Artefact : IComparable<Artefact>
    {
        private string name;
        private int val;
        private double age;

        public string Name {  get { return name; } set { name = value; } }
        public int Value {  get { return val; } set { val = value; } }
        public double Age {  get { return age; } set { age = value; } }

        public Artefact(string name, int value)
        {
            this.name = name;
            this.val = value;
        }
        public Artefact(string name, int value, double age)
        {
            this.name = name;
            this.val = value;
            this.age = age;
        }
        public int CompareTo(Artefact? other)
        {
            if (other == null) return 1;
            return Name.CompareTo(other.Name);
        }
        public override string ToString()
        {
            return $"{name} {val}$ {age} let";
        }
    }
    internal class OrderByAge : IComparer<Artefact>
    {
        public int Compare(Artefact? x, Artefact? y)
        {
            if (x == null || y == null) return 0;

           return x.Age.CompareTo(y.Age);
        }
    }
}

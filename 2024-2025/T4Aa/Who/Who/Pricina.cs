using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Who
{
    public class Pricina
    {
        private int count;
        private string name;

        public string Name { get { return name; } }
        public int Count { get { return count; } }

        /// <summary>
        /// Přidání nového pacienta k existující příčině
        /// </summary>
        public void AddPacient()
        {
            count++;
        }
        public Pricina(string n)
        {
            name = n;
            count = 1;
        }
        public override string ToString()
        {
            return $"{name} [{count}]";
        }
    }
}
